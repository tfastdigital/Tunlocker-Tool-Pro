using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.mtkclient2.library.xflash;

internal class MtkGptParserService
{
	private static int Read4Byte(MemoryStream ms)
	{
		byte[] array = new byte[4];
		ms.Read(array, 0, 4);
		return BitConverter.ToInt32(array, 0);
	}

	private static long Read8Byte(MemoryStream ms)
	{
		byte[] array = new byte[8];
		ms.Read(array, 0, 8);
		return BitConverter.ToInt64(array, 0);
	}

	public static MtkGpt Parse(byte[] headerData, int sectorSize)
	{
		using MemoryStream memoryStream = new MemoryStream(headerData);
		memoryStream.Seek(sectorSize, SeekOrigin.Begin);
		byte[] array = new byte[8];
		memoryStream.Read(array, 0, array.Length);
		string @string = Encoding.ASCII.GetString(array);
		if (Operators.CompareString(@string, "EFI PART", TextCompare: false) == 0)
		{
			int num = Read4Byte(memoryStream);
			if (num != 65536)
			{
				Console.WriteLine($"Invalid gpt revision: 0x{num:X8}");
			}
			int headerSize = Read4Byte(memoryStream);
			int crc = Read4Byte(memoryStream);
			int reserved = Read4Byte(memoryStream);
			long currentLba = Read8Byte(memoryStream);
			long backupLba = Read8Byte(memoryStream);
			long firstUsableLba = Read8Byte(memoryStream);
			long lastUsableLba = Read8Byte(memoryStream);
			byte[] array2 = new byte[16];
			memoryStream.Read(array2, 0, array2.Length);
			Guid guid = new Guid(array2);
			long partitionEntryStartLba = Read8Byte(memoryStream);
			int partitionEntriesCount = Read4Byte(memoryStream);
			int partitionEntrySize = Read4Byte(memoryStream);
			return new MtkGpt
			{
				Signature = @string,
				Revision = num,
				HeaderSize = headerSize,
				Crc32 = crc,
				Reserved = reserved,
				CurrentLba = currentLba,
				BackupLba = backupLba,
				FirstUsableLba = firstUsableLba,
				LastUsableLba = lastUsableLba,
				Guid = guid,
				PartitionEntryStartLba = partitionEntryStartLba,
				PartitionEntriesCount = partitionEntriesCount,
				PartitionEntrySize = partitionEntrySize,
				SectorSize = sectorSize
			};
		}
		Console.WriteLine("Invalid gpt signature: " + @string);
		return new MtkGpt();
	}

	public static MtkGpt ParsePartitions(MtkGpt gpt, byte[] partitionsData)
	{
		List<MtkGptPartition> list = new List<MtkGptPartition>();
		checked
		{
			using MemoryStream memoryStream = new MemoryStream(partitionsData);
			memoryStream.Seek(gpt.PartitionEntryStartLba * gpt.SectorSize, SeekOrigin.Begin);
			int num = gpt.PartitionEntriesCount - 1;
			for (int i = 0; i <= num; i++)
			{
				long position = memoryStream.Position;
				int type = Read4Byte(memoryStream);
				memoryStream.Read(new byte[12], 0, 12);
				byte[] array = new byte[16];
				memoryStream.Read(array, 0, array.Length);
				Guid id = new Guid(array);
				long firstLba = Read8Byte(memoryStream);
				long lastLba = Read8Byte(memoryStream);
				long flags = Read8Byte(memoryStream);
				byte[] array2 = new byte[72];
				memoryStream.Read(array2, 0, array2.Length);
				string text = Encoding.Unicode.GetString(array2).TrimEnd(default(char));
				if (Operators.CompareString(text, "", TextCompare: false) != 0)
				{
					list.Add(new MtkGptPartition
					{
						Type = type,
						Id = id,
						FirstLba = firstLba,
						LastLba = lastLba,
						Flags = flags,
						Name = text
					});
				}
				long num2 = memoryStream.Position - position;
				if (num2 < gpt.PartitionEntrySize)
				{
					memoryStream.Seek(gpt.PartitionEntrySize - num2, SeekOrigin.Current);
				}
			}
			MtkGpt mtkGpt = gpt._get();
			mtkGpt.Partitions = list.ToArray();
			return mtkGpt;
		}
	}
}
