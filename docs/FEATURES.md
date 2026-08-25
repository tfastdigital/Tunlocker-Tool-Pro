# Features

How each part of Tunlocker Tool Pro works, with the files that implement it and links for further reading. This is the technical companion to the README.

## 1. Chipset support (the protocol engine)

The tool talks to six chipset families over USB. Each has its own folder and handshake code. They all follow the same pattern: detect the device, enter its special mode, run commands, read or write partitions.

### MediaTek

What it does: unlock, flash, read and write partitions on MTK phones via the BROM (boot ROM) and preloader.

How it works: the device boots into BROM with the boot key or a test point. The tool uploads a small preloader payload, then uses the DA (download agent) protocol for partition access.

Code: mtkclient2/ is a C# port of the Python mtkclient. Key classes: MtkTask (InitAsync, Unlock_Code_1, Unlock_Code_2), the MTK/ folder for protocol, Tasks/ for high level operations, devicehandler/ for device state. The legacy path is Protocol_MTK_By_Devronix.cs.

Resources: https://github.com/bkerler/mtkclient

### Qualcomm

What it does: EDL (Emergency Download) mode operations over the Sahara and Firehose protocols.

How it works: the device enters EDL mode, Sahara hands off the firehose loader, and the firehose loader executes read/write/erase commands.

Code: EDL.cs. Also a connectivity check against google.com before operations.

Resources: https://github.com/bkerler/edl, community writeups on Sahara and Firehose

### Samsung

What it does: flashing and unlock flows for Exynos and Qualcomm Samsung devices.

How it works: the device boots into Odin download mode and the tool speaks the Odin protocol. Some operations download root packages from Firebase Storage (Form1.cs holds the signed URLs, for example RN920P, RG925T, RJ700T packages).

Code: OdinClient/. Samsung MSL lookup goes through an external API (alseery-unlocker.com/Api/SamsungMSL in Form1.cs).

Resources: Heimdall (https://github.com/Benjamin-Dobell/Heimdall), XDA threads on the Odin protocol

### Spreadtrum / Unisoc

What it does: flashing via the SPD/ResearchDownload protocol, including PAC files.

How it works: the device enters download mode over the SPD serial protocol. Payload and firehose files are fetched from Firebase Storage (SPDR.cs builds the payload URL from FIREHOSE_MANAGER).

Code: SPD/, SPDR.cs.

Resources: SP Flash Tool and ResearchDownload community documentation

### Huawei / Honor

What it does: Kirin chipset operations through the DIAGNOS diagnostic interface.

How it works: the tool opens the Huawei diagnostic port and sends vendor commands for unlock and repair flows. kirin.cs is the UI for these operations.

Code: kirin.cs, HuaweiUnlocker/DIAGNOS/, HuaweiUnlocker/TOOLS/.

Resources: community writeups on Huawei diagnostic mode

### Motorola

What it does: unlock and repair flows over fastboot and ADB, plus modem flashing.

How it works: standard fastboot/ADB commands wrapped in the tool, with Motorola modem packages downloaded from Firebase Storage (Form1.cs holds the signed URLs for EJ920, EJ320 and similar modem files).

Code: Android_Qualcomm.cs, AndroidCommands.cs.

Resources: Motorola bootloader unlock documentation

## 2. ADB and fastboot automation

What it does: starts adb.exe and fastboot.exe, sends commands, parses output.

How it works: the app drops adb.exe, AdbWinApi.dll, AdbWinUsbApi.dll and fastboot.exe from its embedded resources on startup, kills leftover adb processes, then drives them as child processes. Device info (model, platform, IMEI) is parsed from the output.

Code: ProcessConnection.cs, the payload drop logic in Form1.cs.

Resources: https://developer.android.com/tools/adb, https://source.android.com/docs/core/architecture/bootloader/fastbootd

## 3. Firmware flashing

What it does: writes firmware images to device partitions, with scatter file support.

How it works: scatter files describe the partition layout. The tool parses them, lets the user pick partitions (Select_Prtitoin.cs), then reads/writes/erases each partition over the chipset protocol. Every transfer is verified with CRC32.

Code: flash.cs, Select_Prtitoin.cs, Force/Crc32/.

Resources: AOSP partition docs, chipset scatter format documentation

## 4. FRP removal

What it does: clears Factory Reset Protection state so a reset phone can be set up again.

How it works: FRP state lives in specific partitions. The tool reads the partition, resets the FRP area, and writes it back through the chipset protocol. Device enumeration uses WMI and serial ports to find the right port first.

Code: FRP.cs (uses System.Management for device listing and System.IO.Ports for serial access).

Resources: https://source.android.com/docs/security/features/frp

## 5. IMEI repair and certificates

What it does: rebuilds IMEI numbers and the certificate files some chipsets need.

How it works: qcert3.cs generates certificates for the device. Cert.cs saves and fetches cert files from the server (svcrtfile/ and getcrtfile/ endpoints), so a repair shop can back up certs before an operation and restore them after.

Code: qcert3.cs, Cert.cs, core/CertFileSaveGet.cs, core/CertFileSaveSet.cs.

Resources: docs/BACKEND_GUIDE.md for the cert endpoints

## 6. Ext4 filesystem reader

What it does: reads ext4 partition images and extracts files, without mounting anything.

How it works: a from-scratch parser walks the superblock, block groups, inode table and directory entries. It is read-only, so it is safe to point at a dumped partition image.

Code: Operations/Ext4/.

Resources: https://www.kernel.org/doc/html/latest/filesystems/ext4/

## 7. Crypto toolkit

What it does: all hashing and encryption used by the tool.

- AESS.cs: AES encrypt/decrypt for local data.
- encryptor.cs: general encryption helpers.
- SymbolEnc.cs and tmpcrpt.cs: string encryption and the client/server envelope keys.
- Force/Crc32/: CRC32 checksums for transfers.

Code: AESS.cs, encryptor.cs, SymbolEnc.cs, tmpcrpt.cs, Force/Crc32/.

Resources: https://nvlpubs.nist.gov/nistpubs/FIPS/NIST.FIPS.197.pdf, https://www.zlib.net/crc_v3.txt

## 8. Licensing and credits client

What it does: the client half of the credit system.

How it works: Login.cs sends encrypted credentials to loginapi/. The response carries the license state (credits, type, dates, restrictions), stored in SevaClass. Each operation checks the state before running. Balancepdate.cs reports credit usage. banuser.cs reacts to remote bans.

Code: Login.cs, SevaClass.cs, Balancepdate.cs, banuser.cs, core/ (apilogin.cs, apiloginreturn.cs, tokdata.cs, ggfnew.cs).

Resources: docs/BACKEND_GUIDE.md, docs/STARTUP_GUIDE.md

## 9. Messages and updates

What it does: shows announcements and update prompts.

How it works: Get_Messgas.cs reads messages from Firebase Realtime Database (URL in ClassDevronix.cs, legacy URL in motoulocked/encr.cs). The server can also push a "New update is available" response through the API, handled in Login.cs via toolparam.uptool.

Code: Get_Messgas.cs, ClassDevronix.cs, log_Updeta.cs, No_Internet.cs.

Resources: https://firebase.google.com/docs/database/rest/start

## 10. UI layer

What it does: the WinForms interface on top of the engine.

How it works: Form1.cs is the main window (very large, most UI logic lives there). Wizard dialogs (Dialog1 through Dialog5) walk through operations. Controls/ has TabControlExt, a custom tab control. HZH_Controls is an adapted open source control library, and Guna.UI2 provides the themed look.

Code: Form1.cs, Dialog1..5.cs, Controls/TabControlExt.cs, HZH_Controls/, Res/Guna.UI2.dll.

Resources: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/, https://github.com/kwwwvagaa/NetWinformControl, https://gunaframework.com/

## 11. Utilities

- COMPortInfoB.cs: lists COM ports and matches them to devices.
- LoadXML.cs and toolparam.cs: settings and operation parameters from XML.
- Services_Network.cs: HTTP and network helpers, Firebase access via FireSharp.
- ModuleLogger.cs and Send_Log.cs: local logging and server submission (Optionapi/).
- getinfo.cs: reports device info to the server (info2/, info1val2/, infovar2/).
- EDL.cs and Get_Messgas.cs: connectivity checks against google.com.

## File map

| Area | Files |
| --- | --- |
| MediaTek | mtkclient2/, Protocol_MTK_By_Devronix.cs |
| Qualcomm | EDL.cs |
| Samsung | OdinClient/ |
| Spreadtrum | SPD/, SPDR.cs |
| Huawei | kirin.cs, HuaweiUnlocker/ |
| Motorola | Android_Qualcomm.cs, AndroidCommands.cs |
| ADB/fastboot | ProcessConnection.cs |
| Flashing | flash.cs, Select_Prtitoin.cs |
| FRP | FRP.cs |
| IMEI/cert | qcert3.cs, Cert.cs |
| Filesystem | Operations/Ext4/ |
| Crypto | AESS.cs, encryptor.cs, SymbolEnc.cs, tmpcrpt.cs, Force/Crc32/ |
| Licensing | Login.cs, SevaClass.cs, Balancepdate.cs, banuser.cs, core/ |
| Messages | Get_Messgas.cs, ClassDevronix.cs, log_Updeta.cs |
| UI | Form1.cs, Dialog1..5.cs, Controls/, HZH_Controls/ |
| Utilities | COMPortInfoB.cs, LoadXML.cs, Services_Network.cs, ModuleLogger.cs, Send_Log.cs, getinfo.cs |

## Further reading

- docs/WORKFLOW.md: the run flow end to end
- docs/BACKEND_GUIDE.md: the server side
- docs/RESOURCES.md: full reference list
