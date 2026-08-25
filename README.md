# Tunlocker Tool Pro

Windows tool for servicing Android phones over USB: flashing firmware, removing FRP locks, repairing IMEI, and reading or writing device partitions. Written in C# with WinForms on .NET Framework 4.7.2. Supports MediaTek, Qualcomm (EDL), Samsung (Odin), Spreadtrum/Unisoc, Huawei Kirin and Motorola devices.

![Build & Package](https://github.com/tfastdigital/Tunlocker-Tool-Pro/actions/workflows/build-and-package.yml/badge.svg)

Legal note: only use this on devices you own or are authorized to service. Bypassing FRP on stolen phones, or unlocking devices without permission, is illegal in most countries. Tunlocker Tool Pro is copyright Tfast Digital Agency (https://tfastdigital.com/).

## Download

Latest build: [TunlockerToolPro-v2.0.0-win-x64.zip](https://github.com/tfastdigital/Tunlocker-Tool-Pro/releases/download/v2.0.0/TunlockerToolPro-v2.0.0-win-x64.zip)

All versions: https://github.com/tfastdigital/Tunlocker-Tool-Pro/releases

Extract the zip anywhere, run `Tunlocker Tool.exe` and log in. No installation needed. Windows Defender sometimes flags phone tools as PUP; if it blocks the file, add the folder to Defender exclusions. The exe is not code-signed.

## Login and accounts

Login takes the username (email) and password of your licensed account. The client encrypts the request and sends it to `https://api.tfastdigital.com/api/server` (`loginapi/`). The server answers with your license state: credit balance, license type (`CREDIT LICENSE` or annual), expiry dates, and any model or function restrictions.

There is no demo account in the source. Accounts are issued by Tfast Digital Agency:

- Panel: https://panel.tfastdigital.com/OperationTools/Index
- Telegram: https://t.me/tfasthub
- WhatsApp: +256 751 399 620 (https://wa.me/256751399620)

The login protocol is documented in [docs/BACKEND_GUIDE.md](docs/BACKEND_GUIDE.md).

## What it does

- MediaTek: BROM and preloader support via a C# port of mtkclient (`mtkclient2/`)
- Qualcomm: EDL (Sahara/Firehose) in `EDL.cs`
- Samsung: Odin protocol in `OdinClient/`
- Spreadtrum/Unisoc: SPD/ResearchDownload in `SPD/` and `SPDR.cs`
- Huawei/Honor: Kirin over DIAGNOS in `HuaweiUnlocker/` and `kirin.cs`
- Motorola: fastboot/ADB flows in `Android_Qualcomm.cs` and `AndroidCommands.cs`
- FRP removal, firmware flashing (scatter files), partition read/write/erase
- IMEI repair and certificate files (`qcert3.cs`, `Cert.cs`)
- Read-only Ext4 parser for pulling files off partitions (`Operations/Ext4/`)
- ADB/fastboot automation (bundled adb.exe and fastboot.exe)
- AES and CRC32 helpers (`AESS.cs`, `Force/Crc32/`)

## Build from source

Needs the .NET SDK 8.0 or newer on Windows (tested with 10.0.301). The project targets net472 but builds fine with the SDK.

```bash
git clone https://github.com/tfastdigital/Tunlocker-Tool-Pro.git
cd Tunlocker-Tool-Pro
dotnet build "Tunlocker Tool.sln" -c Debug
```

Output: `bin\Debug\net472\Tunlocker Tool.exe`. Or open `Tunlocker Tool.sln` in Visual Studio 2022 and press F5.

The build prints a lot of warnings (old code) but no errors.

## Project layout

```
Tunlocker-Tool-Pro/
├── Tunlocker Tool.sln / Tunlocker Tool.csproj
├── motoulocked/
│   ├── Form1.cs                  # main window, most of the UI logic
│   ├── mtkclient2/               # C# port of mtkclient (MediaTek)
│   ├── OdinClient/               # Samsung protocol
│   ├── SPD/                      # Spreadtrum protocol
│   ├── HuaweiUnlocker/           # Kirin tools
│   ├── EDL.cs, flash.cs, FRP.cs  # Qualcomm EDL, flashing, FRP
│   ├── kirin.cs, SPDR.cs         # Huawei and Spreadtrum flows
│   ├── core/                     # API models: apilogin, tokdata, etc.
│   ├── AESS.cs, encryptor.cs     # crypto helpers
│   ├── ProcessConnection.cs      # ADB/fastboot process control
│   └── Operations/Ext4/          # Ext4 filesystem parser
├── Res/                          # third-party DLLs (Guna.UI2, FireSharp, libcurl)
└── docs/BACKEND_GUIDE.md         # API and backend documentation
```

## Packaging

```bash
dotnet pack "Tunlocker Tool.csproj" -c Release -o packages
```

creates `packages/TunlockerToolPro.2.0.0.nupkg`. Pushing a tag like `v2.0.0` makes GitHub Actions push the nupkg to GitHub Packages and create a release (workflow in `.github/workflows/build-and-package.yml`). Release zips are attached manually (see Download above).

The nupkg and zip include the third-party DLLs from `Res/`. Check their licenses before redistributing.

## Backend and API

The tool talks to `https://api.tfastdigital.com/api/server`. Endpoints: `loginapi/`, `Balancepdate/`, `ban/`, `svcrtfile/`, `getcrtfile/`, `info2/`, `info1val2/`, `infovar2/`, `Optionapi/`. It also reads messages from Firebase Realtime Database and downloads payloads from Firebase Storage.

The request encryption, the login handshake, the data models, and a guide to running your own server are in [docs/BACKEND_GUIDE.md](docs/BACKEND_GUIDE.md).

## Links

- Website: https://tfastdigital.com/
- Telegram: https://t.me/tfasthub
- YouTube: https://www.youtube.com/@TfastDigital
- TikTok: https://www.tiktok.com/@tfasthub
- WhatsApp: +256 751 399 620

## Learning resources

- [mtkclient](https://github.com/bkerler/mtkclient): the open-source MediaTek tool this repo's MTK code is ported from
- [Android partition layout](https://source.android.com/docs/core/architecture/partitions)
- [ADB documentation](https://developer.android.com/tools/adb)
- [Fastboot protocol](https://source.android.com/docs/core/architecture/bootloader/fastbootd)
- [Ext4 on-disk format](https://www.kernel.org/doc/html/latest/filesystems/ext4/)
- [CRC32 (zlib)](https://www.zlib.net/crc_v3.txt)
- [AES FIPS-197](https://nvlpubs.nist.gov/nistpubs/FIPS/NIST.FIPS.197.pdf)
- [Windows Forms documentation](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/)

If you are new to the code, open `Form1.cs` and follow one operation (for example "read device info") through `ProcessConnection` down to the USB layer. Then compare `mtkclient2/` with the original Python mtkclient.

## Contributing

Pull requests are welcome. Keep it legal (no malware, no bypass tools for devices you don't own) and don't commit `bin/`, `obj/` or `.vs/`.

## Credits

- Tunlocker Tool Pro: Tfast Digital Agency, https://tfastdigital.com/
- [mtkclient](https://github.com/bkerler/mtkclient) by B. Kerler
- [HZHControls](https://github.com/kwwwvagaa/NetWinformControl)
- [Guna.UI2](https://gunaframework.com/)
- [FireSharp](https://github.com/ziyasal/FireSharp)
- [Newtonsoft.Json](https://www.newtonsoft.com/json)

## License

MIT. Third-party libraries keep their own licenses.