@echo off
nuget.exe pack Digi21.DigiNG.IO.Bin.nuspec
nuget.exe sign Digi21.DigiNG.IO.Bin.22.0.0.nupkg -CertificateSubjectName "DREAMING WITH OBJECTS" -TimeStamper http://timestamp.comodoca.com?td=sha256.
