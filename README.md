Error with Publishing a Maui Windows app, all ok until added a netstandard2.0 class library.

Select the "Testing" configuration in Visual Studio. (Any CPU)

You will notice that the solution can run successfully.

Attempt to create a deployment package:
Right-click the NewMauiApp project.
Select Publish... from the pop up menu.
Ensure Sideloading selected (and Enable automatic updates is not ticked)
Click Next
For the purposes of this sample, "No, skip package signing" should be selected in the Select signing method screen.
Click Next
In the Publishing profile, ensure "MSIX-win10-x64.pubxml" is selected.
Click Create

It will error with:
The specified RuntimeIdentifier 'win10-x64' is not recognized. See https://aka.ms/netsdk1083 for more information.


If I edit the publish profile "MSIX-win10-x64.pubxml" and change the RuntimeIdentifier value from: "win10-x64" to "win-x64"

and re-attempting to Publish results in:
1>C:\Temp\NewMauiApp\NewMauiApp\NewMauiApp.csproj(0,0): Error WMC1006: Cannot resolve Assembly or Windows Metadata file 'C:\Temp\NewMauiApp\MyClassLib\bin\Testing\net9.0-windows10.0.19041.0\MyClassLib.dll'
1>C:\Temp\NewMauiApp\NewMauiApp\NewMauiApp.csproj(0,0): Error WMC1006: Cannot resolve Assembly or Windows Metadata file 'C:\Temp\NewMauiApp\MyStandardLib\bin\Testing\netstandard2.0\MyStandardLib.dll'
