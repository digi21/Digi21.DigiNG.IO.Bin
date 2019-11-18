@echo off
nuget.exe pack Digi21.DigiNG.IO.Bin.nuspec
nuget.exe sign Digi21.DigiNG.IO.Bin.17.2.0.nupkg -CertificatePath dwo.pfx -TimeStamper http://tsa.starfieldtech.com
