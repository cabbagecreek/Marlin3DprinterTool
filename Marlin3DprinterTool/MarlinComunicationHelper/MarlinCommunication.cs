using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using ZylSoft.Serial;

namespace MarlinComunicationHelper
{
    /// <summary>
    /// Class that do all communication thru ZylSerial 
    /// </summary>
    public sealed class MarlinCommunication
    {

        private readonly SerialPort _serialPort = new SerialPort();
        private List<string> _commands;
        private string _dataReceived;
        private FrmShowCommunication _showcom;

        #region Properties

        /// <summary>
        /// Used to communicate the ongoing feature. 
        /// Use done when the feature is finished
        /// </summary>
        public enum Feature
        {
            /// <summary>
            /// Done = The feature is Done
            /// </summary>
            Done = 0,
            /// <summary>
            /// The Feature is testing Endstops
            /// </summary>
            EndStop = 1,
            /// <summary>
            /// Feature is trying to do a Bedlevel
            /// </summary>
            Bedlevel = 3,
            /// <summary>
            /// Doing Surface Scan
            /// </summary>
            SurfaceScan = 4,
            /// <summary>
            /// Process that do AutoBedLevel
            /// </summary>
            AutoBedLevel = 7,
            /// <summary>
            /// Learning where the FW do the MBL points
            /// </summary>
            GetMeshBedPoints = 10,
            /// <summary>
            /// Meassure the MBL points using the probe
            /// </summary>
            MeassureMesh = 11,
            /// <summary>
            /// Do the process of Automatic MBL
            /// </summary>
            AutomaticMeshBedLevel = 12,
            /// <summary>
            /// Calculating ZprobeHeight
            /// </summary>
            ZprobeHeight = 13,
            /// <summary>
            /// Search extra safety Lift of the probe
            /// </summary>
            SearchLift = 14
        }
        


        

        /// <summary>
        /// The ZprobeOffset that is found in M851
        /// </summary>
        public decimal ZprobeOffset { get; private set; }

        /// <summary>
        /// The Steps per Unit X that is found during INIT
        /// </summary>
        public string StepsPerUnitX { internal get; set; }

        /// <summary>
        /// The Steps per Unit Y that is found during INIT
        /// </summary>
        public string StepsPerUnitY { internal get; set; }

        /// <summary>
        /// The Steps per Unit Z that is found during INIT
        /// </summary>
        public string StepsPerUnitZ { internal get; set; }

        /// <summary>
        /// The Steps per Unit E that is found during INIT
        /// </summary>
        public string StepsPerUnitE { internal get; set; }

        /// <summary>
        /// The PidExtruder Kp that is found during INIT
        /// </summary>
        public string PidExtruderKp { internal get; set; }

        /// <summary>
        /// The PidExtruder Ki that is found during INIT
        /// </summary>
        public string PidExtruderKi { internal get; set; }

        /// <summary>
        /// The PidExtruder Kd that is found during INIT
        /// </summary>
        public string PidExtruderKd { internal get; set; }


        /// <summary>
        /// The PidBed Kp that is found during INIT
        /// </summary>
        public string PidBedKp { internal get; set; }

        /// <summary>
        /// The PidBed Ki that is found during INIT
        /// </summary>
        public string PidBedKi { internal get; set; }

        /// <summary>
        /// The PidBed Kd that is found during INIT
        /// </summary>
        public string PidBedKd { internal get; set; }

        /// <summary>
        /// The mean value of a M48
        /// </summary>
        public string ProbeM48MeanValue { get; internal set; }

        /// <summary>
        /// The feature that is processing
        /// </summary>
        public Feature Status { get; set; }

        /// <summary>
        /// The current position that are parsed from many GCODE
        /// </summary>
        public Position CurrentPosition { get; internal set; }

        /// <summary>
        /// The staus of all endstops
        /// </summary>
        public EndStop EndStopStatus { get; internal set; }


        /// <summary>
        ///     Kill the commandstream at next command
        /// </summary>
        public bool Kill { private get; set; }

        /// <summary>
        ///     The Gcode without argument
        /// </summary>
        public string Gcode { internal get; set; }

        /// <summary>
        ///     Baudrate
        /// </summary>
        public string BaudRate { get; set; }

        /// <summary>
        ///     Set the serial com port from a string like COM10
        /// </summary>
        public string Port
        {
            get { return _serialPort.SerialCommPortToString(_serialPort.Port); }
            set { _serialPort.Port = SerialPort.StringToSerialCommPort(value); }
        }


        /// <summary>
        /// All the proberesponces from a features ( many G30 )
        /// </summary>
        public List<Position> ProbeResponceList { get; set; }

        /// <summary>
        ///     If the serial port is open
        /// </summary>
        public bool IsPortOpen { get; private set; }



        /// <summary>
        /// Show a form of the communication and allow send commands
        /// </summary>
        public FrmShowCommunication Showform
        {
            get { return _showcom; }
            set
            {
                _showcom = value;
                _showcom = FrmShowCommunication.InstanceFrmShowForm;

                _showcom.Show();
            }
        }

        #endregion




        #region Data Is Received 
        private void _serialPort_Received(object sender, DataEventArgs e)
        {
            // Read all bytes in the buffer
            _dataReceived += SerialPort.AsciiByteArrayToString(e.Buffer);

            if (Showform != null)
            {
                _showcom.AddReceived = _dataReceived;
            }

            switch (Gcode)
            {
                case "INIT":
                    ParseInit();
                    break;
                case "G28":
                    ParseG28();
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

        #endregion



        #region Parse Received Data

        private void ParseInit()
        {
            IsPortOpen = true;

            // Create INIT responce Event
            var responce = new ResponceData(_dataReceived);

            ParseM851();


            OnInit(responce);

            //Delete the responce from the received bytes
            _dataReceived = string.Empty;


            // ReadyForNextCommand          
            OnReadyForNextCommand(EventArgs.Empty);
        }

        private void ParseG28()
        {
            // Return if The _dataReceived not contains ok\n
            //if (WaitForOkAndNewLineToBeReceived() == false) return;


            // Get all responces
            //var responces = GetAllResponces();

            //TODO: Get the current position???

            //Delete the responce from the received bytes
            _dataReceived = DeleteResponceUpToAndInclusiveOk(_dataReceived);

            // ReadyForNextCommand          
            OnReadyForNextCommand(EventArgs.Empty);


        }


        private void ParseG29()
        {
            // Return if The _dataReceived not contains ok\n
            if (WaitForOkAndNewLineToBeReceived() == false) return;


            // Get all responces
            var responces = GetAllResponces();


            // X:0.00 Y:0.00 Z:5.00 E:0.00 Count X: 0 Y:0 Z:16000
            foreach (var row in responces)
            {
                var positionPattern =
                    @"X:[0-9]*\.[0-9]*\s*Y:[0-9]*\.[0-9]*\s*Z:[0-9]*\.[0-9]*\s*E:[0-9]*\.[0-9]*\s*Count\s*X:\s*";
                var positionMatch = Regex.Match(row, positionPattern);
                if (positionMatch.Success)
                {
                    var x =
                        (double) Convert.ToDecimal(Regex.Match(row, @"(?<=X:)[0-9]*\.[0-9]*").Value.Replace('.', ','));
                    var y =
                        (double) Convert.ToDecimal(Regex.Match(row, @"(?<=Y:)[0-9]*\.[0-9]*").Value.Replace('.', ','));
                    var z =
                        (double) Convert.ToDecimal(Regex.Match(row, @"(?<=Z:)[0-9]*\.[0-9]*").Value.Replace('.', ','));
                    ProbeResponceList.Add(new Position {X = x, Y = y, Z = z});
                }
            }


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
                    if (zstring != null)
                    {
                        probePosition.Z = Convert.ToDouble(zstring.Replace(".", ","));
                    }
                    if (ystring != null)
                    {
                        probePosition.Y = Convert.ToDouble(ystring.Replace(".", ","));
                    }
                    if (xstring != null)
                    {
                        probePosition.X = Convert.ToDouble(xstring.Replace(".", ","));
                    }
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


            //ok
            //ok
            //ok
            //M48 Z - Probe Repeatability test.   Version 2.00
            //Full support at: http://3dprintboard.com/forum.php
            //Positioning probe for the test.
            //1 of 4   z: 8.705000 mean: 8.705000   sigma: 0.000000
            //2 of 4   z: 8.706875 mean: 8.705938   sigma: 0.000937
            //3 of 4   z: 8.705313 mean: 8.705730   sigma: 0.000820
            //4 of 4   z: 8.707813 mean: 8.706251   sigma: 0.001148
            //Mean: 8.706251
            //Standard Deviation: 0.001148
            //            ok
            //            echo:endstops hit:  Z:8.71
            //            ok

            // The M48 ends with a calculation of all probes test.
            // The row begins with Mean: and then the calculated value 
            // (?<=^Mean:\s*)([-,0-9]*\.[0-9]*)

            try
            {
                var meanProbeValue =
                    Regex.Match(_dataReceived, @"(?<=Mean:\s*)([-,0-9]*\.[0-9]*)", RegexOptions.CultureInvariant).Groups[1]
                        .Value;
                ProbeM48MeanValue = meanProbeValue;
            }
            catch (Exception parsException)
            {
                MessageBox.Show($"Error in parser of M48. Error: {parsException.Message}");
            }

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
                    CurrentPosition.Xstring = xstring;
                    CurrentPosition.Ystring = ystring;
                    CurrentPosition.Zstring = ystring;
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


            
            foreach (var responce in responces)
            {
                if (responce.Contains("x_min")) EndStopStatus.Xmin = responce.ToLower().Contains("triggered");
                if (responce.Contains("x_min")) EndStopStatus.Xmin = responce.ToLower().Contains("triggered");
                if (responce.Contains("y_min")) EndStopStatus.Ymin = responce.ToLower().Contains("triggered");
                if (responce.Contains("y_max")) EndStopStatus.Ymax = responce.ToLower().Contains("triggered");
                if (responce.Contains("z_min")) EndStopStatus.Zmin = responce.ToLower().Contains("triggered");
                if (responce.Contains("z_max")) EndStopStatus.Zmax = responce.ToLower().Contains("triggered");
            }


            var eventEndstopStatusList = new EndstopStatus(EndStopStatus);
            


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

        private void ParseM851()
        {
            var m851Pattern = @"(?<=M851\sZ)[-|.|0-9]*";
            var m851Match = Regex.Match(_dataReceived, m851Pattern);
            if (m851Match.Success) ZprobeOffset = Convert.ToDecimal(m851Match.Value.Replace('.', ','));
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

        #endregion


        #region Parse Temperature / Event on Temperatures

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

        #region Connect / DisConnect Serialport


        /// <summary>
        /// Connect and get the INIT without events..
        /// Timeout on first responce is 10s
        /// The following has 4s (Test of SD is slow)
        /// 
        /// </summary>
        public void Connect()
        {
            if (_serialPort.ConnectedTo.ToString() == "None")
            {
                try
                {
                    IsPortOpen = false;
                    _serialPort.Disconnected += _serialPort_Disconnected;
                    _serialPort.Connected += _serialPort_Connected;


                    _serialPort.CustomBaudRate = Convert.ToUInt32(BaudRate);
                    _serialPort.BaudRate = SerialBaudRate.Custom;


                    // 8 batabits No parity 1 Stop Bit
                    _serialPort.DataWidth = SerialDataWidth.Dw8Bits;
                    _serialPort.ParityBits = SerialParityBits.None;
                    _serialPort.StopBits = SerialStopBits.Sb1Bit;

                    CurrentPosition = new Position();
                    EndStopStatus = new EndStop();
                    ProbeResponceList = new List<Position>();

                    // Activate a true licence
                    var config = new Configuration();

                    if (!string.IsNullOrEmpty(Configuration.Decrypt(config.LicenseKey)))
                    {
                        _serialPort.UnlockKey = "FA3450FEA2344897EFC34325BA391072";
                    }


                    _serialPort.NewLine = "\n";
                    _serialPort.AutoReceive = false;
                    _serialPort.Open();

                    _dataReceived = "";
                    var rec = _serialPort.ReadLine(10); //TODO: Config of initial timeout
                    while (true)
                    {
                        var lastreceived = _serialPort.LastTimeReceived;

                        _dataReceived += rec + Environment.NewLine;

                        var timeDiff = DateTime.Now - lastreceived;
                        if (timeDiff.Seconds >= 4) break; //TODO: Config of timeout
                        rec = _serialPort.ReadLine(4);
                    }

                    if (!_serialPort.IsConnected()) return;
                    ParseInit();
                    _serialPort.AutoReceive = true;
                    _serialPort.Received += _serialPort_Received;
                }
                catch (Exception serialOpenException)
                {
                    MessageBox.Show($"The serialport {_serialPort.Port} can´t be opend!\n\n" +
                                    $"({serialOpenException.Message})"
                        , @"Cant open the Serial port", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        /// <summary>
        /// Close the Comport and wait for it to be done
        /// </summary>
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


        /// <summary>
        /// Get the existing Comports
        /// </summary>
        /// <returns></returns>
        public string[] GetExistingSerialPorts()
        {
            return SerialPort.GetExistingCommPortNames();
        }


        /// <summary>
        /// Clear the communication
        /// </summary>
        public void ClearCommunication()
        {
            if (IsPortOpen)
            {
                _serialPort.ClearInputBuffer();
                _serialPort.ClearOutputBuffer();
            }
        }
        #endregion

        #region SendCommand

        /// <summary>
        /// Send a single GCODE. Check for each command if Kill signal is received
        /// </summary>
        /// <param name="command"></param>
        public void SendCommand(string command)
        {
            if (IsPortOpen)
            {
                //TODO: _serialPort.SendAsciiStringLine()
                if (Kill) _serialPort.SendAsciiString("M112" + Environment.NewLine);

                if (Showform != null)
                {
                    _showcom.AddSend = command;
                }
                // Extract the GCODE command without parameters
                Gcode = command.IndexOf(" ", StringComparison.Ordinal) > 0
                    ? command.Substring(0, command.IndexOf(" ", StringComparison.Ordinal)).Trim()
                    : command;


                // Send the command
                //TODO: _serialPort.SendAsciiStringLine()
                _serialPort.SendAsciiString(command + Environment.NewLine);
            }
        }

        /// <summary>
        /// Send a list of commands . Each command uses SendCommand with the single GCODE
        /// </summary>
        /// <param name="commands"></param>
        public void SendCommand(List<string> commands)
        {
            _commands = commands;

            var firstCommand = _commands[0];
            _commands.RemoveAt(0);
            SendCommand(firstCommand);
        }
        #endregion


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

        

        #region Connected
        /// <summary>
        /// Event when the ZylSerial is connected
        /// </summary>
        public event EventHandler Connected;

        private void OnConnected(ConnectionEventArgs e)
        {
            var handler = Connected;
            handler?.Invoke(this, e);
        }


        /// <summary>
        /// Event when ZylSerial is disConnected
        /// </summary>
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
        /// TODO: EndstopStatusList -> EndstopStatus
        public event EventHandler<EndstopStatus> M119EndStopStatus;

        /// <summary>
        ///     Report result of M119 EndstopStatus
        /// </summary>
        /// <param name="endstopStatusList"></param>
        /// TODO: EndstopStatusList -> EndstopStatus
        private void OnM119EndStopStatus(EndstopStatus endstopStatusList)
        {
            var handler = M119EndStopStatus;
            handler?.Invoke(this, endstopStatusList);
        }

        #endregion

        #region M301Responce

        /// <summary>
        ///     Eventhandler for M301
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
        ///     Eventhandler for M304
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
        ///     Eventhandler for M500
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
        ///     Eventhandler for M501
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

        #region Manually do the G30 command
        /// <summary>
        /// 
        /// </summary>
        public void G30()
        {
            // 
            _serialPort.AutoReceive = false;
            _serialPort.Received -= _serialPort_Received;

            // G90 Absolute mode
            // G91 Relative mode

            List<string> lower04 = new List<string> { "G90", "G1 Z-0.4", "G91", "M119"};
            List<string> lower02 = new List<string> { "G90", "G1 Z-0.2", "G91", "M119" };
            List<string> lower01 = new List<string> { "G90", "G1 Z-0.1", "G91", "M119" };
            List<string> rise04  = new List<string> { "G90", "G1 Z0.4", "G91", "M119" };
            List<string> rise08  = new List<string> { "G90", "G1 Z0.8", "G91", "M119" };

           
            SendCommand(rise08); // Rise the probe 0.8 mm

            // lower the probe in 0.4mm steps
            while (!EndStopStatus.Zmin)
            {
                SendCommand(lower04);
                _dataReceived = "";
                var rec = _serialPort.ReadLine(10); //Time to lower the probe 0.4 mm
                while (true)
                {
                    var lastreceived = _serialPort.LastTimeReceived;

                    _dataReceived += rec + Environment.NewLine;

                    var timeDiff = DateTime.Now - lastreceived;
                    if (timeDiff.Seconds >= 4) break; //TODO: 
                    rec = _serialPort.ReadLine(4);
                    ParseM119();
                }
            }


            SendCommand(rise04); // Rise the probe 0.4 mm

            // lower the probe in 0.2mm steps
            while (!EndStopStatus.Zmin)
            {
                SendCommand(lower02);
                _dataReceived = "";
                var rec = _serialPort.ReadLine(10); //Time to lower the probe 0.4 mm
                while (true)
                {
                    var lastreceived = _serialPort.LastTimeReceived;

                    _dataReceived += rec + Environment.NewLine;

                    var timeDiff = DateTime.Now - lastreceived;
                    if (timeDiff.Seconds >= 4) break; //TODO: 
                    rec = _serialPort.ReadLine(4);
                    ParseM119();
                }
            }

            SendCommand(rise04); // Rise the probe 0.4 mm

            // lower the probe in 0.1mm steps
            while (!EndStopStatus.Zmin)
            {
                SendCommand(lower01);
                _dataReceived = "";
                var rec = _serialPort.ReadLine(10); //Time to lower the probe 0.4 mm
                while (true)
                {
                    var lastreceived = _serialPort.LastTimeReceived;

                    _dataReceived += rec + Environment.NewLine;

                    var timeDiff = DateTime.Now - lastreceived;
                    if (timeDiff.Seconds >= 4) break; //TODO: 
                    rec = _serialPort.ReadLine(4);
                    ParseM119();
                }
            }

            _serialPort.AutoReceive = true;
            _serialPort.Received += _serialPort_Received;

            SendCommand("M114");
        }

        /// <summary>
        /// Position the probe before Probing
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="rise"></param>
        public void G30(int x, int y, int rise)
        {
            // Move to X and Y
            List<string> commands = new List<string> { $"G1 X{x} Y{y}", "G90", $"G1 Z-{rise}", "G91", "M114" };
            SendCommand(commands);

        }
        #endregion

    }


    #region EndStop/EndstopStatus
    /// <summary>
    ///     Endstop Argument
    /// </summary>
    public class EndstopStatus : EventArgs
    {
        /// <summary>
        /// Endstop Status
        /// </summary>
        /// <param name="endstop"></param>
        public EndstopStatus(EndStop endstop)
        {
            Status = endstop;
        }

        /// <summary>
        /// The status for all endstops
        /// </summary>
        private EndStop Status { get; }
    }

    /// <summary>
    /// Endstop with the status of all endstops
    /// </summary>
    public class EndStop
    {
        /// <summary>
        /// status for Xmin
        /// </summary>
        public bool Xmin { get; set; }

        /// <summary>
        /// status for Xmax
        /// </summary>
        public bool Xmax { get; set; }

        /// <summary>
        /// status for Ymin
        /// </summary>
        public bool Ymin { get; set; }

        /// <summary>
        /// status for Ymax
        /// </summary>
        public bool Ymax { get; set; }

        /// <summary>
        /// status for Zmin
        /// </summary>
        public bool Zmin { get; set; }

        /// <summary>
        /// status for Zmax
        /// </summary>
        public bool Zmax { get; set; }



    }
    #endregion
    
    #region Temperature
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
    #endregion
    
    #region ResponceData / generic responce
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

    #endregion

    #region Current Position
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
    #endregion
}