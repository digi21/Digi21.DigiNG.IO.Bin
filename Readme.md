[![NuGet](https://img.shields.io/nuget/v/Digi21.DigiNG.IO.Bin?style=flat)](https://www.nuget.org/packages/Digi21.DigiNG.IO.Bin/)

# Digi21.DigiNG.IO.Bin

This repository contains the source code of the reference assembly: Digi21.DigiNG.IO.Bin that is distributed through NuGet package for serializing classic Digi binary files.

## Publishing

Push a tag `v<version>` whose version matches `<version>` in the `.nuspec` of the `NuGet` folder. The *Release* workflow builds the reference assembly, packs it and publishes it to nuget.org with trusted publishing (repository secret `NUGET_USER`, the nuget.org profile name). The packages are not author-signed; the reference assembly is public-signed with `Digi21.PublicKey.snk`, which contains only the public key.
