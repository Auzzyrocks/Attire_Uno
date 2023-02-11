## Name
Attire

## Description
Attire is a Windows desktop based application that provides users with a weather forecast and corresponding clothing recomendation. 

# Installation Instructions

1. Install Visual Studio 2022

2. Follow these instructions to install the appropriate packages and dependencies for the Uno Platform framework 
	https://platform.uno/docs/articles/get-started-vs-2022.html

3. Open Visual Studio, and select 'Clone a Repository'
	- For repository location use: http://gitlab.csci.viu.ca/team-pants/attire_uno.git
	- Choose a location on your computer and clone

4. In Visual Studio, naviate to Tools > NuGet Package Manager > Manage NuGet Packages for Solution...  and install the following packages:
	- Microsoft.Extensions.Logging.Abstractions
	- Microsoft.Extensions.Logging.Console
	- Microsoft.WinAppDriver.Appium.WebDrive
	- Microsoft.Windows.CsWinRT
	- Microsoft.Windows.SDK.BuildTools
	- Microsoft.WindowsAppSDK
	- Refractored.MvvmHelpers
	- System.Data.SQLite.Core
	- Uno.Core
	- Uno.Core.Extensions.Logging.Singleton
	- Uno.WinUI

5. To build and run the application go to Build > Build Solution

6. Log in using: 
	-username: userdemo
	-password: demo
	

## Usage

1. Starting the application will take you to the login page. Begin by clicking 'Create An Account' 

2. Fill out the information to create your account credentials

3. Return to the login page and sign in using your credentials 

4. You will be taken to the home page, where you can see the current location, current weather, and your recomendation

5. You can use the Settings page to change your account preferences

7. The Forecast page will show the forecast for the upcoming week


## Support
This project is no longer supported. 


## Authors and acknowledgment

This project was built for CSCI 265 at Vancouver Island University, by the following contributors: 

Austin Shouli, 
Riley MacDonald,
Brandon Cosh,
Anandita Gupta

## License

MIT License

Copyright (c) 2022 Austin Shouli, Riley Macdonald, Brandon Cosh, Anandita Gupta

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

## Project status

The project has ceased active delopment. However, it can be built and used in it's current state.
