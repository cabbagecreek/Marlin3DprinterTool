# Marlin3DprinterTool

Marlin3dPrinterTool is a open-source software that helps you configure and test your 3D printer. The software contains some components that are not free and leave some demo and watermarks. The Software is ditributed with "beerware license" as in "free as in beer" and all donations will be used to pay for the components.
  
The software is under development and some features ar not fully tested on all types of 3D printers. 
The code is tested on:
BigBox Pro
Rigidbot Big
RapideLite 200

The main features are:
* Endstop testing
* Bed limit and bed abjusters position
* Z-probe configuration
* Bed Level Tool
* Scan building surface and create visual chart
* Z-rod maintenance
* Auto PID calibration
* Extruder calibration
* Firmware upgrade and migration


# Installing

the installer can be found at https://github.com/cabbagecreek/Marlin3DprinterTool/releases/tag/v0.1-beta

1. Press download
2. Run the MSI
3. The program will create shortcut in the Start-menu and on the desktop 



# Endstop testing

Visual status Endstop. The function M119 uses and interprets the response. This feature makes it possible to control the connected Endstops reacts to physical contact. The function can detect all types of Endstop that Marlin can be configured.
* X-min
* X-max
* Y-min
* Y-max
* Z-min (which is sometimes used as the Z-probe)
* Z max

# Bed limit
Move the extruder to the construction surface boundaries and save its corners. Adjustment screws location indicated by placing the extruder / z probe as close as possible and save the position.
Safe Home is a position where it is easy to change the adjustment of the bed.

These values are saved and used for the semi-automatic bed level adjustment
and for scanning the buildsurface.

# Z-probe configuration
Test and configure Engage and release of Z-probe.
Find the Z-probe offset. This is done by a procedure that combines the "paper-under-nozzle" with the fact that the printer itself can meassure the z-probe offset. The function is created with a serie of Gcode commands and some calculation

# Bed Level Tool
Uses the bed limits and the adjusters position to create a suggestion how to adjust the bed.
Each adjustment point/screw will give 
* Clockwise/counterClockwise turn of the adjuster
* Amount of turn described as hours:minutes where 1:20 means " 1 turn = 1 hour and 1/3 turn = 20 minutes
* The lower left corner is fixed. All other adjusters are compared to this "fixed" adjuster.
* The meassured value from the z-probe is shown.

After each bed-level-procedure the adjuster is calculated and the extruder is moved to the "Safe-Home" position and the adjustmen ovf the adjusters can be done.

Repeat until all adjusters are within wanted differance. ( within 10 minutes turn is a good startingpoint)

# Scan building surface and create visual chart

Almost the same as the bed-level-procedure but with more points. (a bed-level-procedure will create a 2x2 surface chart)
This takes time but gives a visual chart of how and where the buildingsurface is uneven.

# Z-rod maintenance

Moves Z repeated up and down and makes it possible to look for points where the z-rods sticking / binding. At the same time, you can clean and lubricate the z-rods in motion

# Auto PID calibration

PID autotune for both Bed and extruder. Manual update of Firmware


# Extruder calibration

Calibrate the extruder mm-per-step using a serie of Gcode commands. Manual update of Firmware


# Firmware upgrade and migration

An editor that has syntax highlight on Marlin keywords and tries to find matching keywords in different versions of Marlin

* Updates current Firmware and makes comments and old values
* Transfer current Firmware values to a new version of Marlin

After saving updates the Arduino IDE can upload the Firmware. 

