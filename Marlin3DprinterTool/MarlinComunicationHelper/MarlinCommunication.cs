using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using ZylSerialPort;

namespace MarlinComunicationHelper
{
    public sealed class MarlinCommunication
    {
        private readonly SerialPort _serialPort = new SerialPort();
        private List<string> _commands;
        private string _dataReceived;
        private FrmFirmware _firmware;
        private FrmShowCommunication _showcom;

        /// <summary>
        ///     Kill the commandstream at next command
        /// </summary>
        public bool Kill { private get; set; }

        /// <summary>
        ///     The Gcode without argument
        /// </summary>
        public string Gcode { get; set; }

        /// <summary>
        ///     Baudrate
        /// </summary>
        public string BaudRate { private get; set; }

        /// <summary>
        ///     Set the serial com port from a string like COM10
        /// </summary>
        public string Port
        {
            set { _serialPort.Port = SerialPort.StringToSerialCommPort(value); }
        }

        public List<Position> ProbeResponceList { get; set; }

        /// <summary>
        ///     If the serial port is open
        /// </summary>
        public bool IsPortOpen { get; private set; }

        public FrmShowCommunication Showform
        {
            private get { return _showcom; }
            set
            {
                _showcom = value;
                _showcom = FrmShowCommunication.InstanceFrmShowForm;

                _showcom.Show();
            }
        }

        public FrmFirmware Firmware
        {
            get
            {
                if (_firmware == null || _firmware.IsDisposed)
                {
                    return FrmFirmware.InstanceFrmFirmware;
                }
                return _firmware;
            }
            set
            {
                _firmware = value;
                _firmware = FrmFirmware.InstanceFrmFirmware;
                _firmware.Show();
            }
        }


        public void Connect()
        {
            if (_serialPort.ConnectedTo.ToString() == "None")
            {
                try
                {
                    IsPortOpen = false;
                    _serialPort.Disconnected += _serialPort_Disconnected;
                    _serialPort.Connected += _serialPort_Connected;
                    _serialPort.Received += _serialPort_Received;


                    _serialPort.BaudRate = (SerialPort.SerialBaudRate) Convert.ToInt32(BaudRate);


                    // 8 batabits No parity 1 Stop Bit
                    _serialPort.DataWidth = SerialPort.SerialDataWidth.dw8Bits;
                    _serialPort.ParityBits = SerialPort.SerialParityBits.pbNone;
                    _serialPort.StopBits = SerialPort.SerialStopBits.sb1Bit;


                    _serialPort.Open();
                }
                catch (Exception serialOpenException)
                {
                    MessageBox.Show($"The serialport {_serialPort.Port} can´t be opend!\n\n" +
                                    $"({serialOpenException.Message})"
                        , @"Cant open the Serial port", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void _serialPort_Received(object sender, DataEventArgs e)
        {
            // Read all bytes in the buffer
            _dataReceived += SerialPort.ASCIIByteArrayToString(e.Buffer);

            if (Showform != null)
            {
                _showcom.AddReceived = _dataReceived;
            }

            switch (Gcode)
            {
                case "INIT":
                    ParseInit();
                    break;
                case "G29":
                    ParseG29();
                    break;
                case "G30":
                    ParseG30();
                    break;
                case "M114":
                    ParseM114();
                    break;

                case "M119":
                    ParseM119();
                    break;

                case "M48":
                    ParseM48();
                    break;

                case "M301":
                    ParseM301();
                    break;


                case "M303":
                    ParseM303();
                    break;

                case "M304":
                    ParseM304();
                    break;

                case "M500":
                    ParseM500();
                    break;

                case "M501":
                    ParseM501();
                    break;

                default:
                    ParseDefault();
                    break;
            }
        }

        private void ParseInit()
        {

            

            if (IsPortOpen == false) _serialPort.SendASCIIString("M114" + Environment.NewLine); // Send M114 to get a ok/n 
            IsPortOpen = true;

            // Return if The _dataReceived not contains ok\n
            if (WaitForOkAndNewLineToBeReceived() == false) return;
            //// Return if The _dataReceived not contains ok\n
            //if (WaitForInitToBeDone() == false) return;

            // Create INIT responce Event
            var responce = new ResponceData(_dataReceived);

            ParseM851();



            OnInit(responce);

            //Delete the responce from the received bytes
            _dataReceived = string.Empty;


            // ReadyForNextCommand          
            OnReadyForNextCommand(EventArgs.Empty);
        }

        private void ParseM851()
        {
            string M851pattern = @"(?<=M851\sZ)[-|.|0-9]*";
            Match M851match = Regex.Match(_dataReceived, M851pattern);
            if (M851match.Success) ZprobeOffset = Convert.ToDecimal(M851match.Value.Replace('.', ','));
        }


        private void ParseG29()
        {
            // Return if The _dataReceived not contains ok\n
            if (WaitForOkAndNewLineToBeReceived() == false) return;


            // Get all responces
            var responces = GetAllResponces();

            // Create G29 responce Event
            var eventG29Resonce = new Responce(new List<string>());
            eventG29Resonce.ResponsRowList.AddRange(responces);

            OnG29Responce(eventG29Resonce);

            //Delete the responce from the received bytes
            _dataReceived = DeleteResponceUpToAndInclusiveOk(_dataReceived);

            // ReadyForNextCommand          
            OnReadyForNextCommand(EventArgs.Empty);
        }

        private void ParseG30()
        {
            // Return if The _dataReceived not contains ok\n
            if (WaitForOkAndNewLineToBeReceived() == false) return;

            // Get all responces
            var responces = GetAllResponces();

            // Create G30 responce Event
            foreach (var responce in responces)
            {
                if (responce.Contains("Bed"))
                {
                    string xstring = null;
                    string ystring = null;
                    string zstring = null;
                    try
                    {
                        // Bed X: 170.00 Y: 180.00 Z: -0.98
                        // (?: Z:\s[-] *[0 - 9] *.[0 - 9] *\s.*X:)([0 - 9] *.[0 - 9] *)


                        xstring =
                            Regex.Match(responce, @"(?:X:\s)([-]*[0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[
                                1].Value;
                        ystring =
                            Regex.Match(responce, @"(?:Y:\s)([-]*[0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[
                                1].Value;
                        zstring =
                            Regex.Match(responce, @"(?:Z:\s)([-]*[0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[
                                1].Value;
                    }
                    catch (Exception parsException)
                    {
                        MessageBox.Show($"Error in parser of G30. Error: {parsException.Message}");
                    }

                    var probePosition = new Position();
                    if (zstring != null) probePosition.Z = Convert.ToDouble(zstring.Replace(".", ","));
                    if (ystring != null) probePosition.Y = Convert.ToDouble(ystring.Replace(".", ","));
                    if (xstring != null) probePosition.X = Convert.ToDouble(xstring.Replace(".", ","));
                    ProbeResponceList.Add(probePosition);
                }
            }

            // Create G30 responce Event
            OnG30ProbeResponce(ProbeResponceList);

            //Delete the responce from the received bytes
            _dataReceived = DeleteResponceUpToAndInclusiveOk(_dataReceived);

            // ReadyForNextCommand          
            OnReadyForNextCommand(EventArgs.Empty);
        }

        private void ParseM48()
        {
            // Return if The _dataReceived not contains ok\n
            if (WaitForOkAndNewLineToBeReceived() == false) return;

            // Get all responces
            var responces = GetAllResponces();


            // Create M48 responce Event
            var eventM48Resonce = new Responce(new List<string>());
            eventM48Resonce.ResponsRowList.AddRange(responces);

            OnM48ProbeStatus(eventM48Resonce);

            //Delete the responce from the received bytes
            _dataReceived = DeleteResponceUpToAndInclusiveOk(_dataReceived);

            // ReadyForNextCommand          
            OnReadyForNextCommand(EventArgs.Empty);
        }


        private void ParseM114()
        {
            // Return if The _dataReceived not contains ok\n
            if (WaitForOkAndNewLineToBeReceived() == false) return;

            // Get all responces 
            var responces = GetAllResponces();

            // Create M114 responce Event
            foreach (var responce in responces)
            {
                if (responce.Contains("X:") && responce.Contains("Y:") && responce.Contains("Z:"))
                {
                    var xstring =
                        Regex.Match(responce, @"(?:X:)([0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                    var ystring =
                        Regex.Match(responce, @"(?:Y:)([0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                    var zstring =
                        Regex.Match(responce, @"(?:Z:)([0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                    //var estring = Regex.Match(responce, @"(?:E:)([0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value; // Not Needed (yet)
                    var currentPosition = new CurrentPosition(xstring, ystring, zstring);
                    OnM114GetCurrentPosition(currentPosition);
                }


                //Delete the responce from the received bytes
                _dataReceived = DeleteResponceUpToAndInclusiveOk(_dataReceived);

                OnReadyForNextCommand(EventArgs.Empty);
            }
        }


        private void ParseM119()
        {
            // Return if The _dataReceived not contains ok\n
            if (WaitForOkAndNewLineToBeReceived() == false) return;

            // Get all responces 
            var responces = GetAllResponces();


            var endstopstatus = new string[6];
            foreach (var responce in responces)
            {
                if (responce.Contains("x_min")) endstopstatus[0] = responce;
                if (responce.Contains("x_max")) endstopstatus[1] = responce;
                if (responce.Contains("y_min")) endstopstatus[2] = responce;
                if (responce.Contains("y_max")) endstopstatus[3] = responce;
                if (responce.Contains("z_min")) endstopstatus[4] = responce;
                if (responce.Contains("z_max")) endstopstatus[5] = responce;
            }


            var eventEndstopStatusList = new EndstopStatusList(new List<string>());
            eventEndstopStatusList.Data.AddRange(endstopstatus);


            OnM119EndStopStatus(eventEndstopStatusList);

            //Delete the responce from the received bytes
            _dataReceived = DeleteResponceUpToAndInclusiveOk(_dataReceived);

            OnReadyForNextCommand(EventArgs.Empty);
        }

        private void ParseM301()
        {
            // Return if The _dataReceived not contains ok\n
            if (WaitForOkAndNewLineToBeReceived() == false) return;

            var responceData = new ResponceData(_dataReceived);
            OnM301Responce(responceData);

            OnReadyForNextCommand(EventArgs.Empty);
        }

        private void ParseM303()
        {
            ParseTemperatures();


            var responceData = new ResponceData(_dataReceived);
            OnM303Responce(responceData);

            // Return if The _dataReceived not contains ok\n
            if (WaitForOkAndNewLineToBeReceived() == false) return;

            OnReadyForNextCommand(EventArgs.Empty);
        }

        private void ParseM304()
        {
            // Return if The _dataReceived not contains ok\n
            if (WaitForOkAndNewLineToBeReceived() == false) return;

            var responceData = new ResponceData(_dataReceived);
            OnM304Responce(responceData);

            OnReadyForNextCommand(EventArgs.Empty);
        }

        private void ParseM500()
        {
            ParseTemperatures();

            // Return if The _dataReceived not contains ok\n
            if (WaitForOkAndNewLineToBeReceived() == false) return;

            var responceData = new ResponceData(_dataReceived);
            OnM500Responce(responceData);

            

            OnReadyForNextCommand(EventArgs.Empty);
        }

        private void ParseM501()
        {
            ParseTemperatures();

            // Return if The _dataReceived not contains ok\n
            if (WaitForOkAndNewLineToBeReceived() == false) return;

            var responceData = new ResponceData(_dataReceived);

            ParseM851();
           
            OnM501Responce(responceData);
            
            OnReadyForNextCommand(EventArgs.Empty);
        }

        public decimal ZprobeOffset { get; set; }

        private void ParseTemperatures()
        {
            var pattern =
                @"\sT:.[0-9]*.[0-9]*\s\/.[0-9]*.[0-9]*.\sB:.[0-9]*.[0-9]*.\s\/.[0-9]*.[0-9]*\s\@:.[0-9]*\sB\@:[0-9]*";

            // Search for temperatures within _datareceived
            foreach (Match m in Regex.Matches(_dataReceived, pattern))
            {
                var eventTemperatures = ParseTemperatures(m.Value);

                OnTemperature(eventTemperatures);
            }

            //Remove temperatures from _dataReceived
            _dataReceived = Regex.Replace(_dataReceived, pattern, "");
        }

        private void ParseDefault()
        {
            // Return if The _dataReceived not contains ok\n
            if (WaitForOkAndNewLineToBeReceived() == false) return;

            //Delete the responce from the received bytes
            _dataReceived = DeleteResponceUpToAndInclusiveOk(_dataReceived);

            OnReadyForNextCommand(EventArgs.Empty);
        }


        private string[] GetAllResponces()
        {
            // Get all data exlusive OK
            var responce = ResponceUpToAndExlusiveOk();

            // Responce contains each row in a responce.
            // Split is done on \n
            return responce.Split('\n');
        }

        private string ResponceUpToAndExlusiveOk()
        {
            try
            {
                return _dataReceived.Substring(0, _dataReceived.ToLower().LastIndexOf("ok"));
            }
            catch (Exception)
            {
                return _dataReceived;
            }
        }

        private bool WaitForInitToBeDone()
        {
            // Remove: echo:busy: processing/n
            while (_dataReceived.Contains("echo:busy: processing\n"))
            {
                _dataReceived = _dataReceived.Replace("echo:busy: processing\n", "");
            }


            //TODO: Find a better way to find the end of INIT
            // Wait until INIT is not receiving any more bytes
            return _dataReceived.Contains("M851");
        }

        private bool WaitForOkAndNewLineToBeReceived()
        {
            // Remove: echo:busy: processing/n
            while (_dataReceived.Contains("echo:busy: processing\n"))
            {
                _dataReceived = _dataReceived.Replace("echo:busy: processing\n", "");
            }


            // Wait for OK\n to be received. 
            //If OK\n is received a complete responce to a command is received
            return _dataReceived.Contains("ok\n");
        }


        // Delete the respons up to and inclusive ok/n
        private string DeleteResponceUpToAndInclusiveOk(string responce)
        {
            try
            {
                return responce.Substring(responce.ToLower().LastIndexOf("ok") + 3);
            }
            catch (Exception)
            {
                return responce;
            }
        }

        private Temperatures ParseTemperatures(string temperatures)
        {
            //    // RECEIVED: ok T:195.2 / 195.0 B: 27.1 / 0.0 T0: 195.2 / 195.0 @:33 B@:0
            //    //SENT: M105
            //    //RECEIVED: ok T:195.4 / 195.0 B: 27.8 / 0.0 T0: 195.4 / 195.0 @:29 B@:0
            //    //SENT: M105
            //    //RECEIVED: ok T:195.5 / 195.0 B: 27.8 / 0.0 T0: 195.5 / 195.0 @:26 B@:0


            var extruderString =
                Regex.Match(temperatures, @"(?:T:)([0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value
                    .Replace(".", ",");
            if (!extruderString.Contains(","))
            {
                extruderString += ",0";
            }
            var setExtruderString =
                Regex.Match(temperatures, @"(?:T:[0-9]*.[0-9]*\s\/)([0-9]*.[0-9]*)", RegexOptions.CultureInvariant)
                    .Groups[1].Value.Replace(".", ",");
            if (!setExtruderString.Contains(","))
            {
                setExtruderString += ",0";
            }
            var heatbedTempString =
                Regex.Match(temperatures, @"(?:B:)([0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value
                    .Replace(".", ",");
            if (!heatbedTempString.Contains(","))
            {
                heatbedTempString += ",0";
            }
            var heatbedSetString =
                Regex.Match(temperatures, @"(?:B:[0-9]*.[0-9]*\s\/)([0-9]*.[0-9]*)", RegexOptions.CultureInvariant)
                    .Groups[1].Value.Replace(".", ",");
            if (!heatbedSetString.Contains(","))
            {
                heatbedSetString += ",0";
            }
            var extruder2TempString =
                Regex.Match(temperatures, @"(?:T0:)([0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value
                    .Replace(".", ",");
            if (!extruder2TempString.Contains(","))
            {
                extruder2TempString += ",0";
            }
            var extruder2SetString =
                Regex.Match(temperatures, @"(?:T0:[0-9]*.[0-9]*\s\/)([0-9]*.[0-9]*)", RegexOptions.CultureInvariant)
                    .Groups[1].Value.Replace(".", ",");
            if (!extruder2SetString.Contains(","))
            {
                extruder2SetString += ",0";
            }


            return new Temperatures(
                Convert.ToDouble(extruderString),
                Convert.ToDouble(setExtruderString),
                Convert.ToDouble(heatbedTempString),
                Convert.ToDouble(heatbedSetString),
                Convert.ToDouble(extruder2TempString),
                Convert.ToDouble(extruder2SetString)
                );
        }

        public void DisConnect()
        {
            if (IsPortOpen)
            {
                _serialPort.Close();

                for (var i = 0; i < 10; i++)
                {
                    if (IsPortOpen) return;
                    Thread.Sleep(100);
                }
            }
        }

        private void _serialPort_Disconnected(object sender, ConnectionEventArgs e)
        {
            IsPortOpen = false;

            OnDisConnect(e);
        }

        private void _serialPort_Connected(object sender, ConnectionEventArgs e)
        {
            
            Gcode = "INIT";

            _serialPort.ClearInputBuffer();

            OnReadyForNextCommand(EventArgs.Empty);
            OnConnected(e);
        }


        public string[] GetExistingSerialPorts()
        {
            return SerialPort.GetExistingCommPortNames();
        }

        public void ClearCommunication()
        {
            if (IsPortOpen)
            {
                _serialPort.ClearInputBuffer();
                _serialPort.ClearOutputBuffer();
               
            }

        }
        public void SendCommand(string command)
        {
            if (IsPortOpen)
            {
                if (Kill) _serialPort.SendASCIIString("M112" + Environment.NewLine);

                if (Showform != null)
                {
                    _showcom.AddSend = command;
                }
                // Extract the GCODE command without parameters
                Gcode = command.IndexOf(" ", StringComparison.Ordinal) > 0
                    ? command.Substring(0, command.IndexOf(" ", StringComparison.Ordinal)).Trim()
                    : command;


                // Send the command
                _serialPort.SendASCIIString(command + Environment.NewLine);
            }
        }

        public void SendCommand(List<string> commands)
        {
            _commands = commands;

            var firstCommand = _commands[0];
            _commands.RemoveAt(0);
            SendCommand(firstCommand);
        }


        private double CalculateExtrusionSteps(int extrude, double oldSteps, int meassuredUsedFilament)
        {
            // Extruder steps/mm = ( Testextruded length * old extruder steps/mm ) / used length on filament
            return Math.Round(extrude*oldSteps/meassuredUsedFilament, 3);
        }


        /// <summary>
        ///     Update the uploaded Firmware with new calibrated value
        /// </summary>
        /// <param name="extrude">Amount of extruded filament in the test</param>
        /// <param name="oldSteps">Value for Steps-per-mm before the test</param>
        /// <param name="meassuredUsedFilament">Meassured filament that is used during the test</param>
        /// <param name="updateEEprom">If the new Steps-Per-mm  should update the EEPROM</param>
        public void ExtrudeCalculationUpdate(int extrude, double oldSteps, int meassuredUsedFilament, bool updateEEprom)
        {
            var commands = new List<string>
            {
                $"M92 E{CalculateExtrusionSteps(extrude, oldSteps, meassuredUsedFilament)}" + Environment.NewLine
            };


            if (updateEEprom)
            {
                commands.Add("M501");
            }

            SendCommand(commands);
        }

        #region Temperatures

        /// <summary>
        ///     Eventhandler for Tempertatures
        /// </summary>
        public event EventHandler<Temperatures> Temperatures;

        private void OnTemperature(Temperatures temperatures)
        {
            var handler = Temperatures;
            handler?.Invoke(this, temperatures);
        }

        #endregion

        #region Connected

        public event EventHandler Connected;

        private void OnConnected(ConnectionEventArgs e)
        {
            var handler = Connected;
            handler?.Invoke(this, e);
        }

        public event EventHandler DisConnected;

        private void OnDisConnect(ConnectionEventArgs e)
        {
            var handler = DisConnected;
            handler?.Invoke(this, e);
        }

        #endregion

        #region INIT

        public event EventHandler<ResponceData> Init;

        private void OnInit(ResponceData responce)
        {
            var handler = Init;
            handler?.Invoke(this, responce);
        }

        #endregion

        #region G29Responce

        public event EventHandler<Responce> G29Responce;

        public void OnG29Responce(Responce responce)
        {
            var handler = G29Responce;
            handler?.Invoke(this, responce);
        }

        #endregion

        #region G30ProbeResponce 

        public event EventHandler<List<Position>> G30ProbeResponce;

        private void OnG30ProbeResponce(List<Position> probeResponce)
        {
            var handler = G30ProbeResponce;
            handler?.Invoke(this, probeResponce);
        }

        #endregion

        #region M48ProbeStatus

        public event EventHandler<Responce> M48ProbeStatus;

        private void OnM48ProbeStatus(Responce probeResponceList)
        {
            var handler = M48ProbeStatus;
            handler?.Invoke(this, probeResponceList);
        }

        #endregion

        #region M114 Get current position

        public event EventHandler<CurrentPosition> M114GetCurrentPosition;

        private void OnM114GetCurrentPosition(CurrentPosition currentPosition)
        {
            var handler = M114GetCurrentPosition;
            handler?.Invoke(this, currentPosition);
        }

        #endregion

        #region M119EndstopStatus

        /// <summary>
        ///     Eventhandler for M119 EndstopStatus
        /// </summary>
        public event EventHandler<EndstopStatusList> M119EndStopStatus;

        /// <summary>
        ///     Report result of M119 EndstopStatus
        /// </summary>
        /// <param name="endstopStatusList"></param>
        private void OnM119EndStopStatus(EndstopStatusList endstopStatusList)
        {
            var handler = M119EndStopStatus;
            handler?.Invoke(this, endstopStatusList);
        }

        #endregion

        #region M301Responce

        /// <summary>
        ///     Eventhandler for M119 EndstopStatus
        /// </summary>
        public event EventHandler<ResponceData> M301Responce;

        private void OnM301Responce(ResponceData responce)
        {
            var handler = M301Responce;
            handler?.Invoke(this, responce);
        }

        #endregion

        #region M303Responce

        /// <summary>
        ///     Eventhandler for M119 EndstopStatus
        /// </summary>
        public event EventHandler<ResponceData> M303Responce;

        private void OnM303Responce(ResponceData responce)
        {
            var handler = M303Responce;
            handler?.Invoke(this, responce);
        }

        #endregion

        #region M304Responce

        /// <summary>
        ///     Eventhandler for M119 EndstopStatus
        /// </summary>
        public event EventHandler<ResponceData> M304Responce;

        private void OnM304Responce(ResponceData responce)
        {
            var handler = M304Responce;
            handler?.Invoke(this, responce);
        }

        #endregion

        #region M500Responce

        /// <summary>
        ///     Eventhandler for M119 EndstopStatus
        /// </summary>
        public event EventHandler<ResponceData> M500Responce;

        private void OnM500Responce(ResponceData responce)
        {
            var handler = M500Responce;
            handler?.Invoke(this, responce);
        }

        #endregion

        #region M501Responce

        /// <summary>
        ///     Eventhandler for M119 EndstopStatus
        /// </summary>
        public event EventHandler<ResponceData> M501Responce;

        private void OnM501Responce(ResponceData responce)
        {
            var handler = M501Responce;
            handler?.Invoke(this, responce);
        }

        #endregion

        #region ReadyForNextCommand

        public event EventHandler ReadyForNextCommand;

        private void OnReadyForNextCommand(EventArgs e)
        {
            var handler = ReadyForNextCommand;

            if ((_commands == null) || (_commands.Count == 0))
            {
                handler?.Invoke(this, e);
            }
            else
            {
                var firstCommand = _commands[0];
                _commands.RemoveAt(0);
                if (_commands.Count == 0)
                {
                    _commands = null;
                }
                SendCommand(firstCommand);
            }
        }

        /// <summary>
        ///     Clear all data in the received buffer
        /// </summary>
        public void ClearReceived()
        {
            _serialPort.ClearInputBuffer();
            _dataReceived = "";
        }

        #endregion
    }


    /// <summary>
    ///     Endstop Argument
    /// </summary>
    public class EndstopStatusList : EventArgs
    {
        public EndstopStatusList(List<string> data)
        {
            Data = data;
        }

        public List<string> Data { get; }
    }


    /// <summary>
    ///     Temperature
    /// </summary>
    public class Temperatures : EventArgs
    {
        public Temperatures(double extruder, double setExtruder, double heatbed, double setHeatbed, double extruder2,
            double extruder2Set)
        {
            Extruder = extruder;
            SetExtruder = setExtruder;
            Heatbed = heatbed;
            SetHeatbed = setHeatbed;
            Extruder2 = extruder2;
            SetExtruder2 = extruder2Set;
        }


        public double Extruder { get; }
        public double SetExtruder { get; }
        public double Heatbed { get; }
        public double SetHeatbed { get; }
        public double Extruder2 { get; }
        public double SetExtruder2 { get; }
    }


    public class ResponceData : EventArgs
    {
        public ResponceData(string data)
        {
            Data = data;
        }

        public string Data { get; }
    }


    public class Responce : EventArgs
    {
        public Responce(List<string> responceRowList)
        {
            ResponsRowList = responceRowList;
        }

        public List<string> ResponsRowList { get; }
    }


    public class CurrentPosition : EventArgs
    {
        public CurrentPosition(string xposition, string yposition, string zposition)
        {
            Xdouble = Convert.ToDouble(xposition.Replace(".", ","));
            Ydouble = Convert.ToDouble(yposition.Replace(".", ","));
            Zdouble = Convert.ToDouble(zposition.Replace(".", ","));
        }


        public double Xdouble { get; }
        public double Ydouble { get; }
        public double Zdouble { get; }
    }
}