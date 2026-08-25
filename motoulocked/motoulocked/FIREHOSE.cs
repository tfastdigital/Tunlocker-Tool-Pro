using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.motoulocked;

[StandardModule]
internal sealed class FIREHOSE
{
	public struct CHUNK_HEADER
	{
		public short wChunkType;

		public short wReserved;

		public int dwChunkSize;

		public int dwTotalSize;
	}

	public struct SPARSE_HEADER
	{
		public int dwMagic;

		public short wVerMajor;

		public short wVerMinor;

		public short wSparseHeaderSize;

		public short wChunkHeaderSize;

		public int dwBlockSize;

		public int dwTotalBlocks;

		public int dwTotalChunks;

		public int dwImageChecksum;
	}

	public struct FIREHOSE_CONFIG
	{
		public int Version;

		public string MemoryName;

		public int SkipWrite;

		public int SkipStorageInit;

		public int ZLPAwareHost;

		public int ActivePartition;

		public string MaxPayloadSizeToTargetInBytes;

		public int AckRawDataEveryNumPackets;

		public string maxPayloadSizeFromTargetInBytes;
	}

	public struct FIREHOSE_GPT
	{
		public gpt_header header;

		public List<gpt_partition_entry> entries;
	}

	public struct gpt_partition_entry
	{
		public string partTypeGUID;

		public string partID;

		public ulong first_lba;

		public ulong last_lba;

		public byte[] flags;

		public string partName;

		public ulong sector_size_512 => Convert.ToUInt64(decimal.Add(decimal.Subtract(new decimal(checked((int)last_lba)), new decimal(first_lba)), 1m));

		public ulong sector_size_4096 => Convert.ToUInt64(decimal.Add(decimal.Subtract(new decimal(checked((int)last_lba)), new decimal(first_lba)), 1m));
	}

	public struct gpt_header
	{
		public string signature;

		public int revision;

		public int header_size;

		public int crc_header;

		public int reserved;

		public int current_lba;

		public int backup_lba;

		public int first_usable_lba;

		public long last_usable_lba;

		public byte[] disk_guid;

		public int starting_lba_pe;

		public int number_partitions;

		public int size_partition_entries;

		public int crc_partition;

		public byte reserved2;
	}

	public static CHUNK_HEADER chunkheader;

	public static SPARSE_HEADER sparseheader;

	public const long SPARSE_MAGIC = 64108298042L;

	public const long SPARSE_RAW_CHUNK = 969409L;

	public const long SPARSE_FILL_CHUNK = 969410L;

	public const long SPARSE_DONT_CARE = 969411L;

	public static FIREHOSE_GPT gpt;

	public static string xml = null;

	public static int totalchunk { get; set; }

	public static SPARSE_HEADER parsingheader(byte[] bytes)
	{
		GCHandle gCHandle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
		SPARSE_HEADER sPARSE_HEADER = default(SPARSE_HEADER);
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), typeof(SPARSE_HEADER)));
			return (objectValue != null) ? ((SPARSE_HEADER)objectValue) : default(SPARSE_HEADER);
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static string pkt_fhConfig(FIREHOSE_CONFIG config)
	{
		return $"<?xml version=\"1.0\" encoding=\"UTF-8\" ?><data><configure MemoryName=\"{config.MemoryName}\" ZLPAwareHost=\"{config.ZLPAwareHost}\" SkipStorageInit=\"{config.SkipStorageInit}\" SkipWrite=\"{config.SkipWrite.ToString()}\" MaxPayloadSizeToTargetInBytes=\"{config.MaxPayloadSizeToTargetInBytes}\" /></data>";
	}

	public static string pkt_setAckRaw(int val)
	{
		return $"<?xml version=\"1.0\" encoding=\"UTF-8\" ?><data><configure AckRawData=\"{val}\" /></data>";
	}

	public static string pkt_peekMem(uint address64, int size)
	{
		return $" <?xml version=\"1.0\" encoding=\"UTF-8\" ?><data><peek address64=\"{address64}\" SizeInBytes=\"{size}\" /></data>";
	}

	public static string pkt_eMMCinfo(string drive)
	{
		return $"<?xml version=\"1.0\" encoding=\"UTF-8\" ?><data><getstorageinfo physical_partition_number=\"{drive}\" /></data>";
	}

	public static string pkt_ProgramUFS(int nPartSectors, string fileName, int startSector, int lun)
	{
		return $" <?xml version=\"1.0\" encoding=\"UTF-8\" ?><data><program SECTOR_SIZE_IN_BYTES=\"4096\" filename=\"{fileName}\" num_partition_sectors=\"{nPartSectors}\" physical_partition_number=\"0\" start_sector=\"{lun.ToString()}\" /></data>";
	}

	public static string BootConf()
	{
		return "<?xml version=\"1.0\" encoding=\"UTF-8\" ?><data><setbootablestoragedrive value=\"0\" /></data>";
	}

	public static string pkt_readSecBoot()
	{
		return "<?xml version=\"1.0\" encoding=\"UTF-8\" ?><data><getSecureBootStatus/></data>";
	}

	public static string pkt_readSerialNumber()
	{
		return "<?xml version=\"1.0\" encoding=\"UTF-8\" ?><data><getserialnum /></data>";
	}

	public static string pkt_readIMEI()
	{
		return "<?xml version=\"1.0\" encoding=\"UTF-8\" ?><data><readIMEI len=\"32\" /></data>";
	}

	public static string pkt_SendReq()
	{
		return "<?xml version=\"1.0\" encoding=\"UTF-8\" ?><data> <sig TargetName=\"req\" verbose=\"1\" /></data>";
	}

	public static string pkt_SendSign()
	{
		return "<?xml version=\"1.0\" encoding=\"UTF-8\" ?><data><sig TargetName=\"sig\" size_in_bytes=\"256\" verbose=\"1\" /></data>";
	}

	public static string pkt_sendNop()
	{
		return "<?xml version=\"1.0\" encoding=\"UTF-8\" ?><data><nop verbose=\"0\" value=\"ping\" /></data>";
	}

	public static string pkt_sendReset()
	{
		return "<?xml version=\"1.0\" encoding=\"UTF-8\" ?><data><power value=\"reset\" /></data>";
	}

	public static string pkt_read(string sectorSize, string numPartitionSectors, string physicalPartNum, string startSector)
	{
		return $"<?xml version=\"1.0\" encoding=\"UTF-8\" ?><data><read SECTOR_SIZE_IN_BYTES=\"{sectorSize}\" num_partition_sectors=\"{numPartitionSectors}\" physical_partition_number=\"{physicalPartNum}\" start_sector=\"{startSector}\" read_back_verify =\"0\" /></data>";
	}

	public static string pkt_Program(string sectorsize, string NumPartitionSector, string PhysicalPartition, string StartSector)
	{
		return $"<?xml version=\"1.0\" encoding=\"UTF-8\" ?><data><program SECTOR_SIZE_IN_BYTES=\"{sectorsize}\" file_sector_offset=\"0\" num_partition_sectors=\"{NumPartitionSector}\" physical_partition_number=\"{PhysicalPartition}\" start_sector=\"{StartSector}\" read_back_verify =\"0\" /></data>";
	}

	public static string pkt_patch(string SECTOR_SIZE_IN_BYTES, string BytesOffset, string FileName, string PhysicalPartition, string SizeInBytes, string StartSector, string Value, string What)
	{
		return $"<?xml version=\"1.0\" encoding=\"UTF-8\" ?><data><patch SECTOR_SIZE_IN_BYTES=\"{SECTOR_SIZE_IN_BYTES}\" byte_offset=\"{BytesOffset}\" filename=\"{FileName}\" physical_partition_number=\"{PhysicalPartition}\" size_in_bytes=\"{SizeInBytes}\" start_sector=\"{StartSector}\" value=\"{Value}\" what=\"{What}\" read_back_verify =\"0\" /></data>";
	}

	public static string pkt_patch_string(string SECTOR_SIZE_IN_BYTES, string BytesOffset, string FileName, string PhysicalPartition, string SizeInBytes, string StartSector, string Value, string What)
	{
		return $"<patch SECTOR_SIZE_IN_BYTES=\"{SECTOR_SIZE_IN_BYTES}\" byte_offset=\"{BytesOffset}\" filename=\"{FileName}\" physical_partition_number=\"{PhysicalPartition}\" size_in_bytes=\"{SizeInBytes}\" start_sector=\"{StartSector}\" value=\"{Value}\" what=\"{What}\" read_back_verify =\"0\" />";
	}

	public static string pkt_erase(string sectorSize, string numPartitionSectors, string physicalPartNum, string startSector)
	{
		return $"<?xml version=\"1.0\" encoding=\"UTF-8\" ?><data><erase SECTOR_SIZE_IN_BYTES=\"{sectorSize}\" num_partition_sectors=\"{numPartitionSectors}\" physical_partition_number=\"{physicalPartNum}\" start_sector=\"{startSector}\" read_back_verify =\"0\" /></data>";
	}
}
