# Glossary

Terms and acronyms used across this codebase and its docs. Cross-references point to [FEATURES.md](FEATURES.md), [PROTOCOLS.md](PROTOCOLS.md), and [FILE_FORMATS.md](FILE_FORMATS.md).

## Boot and firmware

- **Boot chain** — the ordered stages that run when a phone powers on: boot ROM → preloader/PBL → bootloader → kernel. Each stage verifies the next.
- **Boot ROM** — code burned into the SoC at the factory, unchangeable. The first thing that runs. On MediaTek this download entry point is called **BROM**; on Qualcomm the equivalent is the **PBL** (Primary Boot Loader).
- **Preloader** (MediaTek) — first-stage bootloader in flash, loaded by the BROM. See [PROTOCOLS.md](PROTOCOLS.md) §3.
- **SBL** — Secondary Boot Loader (Qualcomm), the stage after PBL.
- **Bootloader** — the stage that can enter **fastboot** and boot the kernel or recovery.
- **Recovery** — a minimal second system used for updates and factory reset.
- **fastboot** — protocol and mode for flashing partitions from the bootloader. See [PROTOCOLS.md](PROTOCOLS.md) §6.
- **DA (Download Agent)** — a small program the host uploads into device RAM that then performs partition read/write. MediaTek's flash worker. See [PROTOCOLS.md](PROTOCOLS.md) §3.
- **FDL1 / FDL2** — the two-stage download loaders on Unisoc; FDL1 loads FDL2, which does the flashing. See [PROTOCOLS.md](PROTOCOLS.md) §4.

## Download / service modes

- **EDL** — Emergency Download mode (Qualcomm), USB PID `9008`. Where Sahara and Firehose run. See [PROTOCOLS.md](PROTOCOLS.md) §1.
- **Sahara** — Qualcomm protocol that uploads the Firehose programmer to the device.
- **Firehose** — Qualcomm XML-over-USB protocol for partition read/write/erase/patch, run by the uploaded programmer.
- **Odin / LOKE** — Samsung's download-mode flashing protocol (Odin = PC side, LOKE = device side). See [PROTOCOLS.md](PROTOCOLS.md) §2.
- **ResearchDownload** — Unisoc/Spreadtrum flashing protocol, HDLC-framed. See [PROTOCOLS.md](PROTOCOLS.md) §4.
- **DIAGNOS** — Huawei/HiSilicon diagnostic/download mode. See [PROTOCOLS.md](PROTOCOLS.md) §5.
- **Test point** — physical pads on the board that, shorted at power-on, force the SoC into boot-ROM download mode even if flash is corrupt.

## Partitions and formats

- **GPT** — GUID Partition Table, the partition map. See [FILE_FORMATS.md](FILE_FORMATS.md) §1.
- **PIT** — Partition Information Table (Samsung), the partition map inside firmware. See [FILE_FORMATS.md](FILE_FORMATS.md) §2.
- **PAC** — Unisoc firmware container holding all partition images plus a manifest. See [FILE_FORMATS.md](FILE_FORMATS.md) §3.
- **Scatter file** — MediaTek text file mapping partitions to addresses/sizes. See [FILE_FORMATS.md](FILE_FORMATS.md) §4.
- **Sparse image** — Android format that omits empty blocks; expanded before writing. See [FILE_FORMATS.md](FILE_FORMATS.md) §5.
- **LBA** — Logical Block Address, a sector index. Byte offset = LBA × sector size (512 or 4096).
- **LUN** — Logical Unit Number, a sub-drive on UFS storage (e.g. boot LUNs vs. user data).
- **eMMC / UFS** — the two flash storage types; UFS is newer and faster and uses multiple LUNs.
- **Ext4** — the Linux filesystem inside `userdata`/`system`; this tool has a read-only parser. See [FILE_FORMATS.md](FILE_FORMATS.md) §7.
- **super partition** — a single physical partition holding logical partitions (system, vendor, product) on modern devices.

## Security

- **FRP** — Factory Reset Protection. After a factory reset, the device demands the last synced Google account. Prevents use of a stolen, wiped phone. See [SECURITY_CONCEPTS.md](SECURITY_CONCEPTS.md).
- **AVB / Verified Boot** — Android Verified Boot; each stage cryptographically verifies the next. **dm-verity** enforces it on the system partition.
- **Secure boot** — the SoC only runs firmware signed by the OEM's key.
- **seccfg** — MediaTek's on-flash block recording bootloader lock state. See [FILE_FORMATS.md](FILE_FORMATS.md) §6.
- **SLA / DAA** — MediaTek's Serial Link Authentication and Download Agent Authentication; challenge-response checks that gate the BROM.
- **SEJ** — MediaTek's hardware crypto engine (`hwcrypto_sej.cs`), used to derive keys for seccfg and encrypted data.
- **OEM PK hash** — hash of the OEM public key stored in the SoC; tells a tool which signed loader the device will accept. Read over Sahara.
- **kamakiri / amonet** — public MediaTek BROM exploits that bypass signature checks so an unsigned DA can run. Implemented in `MtkAuthExploit*.cs`.
- **HWID** — a hardware fingerprint of the technician's PC, used by the license server to bind a license to one machine. See [BACKEND_GUIDE.md](BACKEND_GUIDE.md).
- **IMEI** — International Mobile Equipment Identity, the 15-digit modem serial. Stored in a protected modem/NV partition; "IMEI repair" rewrites it (legal only for restoring a device's own original IMEI).
- **EFS / NV** — Samsung/Qualcomm partitions holding calibration, IMEI, and per-device secrets.
- **cert file** — a device certificate/blob used in IMEI and modem operations (`qcert3.cs`, `Cert.cs`).

## USB and serial

- **BROM/COM port** — the serial port Windows creates when the device enters a download mode; enumerated in `COMPortInfoB.cs`.
- **Bulk / control transfer** — USB transfer types; bulk moves the large partition data, control does setup.
- **VID / PID** — USB Vendor ID / Product ID that identify the mode (e.g. Qualcomm EDL = `05C6:9008`).
- **HDLC** — framing used by Unisoc: `0x7E` delimiters, byte-stuffing, CRC.

## This project

- **motoulocked** — the original internal namespace/folder of the decompiled source; kept as-is so the code still builds.
- **mtkclient2** — the in-tree C# port of the Python [mtkclient](https://github.com/bkerler/mtkclient).
- **credit / license** — the server-side balance and entitlement model. See [BACKEND_GUIDE.md](BACKEND_GUIDE.md) and [STARTUP_GUIDE.md](STARTUP_GUIDE.md).
