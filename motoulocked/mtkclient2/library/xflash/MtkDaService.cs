using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace motoulocked.mtkclient2.library.xflash;

internal class MtkDaService
{
	private static async Task<ushort> ReadUInt16Async(Stream stream)
	{
		byte[] array = new byte[2];
		await stream.ReadAsync(array, 0, array.Length);
		return BitConverter.ToUInt16(array, 0);
	}

	private static async Task<int> ReadInt32Async(Stream stream)
	{
		byte[] array = new byte[4];
		await stream.ReadAsync(array, 0, array.Length);
		return BitConverter.ToInt32(array, 0);
	}

	private static async Task<uint> ReadUInt32Async(Stream stream)
	{
		byte[] array = new byte[4];
		await stream.ReadAsync(array, 0, array.Length);
		return BitConverter.ToUInt32(array, 0);
	}

	private static async Task<MtkDaRegion> ParseRegionAsync(Stream stream)
	{
		int buffer = await ReadInt32Async(stream);
		int length = await ReadInt32Async(stream);
		uint startAddress = await ReadUInt32Async(stream);
		uint startOffset = await ReadUInt32Async(stream);
		TaskAwaiter<int> taskAwaiter = ReadInt32Async(stream).GetAwaiter();
		if (!taskAwaiter.IsCompleted)
		{
			//await taskAwaiter;
			TaskAwaiter<int> taskAwaiter2 = default(TaskAwaiter<int>);
			taskAwaiter = taskAwaiter2;
		}
		return new MtkDaRegion(buffer, length, startAddress, startOffset, taskAwaiter.GetResult());
	}

	private static async Task<MtkDaEntry> ParseDaAsync(Stream stream)
	{
		ushort magic = await ReadUInt16Async(stream);
		ushort hardwareCode = await ReadUInt16Async(stream);
		ushort hardwareSubCode = await ReadUInt16Async(stream);
		ushort hardwareVersion = await ReadUInt16Async(stream);
		ushort softwareVersion = await ReadUInt16Async(stream);
		ushort reserved = await ReadUInt16Async(stream);
		ushort pageSize = await ReadUInt16Async(stream);
		ushort reserved2 = await ReadUInt16Async(stream);
		ushort entryRegionIndex = await ReadUInt16Async(stream);
		ushort num = await ReadUInt16Async(stream);
		List<MtkDaRegion> list = new List<MtkDaRegion>();
		ushort num2 = 0;
		TaskAwaiter<MtkDaRegion> taskAwaiter2 = default(TaskAwaiter<MtkDaRegion>);
		while ((uint)num2 < (uint)num)
		{
			List<MtkDaRegion> list2 = list;
			TaskAwaiter<MtkDaRegion> taskAwaiter = ParseRegionAsync(stream).GetAwaiter();
			if (!taskAwaiter.IsCompleted)
			{
				//await taskAwaiter;
				taskAwaiter = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter<MtkDaRegion>);
			}
			list2.Add(taskAwaiter.GetResult());
			ushort num3 = checked((ushort)(num2 + 1));
			num2 = num3;
		}
		return new MtkDaEntry(magic, hardwareCode, hardwareSubCode, hardwareVersion, softwareVersion, reserved, pageSize, reserved2, entryRegionIndex, list.ToArray());
	}

	public static async Task<MtkDaEntry[]> GetEntriesAsync(Stream daStream)
	{
		daStream.Seek(104L, SeekOrigin.Begin);
		int num = await ReadInt32Async(daStream);
		List<MtkDaEntry> list = new List<MtkDaEntry>();
		int num2 = 0;
		checked
		{
			TaskAwaiter<MtkDaEntry> taskAwaiter2 = default(TaskAwaiter<MtkDaEntry>);
			while (num2 < num)
			{
				try
				{


					daStream.Seek(108 + num2 * 220, SeekOrigin.Begin);
					List<MtkDaEntry> list2 = list;
					TaskAwaiter<MtkDaEntry> taskAwaiter = ParseDaAsync(daStream).GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						//await taskAwaiter;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter<MtkDaEntry>);
					}
					list2.Add(taskAwaiter.GetResult());
					int num3 = num2 + 1;
					num2 = num3;
				}
				catch { }
			}
			return list.ToArray();
		}
	}

	public static async Task<byte[]> GetStage1Async(Stream daStream, MtkDaEntry entry)
	{
		if (entry.Regions.Length >= 3)
		{
			daStream.Seek(entry.Regions[1].Buffer, SeekOrigin.Begin);
			byte[] array = new byte[checked(entry.Regions[1].Length - 1 + 1)];
			await daStream.ReadAsync(array, 0, array.Length);
			return array;
		}
		throw new ArgumentException("Insufficient DA region count");
	}

	public static async Task<byte[]> GetStage2Async(Stream daStream, MtkDaEntry entry)
	{
		if (entry.Regions.Length < 3)
		{
			throw new ArgumentException("Insufficient DA region count");
		}
		daStream.Seek(entry.Regions[2].Buffer, SeekOrigin.Begin);
		byte[] array = new byte[checked(entry.Regions[2].Length - 1 + 1)];
		await daStream.ReadAsync(array, 0, array.Length);
		return array;
	}
}
