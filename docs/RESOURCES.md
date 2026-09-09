# Resources and research references

An annotated bibliography for understanding and building a tool like this. Each entry says what it is and why it matters here. For internal cross-references see [FEATURES.md](FEATURES.md), [PROTOCOLS.md](PROTOCOLS.md), [FILE_FORMATS.md](FILE_FORMATS.md), [SECURITY_CONCEPTS.md](SECURITY_CONCEPTS.md), and [GLOSSARY.md](GLOSSARY.md).

## Reference implementations (open source)

- **mtkclient** — https://github.com/bkerler/mtkclient — the Python reference this repo's `mtkclient2/` is ported from. The canonical source for MediaTek BROM, DA, and the kamakiri exploit. Read `mtk`, `Library/mtk_da_cmd.py`, and `Library/Exploit/` alongside our `MtkAuthExploit*.cs`.
- **edl** — https://github.com/bkerler/edl — Qualcomm Sahara + Firehose reference. Maps directly onto our `SAHARA.cs` and `FIREHOSE_*.cs`. The clearest description of the XML verbs and Sahara command modes.
- **Heimdall** — https://github.com/Benjamin-Dobell/Heimdall — open-source Samsung Odin/LOKE implementation. The best readable account of the download-mode handshake and PIT transfer that our `OdinClient/` mirrors.
- **Samsung-Loki / open PIT tools** — community PIT parsers; cross-check field offsets against our `OdinClient/Pit/PITData.cs` ([FILE_FORMATS.md](FILE_FORMATS.md) §2).
- **spd_dump** — https://github.com/ilyakurdyukov/spreadtrum_flash — open Spreadtrum/Unisoc ResearchDownload tool; good for the FDL1→FDL2 sequence and PAC layout behind our `SPDR.cs` / `SPD/`.
- **android-simg2img / libsparse** — https://android.googlesource.com/platform/system/core/+/master/libsparse/ — the authoritative sparse-image format, matching our `MtkSparse.cs` ([FILE_FORMATS.md](FILE_FORMATS.md) §5).

## Exploits and low-level research

- **kamakiri (MediaTek BROM)** — the USB-download exploit that bypasses BROM signature checks; documented across the mtkclient repo and XDA. Basis of `MtkAuthExploit*.cs`. See [SECURITY_CONCEPTS.md](SECURITY_CONCEPTS.md) §2.
- **amonet (Amazon/MediaTek)** — bootrom + preloader chain writeup; a good case study of chaining a bootrom bug into persistent access.
- **Qualcomm EDL / "Firehose" programmer research** — Aleph Research, "Qualcomm EDL Firehose programmers" (`https://alephsecurity.com/2018/01/22/qualcomm-edl-1/` series) — how signed loaders leak and why the OEM PK hash matters.
- **CVE reference points** — search the NVD (https://nvd.nist.gov) for the SoC/bootloader CVEs behind each bypass; useful for understanding which devices are patched.

## Android platform documentation

- Partition layout — https://source.android.com/docs/core/architecture/partitions
- Bootloader / fastbootd — https://source.android.com/docs/core/architecture/bootloader/fastbootd
- Verified boot (AVB) — https://source.android.com/docs/security/features/verifiedboot
- dm-verity — https://source.android.com/docs/security/features/verifiedboot/dm-verity
- Factory Reset Protection — https://source.android.com/docs/security/features/frp
- A/B (seamless) updates & super partition — https://source.android.com/docs/core/ota/ab
- ADB — https://developer.android.com/tools/adb

## USB and serial

- USB in a Nutshell — https://www.beyondlogic.org/usbnutshell/ — the fastest way to understand endpoints, transfers, and descriptors behind our serial layer.
- libusb — https://github.com/libusb/libusb
- WinUSB / Windows USB driver concepts — https://learn.microsoft.com/en-us/windows-hardware/drivers/usbcon/
- HDLC framing (for Unisoc) — RFC 1662, https://www.rfc-editor.org/rfc/rfc1662

## Filesystems and data formats

- GPT / UEFI spec (partition table) — https://uefi.org/specifications ([FILE_FORMATS.md](FILE_FORMATS.md) §1)
- Ext4 on-disk format — https://www.kernel.org/doc/html/latest/filesystems/ext4/ ([FILE_FORMATS.md](FILE_FORMATS.md) §7)
- Android sparse image format — https://android.googlesource.com/platform/system/core/+/master/libsparse/sparse_format.h
- CRC32 — "A Painless Guide to CRC" — https://www.zlib.net/crc_v3.txt (behind `Force/Crc32/`)
- AES — FIPS 197 — https://nvlpubs.nist.gov/nistpubs/FIPS/NIST.FIPS.197.pdf (behind `AESS.cs`)

## .NET, WinForms and libraries used here

- Windows Forms — https://learn.microsoft.com/en-us/dotnet/desktop/winforms/
- P/Invoke & marshaling (for the packed structs) — https://learn.microsoft.com/en-us/dotnet/standard/native-interop/
- Guna.UI2 — https://gunaframework.com/ (UI controls)
- HZHControls — https://github.com/kwwwvagaa/NetWinformControl (timeline/progress controls in `HZH_Controls/`)
- FireSharp — https://github.com/ziyasal/FireSharp (Firebase RTDB client, see [BACKEND_GUIDE.md](BACKEND_GUIDE.md))
- Newtonsoft.Json — https://www.newtonsoft.com/json

## Firebase (backend)

- Realtime Database — https://firebase.google.com/docs/database
- Storage — https://firebase.google.com/docs/storage
- REST API — https://firebase.google.com/docs/database/rest/start

## Books

- **Android Security Internals**, Nikolay Elenkov — the security model in [SECURITY_CONCEPTS.md](SECURITY_CONCEPTS.md), in depth.
- **Android Internals: A Confectioner's Cookbook**, Jonathan Levin — the boot chain and partitions (older but still the best on the low level).
- **Attacking Network Protocols**, James Forshaw — method for reverse-engineering the wire protocols in [PROTOCOLS.md](PROTOCOLS.md).
- **Practical Reverse Engineering**, Dang, Gazet, Bachaalany — the reversing techniques used to recover code and formats like these.
- **Practical Mobile Forensics**, Bommisetty et al. — the forensic/right-to-repair context for legitimate use.

## Talks and writeups

- DEF CON / CCC talks on bootrom exploits (search "bootrom exploit MediaTek", "Qualcomm EDL").
- Aleph Security Qualcomm EDL blog series (linked above) — the definitive Firehose writeup.
- mtkclient project notes and issues — practical, device-specific BROM/DA behavior.

## Communities

- XDA Developers forums — https://forum.xda-developers.com — device-specific test points, loaders, and firmware.
- mtkclient discussions — linked from the mtkclient repo.
- Tfast Digital YouTube — https://www.youtube.com/@TfastDigital

## Legal and ethical framing

- Right to repair overview — https://en.wikipedia.org/wiki/Right_to_repair
- Read the [README](../README.md) legal note and [SECURITY_CONCEPTS.md](SECURITY_CONCEPTS.md) §7 before using any of the above against a real device.
