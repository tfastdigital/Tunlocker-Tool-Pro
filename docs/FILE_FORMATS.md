# File formats and data structures

The binary layouts Tunlocker Tool Pro reads and writes. Each section gives the on-disk structure, a field table, and the file in this repo that parses it. Offsets are in bytes from the start of the structure; sizes are bytes. Everything here is little-endian unless noted.

This is the "data structures" companion to [FEATURES.md](FEATURES.md) (what each part does) and [PROTOCOLS.md](PROTOCOLS.md) (the wire protocols that move these structures around). Acronyms are in [GLOSSARY.md](GLOSSARY.md).

---

## 1. GPT — GUID Partition Table

The modern partition map on all these phones. It replaces the old MBR. Lives at LBA 1 (right after the protective MBR at LBA 0), with a backup copy at the end of the disk.

Parsed in this repo by `motoulocked/FIREHOSE_GPT.cs` (Qualcomm path) and `mtkclient2/library/xflash/MtkGpt.cs` + `MtkGptParserService.cs` (MediaTek path). The in-memory entry is `MtkGptPartition.cs`.

### GPT header (starts at LBA 1, 92 bytes used)

| Offset | Size | Field | Notes |
| --- | --- | --- | --- |
| 0 | 8 | Signature | ASCII `EFI PART` (`45 46 49 20 50 41 52 54`) |
| 8 | 4 | Revision | usually `00 00 01 00` |
| 12 | 4 | Header size | usually 92 |
| 16 | 4 | Header CRC32 | computed with this field zeroed |
| 20 | 4 | Reserved | zero |
| 24 | 8 | Current LBA | location of this header |
| 32 | 8 | Backup LBA | location of the backup header |
| 40 | 8 | First usable LBA | first LBA available to partitions |
| 48 | 8 | Last usable LBA | last usable LBA |
| 56 | 16 | Disk GUID | unique per device |
| 72 | 8 | Partition entries LBA | usually LBA 2 |
| 80 | 4 | Number of entries | often 128 |
| 84 | 4 | Size of each entry | usually 128 |
| 88 | 4 | Entries array CRC32 | over the whole entry array |

### GPT partition entry (128 bytes each)

| Offset | Size | Field | In `MtkGptPartition` |
| --- | --- | --- | --- |
| 0 | 16 | Partition type GUID | `Type` |
| 16 | 16 | Unique partition GUID | `Id` |
| 32 | 8 | First LBA | `FirstLba` |
| 40 | 8 | Last LBA (inclusive) | `LastLba` |
| 48 | 8 | Attribute flags | `Flags` |
| 56 | 72 | Partition name | `Name`, UTF-16LE, null-padded |

`SectorCount = LastLba - FirstLba + 1`. Multiply by the sector size (512 or 4096) to get the byte size and offset for a read/write. This is the core calculation behind every "read partition" / "write partition" operation.

---

## 2. Samsung PIT — Partition Information Table

Samsung's equivalent of a partition map, shipped inside firmware and downloadable from the device over Odin. It tells the flasher which file goes to which partition and how big each one is.

Parsed by `motoulocked/OdinClient/Pit/PITData.cs`. Entry model: `TPIT_Entry.cs`. Constants: `PITData.TFileIdentifier` (file magic and `kHeaderDataSize = 28`), `TPitEntry.kDataSize` (entry size, 132 bytes).

### PIT header (28 bytes)

| Offset | Size | Field | Notes |
| --- | --- | --- | --- |
| 0 | 4 | Magic | `kFileIdentifier`; standard Samsung PIT magic is `0x12349876` |
| 4 | 4 | Entry count | number of `TPIT_Entry` records that follow |
| 8 | 18 | Project / metadata | project name and unknown fields (`unknown1`..`unknown8` in code) |
| 26 | 2 | Reserved | |

Entries begin at offset 28 (`kHeaderDataSize`). Entry N starts at `28 + N * 132`.

### PIT entry (132 bytes)

| Offset | Size | Field | In `TPIT_Entry` |
| --- | --- | --- | --- |
| 0 | 4 | Binary type | `MbinaryType` (0 = AP, 1 = CP/modem) |
| 4 | 4 | Device type | `MdeviceType` (MMC/eMMC, etc.) |
| 8 | 4 | Identifier | `Midentifier` (partition ID / flash order) |
| 12 | 4 | Attributes | `Mattributes` (read-only / read-write, etc.) |
| 16 | 4 | Update attributes | `MupdateAttributes` |
| 20 | 4 | Block size or offset | `MblockSizeOrOffset` |
| 24 | 4 | Block count | `MblockCount` |
| 28 | 4 | File offset | `MfileOffset` |
| 32 | 4 | File size | `MfileSize` |
| 36 | 32 | Partition name | `MpartitionName`, null-terminated ASCII |
| 68 | 32 | Flash filename | `MflashFilename` |
| 100 | 32 | FOTA filename | `MfotaFilename` |

`PITData.UNPACK_PIT()` walks the buffer with these exact offsets and then re-sorts entries by `Identifier` into `PIT_EntryOrdered`, which is the flash order.

---

## 3. Spreadtrum / Unisoc PAC firmware container

The `.pac` file is a single archive holding every partition image plus a manifest. `PACExtractor.cs` reads the header, then a table of file-header records, then seeks to each record's data offset to pull the image out.

Structs: `motoulocked/SPD/PacHeaderStruct.cs` and `SPD/FileHeaderStruct.cs`. Extractor: `SPD/PACExtractor.cs`.

### PAC header (`PacHeaderStruct`, packed, ~2580 bytes)

| Offset | Size | Field | Notes |
| --- | --- | --- | --- |
| 0 | 44 | szVersion | UTF-16 version string |
| 44 | 4 | dwHiSize | high dword of total file size |
| 48 | 4 | dwLoSize | low dword of total file size |
| 52 | 512 | productName | UTF-16 |
| 564 | 512 | firmwareName | UTF-16 |
| 1076 | 4 | partitionCount | number of `FileHeaderStruct` records |
| 1080 | 4 | partitionsListStart | offset to the first file-header record |
| 1084 | 4 | dwMode | |
| 1088 | 4 | dwFlashType | |
| 1092 | 4 | dwNandStrategy | |
| 1096 | 4 | dwIsNvBackup | |
| 1100 | 4 | dwNandPageType | |
| 1104 | 996 | szPrdAlias | product alias |
| 2100 | 4 | dwOmaDmProductFlag | |
| 2104 | 4 | dwIsOmaDM | |
| 2108 | 4 | dwIsPreload | |
| 2112 | 4 | dwReserved | |
| 2116 | 4 | dwMagic | container magic |
| 2120 | 2 | wCRC1 | header checksum |
| 2122 | 2 | wCRC2 | data checksum |
| 2124 | 60 | reservedData | |

### PAC file-header record (`FileHeaderStruct`, one per partition)

| Offset | Size | Field | Notes |
| --- | --- | --- | --- |
| 0 | 4 | length | length of this record |
| 4 | 512 | partitionName | UTF-16 |
| 516 | 512 | fileName | UTF-16 |
| 1028 | 512 | szFileName | full path, UTF-16 |
| 1540 | 4 | hiPartitionSize | high dword of partition size |
| 1544 | 4 | entahSize1 | |
| 1548 | 4 | entahSize2 | |
| 1552 | 4 | hiDataOffset | high dword of data offset |
| 1556 | 4 | loPartitionSize | low dword of partition size |
| 1560 | 2 | nFileFlag | |
| 1562 | 2 | nCheckFlag | |
| 1564 | 4 | loDataOffset | low dword of data offset in the PAC |
| 1568 | 4 | dwCanOmitFlag | can this image be skipped |
| 1572 | 4 | dwAddrNum | |
| 1576 | 4 | dwAddr | load address |
| 1580 | 4 | dwReserved | |
| 1584 | 996 | reservedData | |

The image bytes for a record live at `(hiDataOffset << 32) | loDataOffset`, length `(hiPartitionSize << 32) | loPartitionSize`.

---

## 4. MediaTek scatter file

A YAML-like text file that maps each partition name to its start address and size on the eMMC/UFS. Unlike GPT/PIT/PAC it is human-readable. SP Flash Tool and this tool both use it to know where to write each image.

Parsed by `mtkclient2/MTK/Client/Scatter/MtkScatter.cs` (with `Mediatek.cs`).

Typical record:

```yaml
- partition_index: SYS0
  partition_name: preloader
  file_name: preloader_k71v1_64_bsp.bin
  is_download: true
  type: SV5_BL_BIN
  linear_start_addr: 0x0
  physical_start_addr: 0x0
  partition_size: 0x40000
  region: EMMC_BOOT1
  storage: HW_STORAGE_EMMC
  boundary_check: true
  is_reserved: false
  operation_type: BOOTLOADERS
  reserve: 0x00
```

The two fields the flasher actually needs per partition are `linear_start_addr` (offset) and `partition_size` (length); the rest is metadata and validation.

---

## 5. Android sparse image

Firmware images (system, super, userdata) ship in Android's *sparse* format so that long runs of identical or zeroed blocks are not stored on disk. The flasher expands them back to raw before writing. Parsed by `mtkclient2/library/MtkSparse.cs` (structs `MTK_SPARSE_HEADER` and `MTK_CHUNK_HEADER`).

### Sparse header (28 bytes, `MTK_SPARSE_HEADER`)

| Offset | Size | Field | Notes |
| --- | --- | --- | --- |
| 0 | 4 | Magic | `0xED26FF3A` |
| 4 | 2 | Major version | 1 |
| 6 | 2 | Minor version | 0 |
| 8 | 2 | File header size | 28 |
| 10 | 2 | Chunk header size | 12 |
| 12 | 4 | Block size | multiple of 4, usually 4096 |
| 16 | 4 | Total blocks | in the output image |
| 20 | 4 | Total chunks | number of chunk records that follow |
| 24 | 4 | Image checksum | CRC32, often 0 (unused) |

### Chunk header (12 bytes, `MTK_CHUNK_HEADER`) + payload

| Offset | Size | Field | Notes |
| --- | --- | --- | --- |
| 0 | 2 | Chunk type | see below |
| 2 | 2 | Reserved | |
| 4 | 4 | Chunk size | size in output **blocks** |
| 8 | 4 | Total size | bytes of this chunk on disk (header + payload) |

Chunk types:

| Value | Meaning | Payload |
| --- | --- | --- |
| `0xCAC1` | Raw | `chunk_size * block_size` bytes copied verbatim |
| `0xCAC2` | Fill | 4-byte pattern repeated to fill `chunk_size` blocks |
| `0xCAC3` | Don't care | nothing on disk; skip/zero that many blocks in output |
| `0xCAC4` | CRC32 | a 4-byte running checksum, no output blocks |

Expansion loop: read header, then for each chunk emit `chunk_size * block_size` bytes into the output according to the type. This is how a 2 GB `system.img` can ship as a few hundred MB.

---

## 6. MTK seccfg (security configuration block)

The small structure that records whether the bootloader is locked. Rewriting it is how "bootloader unlock" and "relock" work on MediaTek. Built by `mtkclient2/MTK/Client/seccfg.cs` (`CreateSeccfg`).

The V4 layout this tool writes (each byte shown):

```
4D 4D 4D 4D   magic "MMMM"
04 00 00 00   version = 4
3C 00 00 00   struct size = 0x3C (60)
LL 00 00 00   lock_state:  01 = locked, 03 = unlocked
CC 00 00 00   critical_lock_state: 00 or 01
00 00 00 00   (reserved / hash area follows in real blocks)
45 45 45 45   end magic "EEEE"
```

`CreateSeccfg("unlock", …)` sets `lock_state = 03`; anything else sets `01`. On a real device the block also carries a hash bound to the device; a valid unlock has to satisfy the preloader's check, which is why unlocking usually goes through the BROM/DA path rather than just overwriting bytes.

---

## 7. Ext4 (read-only, for pulling files off a device)

To extract a file from a partition image (for example a stored account database during FRP work) the tool includes a read-only ext4 parser: `motoulocked/Operations/Ext4/Ext4Service.cs`, interface `IExt4Service.cs`, native helpers `Native.cs`.

The structures it walks (full spec in [RESOURCES.md](RESOURCES.md)):

| Structure | Where | Purpose |
| --- | --- | --- |
| Superblock | offset 1024, 1024 bytes | block size, inode size, blocks-per-group, feature flags |
| Block group descriptors | after superblock | locate the inode table for each group |
| Inode | inode table | file mode, size, and the extent tree / block pointers |
| Extent tree | inside the inode | maps logical file blocks to physical blocks |
| Directory entries | in directory data blocks | name → inode number |

Read path: superblock → group descriptor → inode → extents → data blocks. Read-only means it never modifies the filesystem, only pulls bytes out.

---

## 8. Where these meet the protocols

| Format | Moved by | Protocol doc section |
| --- | --- | --- |
| GPT | Firehose `read`/`program`, MTK DA | [PROTOCOLS.md](PROTOCOLS.md) §1, §3 |
| PIT | Odin PIT transfer | [PROTOCOLS.md](PROTOCOLS.md) §2 |
| PAC | Unisoc ResearchDownload | [PROTOCOLS.md](PROTOCOLS.md) §4 |
| Scatter + sparse | MTK DA (Download Agent) | [PROTOCOLS.md](PROTOCOLS.md) §3 |
| seccfg | MTK DA custom write | [PROTOCOLS.md](PROTOCOLS.md) §3 |

Understanding the structure tells you *what* is on the wire; the protocol doc tells you *how* it gets there.
