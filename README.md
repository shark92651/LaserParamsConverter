# LaserParamsConverter
Converts parameter settings and libraries for different laser engraver wattages and lens sizes. Supports EZCAD2, EZCAD3, and LightBurn parameter library file types.

This project came about as I wanted a way to quickly convert an entire laser parameter library from a different wattage and/or lens size without having to manually convert, edit, and save each individual parameter group by hand. This utility will read and write EZCAD2, EZCAD3, and LightBurn file formats, and also includes a conversion calculator tool.

## WARNING: Please make a backup copy of any library file before use! This software is offered for free, there is no warranty, and the user accepts all risk of it's use.

## Installation  
Download the LaserParamsConverter_x.x.x.zip from the Releases link on the right-hand side of the GitHub site. Extract the files to a folder on your PC and run Setup.exe. This software is NOT signed with a trusted certificate because they cost a couple hundred dollars a year and I am giving this software away for free. You will most likely see a Windows "Smart Screen" warning you that it is an unrecognized app. You can force the install by clicking "More Info" and then "Run Anyway". You will have to trust that this software is not malicious. If you can't do that, then don't install it.

This software requires the .Net 6.0 Runtime. If the required .Net Runtime is not installed on your system, a link will be provided in order to downoad and install the Runtime. This software will only run on Microsoft Windows systems.

## Change History

### Version 1.0.7 Released 7/1/2022
*Fixed issue in LightBurn conversion where MaxPower was overwritten with MinPower  

### 1.0.6 Released 6/27/2022  
*First official release  
*Added support for saving EZCAD2 to EZCAD3 format, and vice versa  

### 1.0.5 Beta Released 6/22/2022  
*Fixed globalization issue with decimal point  

### 1.0.4 Beta Released 6/21/2022  
*Added support for EZCAD3 parameter library format  
*Added ability to save EZCAD3 library file (.ini) to LightBurn format (.clb). Compatible with LightBurn for Galvo lasers (currently in Beta)  
*Converting between EZCAD2 and EZCAD3 formats is not supported  

### 1.0.3 Beta Released 6/9/2022  
*Fixed bug where all EZCAD parameters were defaulting to "Line" instead of "Fill" when saved to LightBurn format  
*Added default "Title" and "Description" tags to EZCAD parameters when saving to LightBurn for ease of editing into proper tree format  

### 1.0.2 Beta Released 6/3/2022  
*Added ability to save EZCAD2 library file (.lib) to LightBurn format (.clb). Compatible with LightBurn for Galvo lasers (currently in Beta)  
*Added "Convert One" parameter calculator feature  
*Created Windows setup and .msi installer  

### 1.0.1 Beta Released 5/26/2022  
*First public release  
