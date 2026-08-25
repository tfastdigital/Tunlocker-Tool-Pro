using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.mtkclient2.MTK.Client;

namespace motoulocked.mtkclient2.library;

internal class MtkDaxPartitionService
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__2_002D0
	{
		public long _0024VB_0024Local_size;

		public _Closure_0024__2_002D0(_Closure_0024__2_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_size = arg0._0024VB_0024Local_size;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			Form1.SharedUI.label_totalsize.Text = utils.GetFileSize(_0024VB_0024Local_size);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__2_002D1
	{
		public long _0024VB_0024Local_totalRead;

		public Action _0024I1;

		public _Closure_0024__2_002D1(_Closure_0024__2_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_totalRead = arg0._0024VB_0024Local_totalRead;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__1()
		{
			Form1.SharedUI.label_writensize.Text = utils.GetFileSize(_0024VB_0024Local_totalRead);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__2_002D2
	{
		public double _0024VB_0024Local_speed;

		public _Closure_0024__2_002D2(_Closure_0024__2_002D2 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_speed = arg0._0024VB_0024Local_speed;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__2()
		{
			Form1.SharedUI.label_transferrate.Text = utils.GetFileSize(Convert.ToInt64(_0024VB_0024Local_speed)) + " /s";
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__3_002D0
	{
		public long _0024VB_0024Local_size;

		public _Closure_0024__3_002D0(_Closure_0024__3_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_size = arg0._0024VB_0024Local_size;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			Form1.SharedUI.label_totalsize.Text = utils.GetFileSize(_0024VB_0024Local_size);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__3_002D1
	{
		public long _0024VB_0024Local_totalRead;

		public Action _0024I1;

		public _Closure_0024__3_002D1(_Closure_0024__3_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_totalRead = arg0._0024VB_0024Local_totalRead;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__1()
		{
			Form1.SharedUI.label_writensize.Text = utils.GetFileSize(_0024VB_0024Local_totalRead);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__3_002D2
	{
		public double _0024VB_0024Local_speed;

		public _Closure_0024__3_002D2(_Closure_0024__3_002D2 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_speed = arg0._0024VB_0024Local_speed;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__2()
		{
			Form1.SharedUI.label_transferrate.Text = utils.GetFileSize(Convert.ToInt64(_0024VB_0024Local_speed)) + " /s";
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__4_002D0
	{
		public long _0024VB_0024Local_partitionSize;

		public long _0024VB_0024Local_totalRead;

		public Action _0024I1;

		public _Closure_0024__4_002D0(_Closure_0024__4_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_partitionSize = arg0._0024VB_0024Local_partitionSize;
				_0024VB_0024Local_totalRead = arg0._0024VB_0024Local_totalRead;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			Form1.SharedUI.label_totalsize.Text = utils.GetFileSize(_0024VB_0024Local_partitionSize);
		}

		[SpecialName]
		internal void _Lambda_0024__1()
		{
			Form1.SharedUI.label_writensize.Text = utils.GetFileSize(_0024VB_0024Local_totalRead);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__4_002D1
	{
		public double _0024VB_0024Local_speed;

		public _Closure_0024__4_002D1(_Closure_0024__4_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_speed = arg0._0024VB_0024Local_speed;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__2()
		{
			Form1.SharedUI.label_transferrate.Text = utils.GetFileSize(Convert.ToInt64(_0024VB_0024Local_speed)) + " /s";
		}
	}

	public static async Task SendCommandAsync(IMtkDevice device, MtkDaxFlashInfo flashInfo, uint command, int partitionType, long address, long size, CancellationToken cancellationToken)
	{
		await MtkDaxService.SendAsync(device, command, cancellationToken);
		uint num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
		if ((long)num == 0L)
		{
			using (MemoryStream memoryStream = new MemoryStream())
			{
				Extension.Write(memoryStream, BitConverter.GetBytes((int)flashInfo.Type));
				Extension.Write(memoryStream, BitConverter.GetBytes(partitionType));
				Extension.Write(memoryStream, BitConverter.GetBytes(address));
				Extension.Write(memoryStream, BitConverter.GetBytes(size));
				Extension.Write(memoryStream, new byte[32]);
				await MtkDaxService.SendAsync(device, memoryStream.ToArray(), cancellationToken);
				num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
				if ((long)num != 0L)
				{
					Console.WriteLine($"Invalid DAX flash command param status: 0x{num:X8}");
				}
				return;
			}
		}
		Console.WriteLine($"Invalid DAX flash command status: 0x{num:X8}");
	}

	public static async Task ReadAsync(IMtkDevice device, MtkDaxFlashInfo flashInfo, long address, long size, Stream outputStream, CancellationToken cancellationToken)
	{
		_Closure_0024__2_002D0 arg = default(_Closure_0024__2_002D0);
		_Closure_0024__2_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__2_002D0(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024Local_size = size;
		Form1.SharedUI.label_totalsize.Invoke((Action)([SpecialName] () =>
		{
			Form1.SharedUI.label_totalsize.Text = utils.GetFileSize(CS_0024_003C_003E8__locals0._0024VB_0024Local_size);
		}));
		await SendCommandAsync(device, flashInfo, 65541u, (flashInfo.Type == MtkDaxFlashInfoType.UFS) ? 3 : 8, address, CS_0024_003C_003E8__locals0._0024VB_0024Local_size, cancellationToken);
		uint num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
		if ((long)num == 0L)
		{
			_Closure_0024__2_002D1 arg2 = default(_Closure_0024__2_002D1);
			_Closure_0024__2_002D1 CS_0024_003C_003E8__locals1 = new _Closure_0024__2_002D1(arg2);
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			CS_0024_003C_003E8__locals1._0024VB_0024Local_totalRead = 0L;
			_Closure_0024__2_002D2 closure_0024__2_002D = default(_Closure_0024__2_002D2);
			while (CS_0024_003C_003E8__locals1._0024VB_0024Local_totalRead < CS_0024_003C_003E8__locals0._0024VB_0024Local_size)
			{
				closure_0024__2_002D = new _Closure_0024__2_002D2(closure_0024__2_002D);
				byte[] array = await MtkDaxService.ReadAsync(device, cancellationToken);
				await outputStream.WriteAsync(array, 0, array.Length);
				checked
				{
					CS_0024_003C_003E8__locals1._0024VB_0024Local_totalRead += array.Length;
					Form1.SharedUI.label_writensize.Invoke((Action)([SpecialName] () =>
					{
						Form1.SharedUI.label_writensize.Text = utils.GetFileSize(CS_0024_003C_003E8__locals1._0024VB_0024Local_totalRead);
					}));
					TimeSpan elapsed = stopwatch.Elapsed;
					closure_0024__2_002D._0024VB_0024Local_speed = (double)CS_0024_003C_003E8__locals1._0024VB_0024Local_totalRead / elapsed.TotalSeconds;
					Form1.SharedUI.label_transferrate.Invoke(new Action(closure_0024__2_002D._Lambda_0024__2));
					Form1.ProcessBar(CS_0024_003C_003E8__locals1._0024VB_0024Local_totalRead, CS_0024_003C_003E8__locals0._0024VB_0024Local_size);
				}
				if ((long)(await MtkDaxService.ReadAckAsync(device, cancellationToken)) != 0L)
				{
					stopwatch.Stop();
					break;
				}
			}
		}
		else
		{
			Console.WriteLine($"Invalid partition read command status: 0x{num:X8}");
		}
	}

	public static async Task ReadSaveAsync(IMtkDevice device, MtkDaxFlashInfo flashInfo, long address, long size, string save, CancellationToken cancellationToken)
	{
		_Closure_0024__3_002D0 arg = default(_Closure_0024__3_002D0);
		_Closure_0024__3_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__3_002D0(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024Local_size = size;
		Form1.SharedUI.label_totalsize.Invoke((Action)([SpecialName] () =>
		{
			Form1.SharedUI.label_totalsize.Text = utils.GetFileSize(CS_0024_003C_003E8__locals0._0024VB_0024Local_size);
		}));
		await SendCommandAsync(device, flashInfo, 65541u, (flashInfo.Type == MtkDaxFlashInfoType.UFS) ? 3 : 8, address, CS_0024_003C_003E8__locals0._0024VB_0024Local_size, cancellationToken);
		FileStream fileStream = new FileStream(save, FileMode.Append, FileAccess.Write);
		using (fileStream)
		{
			uint num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
			if ((long)num == 0L)
			{
				_Closure_0024__3_002D1 arg2 = default(_Closure_0024__3_002D1);
				_Closure_0024__3_002D1 CS_0024_003C_003E8__locals1 = new _Closure_0024__3_002D1(arg2);
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				CS_0024_003C_003E8__locals1._0024VB_0024Local_totalRead = 0L;
				_Closure_0024__3_002D2 closure_0024__3_002D = default(_Closure_0024__3_002D2);
				while (CS_0024_003C_003E8__locals1._0024VB_0024Local_totalRead < CS_0024_003C_003E8__locals0._0024VB_0024Local_size)
				{
					closure_0024__3_002D = new _Closure_0024__3_002D2(closure_0024__3_002D);
					byte[] array = await MtkDaxService.ReadAsync(device, cancellationToken);
					await fileStream.WriteAsync(array, 0, array.Length);
					checked
					{
						CS_0024_003C_003E8__locals1._0024VB_0024Local_totalRead += array.Length;
						Form1.SharedUI.label_writensize.Invoke((Action)([SpecialName] () =>
						{
							Form1.SharedUI.label_writensize.Text = utils.GetFileSize(CS_0024_003C_003E8__locals1._0024VB_0024Local_totalRead);
						}));
						TimeSpan elapsed = stopwatch.Elapsed;
						closure_0024__3_002D._0024VB_0024Local_speed = (double)CS_0024_003C_003E8__locals1._0024VB_0024Local_totalRead / elapsed.TotalSeconds;
						Form1.SharedUI.label_transferrate.Invoke(new Action(closure_0024__3_002D._Lambda_0024__2));
						Form1.ProcessBar(CS_0024_003C_003E8__locals1._0024VB_0024Local_totalRead, CS_0024_003C_003E8__locals0._0024VB_0024Local_size);
					}
					if ((long)(await MtkDaxService.ReadAckAsync(device, cancellationToken)) != 0L)
					{
						stopwatch.Stop();
						break;
					}
				}
				fileStream.Close();
			}
			else
			{
				Console.WriteLine($"Invalid partition read command status: 0x{num:X8}");
			}
		}
	}

	public static async Task ReadPartitionByNameAsync(IMtkDevice device, string partitionName, Stream outputStream, CancellationToken cancellationToken)
	{
		await MtkDaxDeviceControlService.SendDevCtrlNoReadAsync(device, 524289u, cancellationToken);
		uint num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
		if ((long)num == 0L)
		{
			await MtkDaxService.SendAsync(device, 65538u, cancellationToken);
			num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
			if ((long)num == 0L)
			{
				await MtkDaxService.SendAsync(device, Encoding.ASCII.GetBytes(partitionName), cancellationToken);
				num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
				if ((long)num == 0L)
				{
					byte[] array = await MtkDaxService.ReadAsync(device, cancellationToken);
					if (array.Length >= 8)
					{
						_Closure_0024__4_002D0 arg = default(_Closure_0024__4_002D0);
						_Closure_0024__4_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__4_002D0(arg);
						num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
						if ((long)num != 0L)
						{
							Console.WriteLine($"Invalid partition size status: 0x{num:X8}");
						}
						CS_0024_003C_003E8__locals0._0024VB_0024Local_partitionSize = BitConverter.ToInt64(array, 0);
						Form1.SharedUI.label_totalsize.Invoke((Action)([SpecialName] () =>
						{
							Form1.SharedUI.label_totalsize.Text = utils.GetFileSize(CS_0024_003C_003E8__locals0._0024VB_0024Local_partitionSize);
						}));
						Stopwatch stopwatch = new Stopwatch();
						stopwatch.Start();
						CS_0024_003C_003E8__locals0._0024VB_0024Local_totalRead = 0L;
						checked
						{
							_Closure_0024__4_002D1 closure_0024__4_002D = default(_Closure_0024__4_002D1);
							while (CS_0024_003C_003E8__locals0._0024VB_0024Local_totalRead < CS_0024_003C_003E8__locals0._0024VB_0024Local_partitionSize)
							{
								closure_0024__4_002D = new _Closure_0024__4_002D1(closure_0024__4_002D);
								if (cancellationToken.IsCancellationRequested)
								{
									break;
								}
								byte[] array2 = await MtkDaxService.ReadAsync(device, cancellationToken);
								await outputStream.WriteAsync(array2, 0, array2.Length);
								CS_0024_003C_003E8__locals0._0024VB_0024Local_totalRead += array2.Length;
								Form1.SharedUI.label_writensize.Invoke((Action)([SpecialName] () =>
								{
									Form1.SharedUI.label_writensize.Text = utils.GetFileSize(CS_0024_003C_003E8__locals0._0024VB_0024Local_totalRead);
								}));
								TimeSpan elapsed = stopwatch.Elapsed;
								closure_0024__4_002D._0024VB_0024Local_speed = (double)CS_0024_003C_003E8__locals0._0024VB_0024Local_totalRead / elapsed.TotalSeconds;
								Form1.SharedUI.label_transferrate.Invoke(new Action(closure_0024__4_002D._Lambda_0024__2));
								Form1.ProcessBar(CS_0024_003C_003E8__locals0._0024VB_0024Local_totalRead, CS_0024_003C_003E8__locals0._0024VB_0024Local_partitionSize);
							}
							stopwatch.Stop();
							await MtkDaxService.SendAsync(device, 0u, cancellationToken);
							Console.WriteLine("Reading complete status response");
							num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
						}
						if ((long)num != 0L)
						{
							Console.WriteLine($"Invalid complete status response: 0x{num:X8}");
						}
						return;
					}
					Console.WriteLine("Invalid partition size buffer length: " + Conversions.ToString(array.Length));
				}
				Console.WriteLine($"Invalid partition name param status: 0x{num:X8}");
			}
			Console.WriteLine($"Invalid DAX upload command status: 0x{num:X8}");
		}
		Console.WriteLine($"Invalid START_DL_INFO status: 0x{num:X8}");
	}

	public static async Task FormatAsync(IMtkDevice device, MtkDaxFlashInfo flashInfo, long address, long size, CancellationToken cancellationToken)
	{
		await SendCommandAsync(device, flashInfo, 65539u, (flashInfo.Type == MtkDaxFlashInfoType.UFS) ? 3 : 8, address, size, cancellationToken);
		uint num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
		while (true)
		{
			switch (num)
			{
			case 1074003972u:
				if (!cancellationToken.IsCancellationRequested)
				{
					await Task.Delay(TimeSpan.FromMilliseconds(await MtkDaxService.ReadStatusAsync(device, cancellationToken)), cancellationToken);
					num = await MtkDaxService.ReadAckAsync(device, cancellationToken);
				}
				break;
			default:
				Console.WriteLine($"Invalid format partition complete status: 0x{num:X8}");
				return;
			case 0u:
			case 1074003973u:
				return;
			}
		}
	}

	public static async Task WriteAsync(IMtkDevice device, MtkDaxFlashInfo flashInfo, int lu, long address, long len, string files, CancellationToken cancellationToken)
	{
		if (flashInfo.Type != MtkDaxFlashInfoType.UFS && lu != 8)
		{
			throw new ArgumentException("Invalid flash type: " + Conversions.ToString(lu));
		}
		Stream stream = File.OpenRead(files);
		stream.Seek(0L, SeekOrigin.Begin);
		checked
		{
			try
			{
				await SendCommandAsync(device, flashInfo, 65540u, lu, address, stream.Length, cancellationToken);
				long num = 0L;
				byte[] array = ((stream.Length >= flashInfo.WriteBufferSize) ? new byte[flashInfo.WriteBufferSize - 1 + 1] : new byte[(int)(stream.Length - 1) + 1]);
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				uint num4;
				while (true)
				{
					if (num < stream.Length)
					{
						int count = (int)Math.Min(array.Length, stream.Length - num);
						int num2 = await stream.ReadAsync(array, 0, count, cancellationToken);
						if (num2 == 0)
						{
							throw new ArgumentException("Unable to read input stream");
						}
						byte[] array2 = array.Take(num2).ToArray();
						int num3 = MtkDaxPartitionChecksumService.Calculate(array2);
						await MtkDaxService.SendAsync(device, 0u, cancellationToken);
						await MtkDaxService.SendAsync(device, (uint)num3, cancellationToken);
						await MtkDaxService.SendAsync(device, array2, array2.Length, cancellationToken);
						num4 = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
						if (unchecked((long)num4) != 0L)
						{
							break;
						}
						num += num2;
						_ = (double)num / stopwatch.Elapsed.TotalSeconds;
						Form1.ProcessBar(num, stream.Length);
					}
					else
					{
						stopwatch.Stop();
						uint num5 = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
						if (unchecked((long)num5) == 0L)
						{
							await MtkDaxDeviceControlService.SendDevCtrlAsync(device, 8388613u, cancellationToken);
							return;
						}
						Console.WriteLine($"Invalid done write partition status: 0x{num5:X8}");
					}
				}
				Console.WriteLine($"Invalid write partition status: 0x{num4:X8}");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			finally
			{
				stream.Close();
				if (files.Contains(".uns"))
				{
					File.Delete(files);
					Thread.Sleep(500);
				}
			}
		}
	}

	public static async Task WriteAsync_By_Byte(IMtkDevice device, MtkDaxFlashInfo flashInfo, int lu, long address, long len, Stream Bytee, CancellationToken cancellationToken)
	{
		if (flashInfo.Type != MtkDaxFlashInfoType.UFS && lu != 8)
		{
			throw new ArgumentException("Invalid flash type: " + Conversions.ToString(lu));
		}
		Bytee.Seek(0L, SeekOrigin.Begin);
		checked
		{
			try
			{
				await SendCommandAsync(device, flashInfo, 65540u, lu, address, Bytee.Length, cancellationToken);
				long num = 0L;
				byte[] array = ((Bytee.Length >= flashInfo.WriteBufferSize) ? new byte[flashInfo.WriteBufferSize - 1 + 1] : new byte[(int)(Bytee.Length - 1) + 1]);
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				uint num4;
				while (true)
				{
					if (num < Bytee.Length)
					{
						int count = (int)Math.Min(array.Length, Bytee.Length - num);
						int num2 = await Bytee.ReadAsync(array, 0, count, cancellationToken);
						if (num2 == 0)
						{
							throw new ArgumentException("Unable to read input stream");
						}
						byte[] array2 = array.Take(num2).ToArray();
						int num3 = MtkDaxPartitionChecksumService.Calculate(array2);
						await MtkDaxService.SendAsync(device, 0u, cancellationToken);
						await MtkDaxService.SendAsync(device, (uint)num3, cancellationToken);
						await MtkDaxService.SendAsync(device, array2, array2.Length, cancellationToken);
						num4 = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
						if (unchecked((long)num4) != 0L)
						{
							break;
						}
						num += num2;
						_ = (double)num / stopwatch.Elapsed.TotalSeconds;
						Form1.ProcessBar(num, Bytee.Length);
					}
					else
					{
						stopwatch.Stop();
						uint num5 = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
						if (unchecked((long)num5) == 0L)
						{
							await MtkDaxDeviceControlService.SendDevCtrlAsync(device, 8388613u, cancellationToken);
							return;
						}
						Console.WriteLine($"Invalid done write partition status: 0x{num5:X8}");
					}
				}
				Console.WriteLine($"Invalid write partition status: 0x{num4:X8}");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			finally
			{
				Bytee.Close();
			}
		}
	}

	public static Task WriteAsync(IMtkDevice device, MtkDaxFlashInfo flashInfo, long address, long len, Stream Bytee, CancellationToken cancellationToken)
	{
		return WriteAsync_By_Byte(device, flashInfo, (flashInfo.Type == MtkDaxFlashInfoType.UFS) ? 3 : 8, address, len, Bytee, cancellationToken);
	}

	public static Task WriteAsync(IMtkDevice device, MtkDaxFlashInfo flashInfo, long address, long len, string file, CancellationToken cancellationToken)
	{
		return WriteAsync(device, flashInfo, (flashInfo.Type == MtkDaxFlashInfoType.UFS) ? 3 : 8, address, len, file, cancellationToken);
	}

	public static async Task WritePartitionByNameAsync(IMtkDevice device, string partitionName, Stream outputStream, CancellationToken cancellationToken)
	{
		await MtkDaxDeviceControlService.SendDevCtrlNoReadAsync(device, 524289u, cancellationToken);
		uint num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
		if ((long)num == 0L)
		{
			await MtkDaxService.SendAsync(device, 65538u, cancellationToken);
			num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
			if ((long)num == 0L)
			{
				await MtkDaxService.SendAsync(device, Encoding.ASCII.GetBytes(partitionName), cancellationToken);
				num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
				if ((long)num == 0L)
				{
					byte[] array = await MtkDaxService.ReadAsync(device, cancellationToken);
					if (array.Length >= 8)
					{
						num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
						if ((long)num != 0L)
						{
							Console.WriteLine($"Invalid partition size status: 0x{num:X8}");
						}
						long num2 = BitConverter.ToInt64(array, 0);
						Stopwatch stopwatch = new Stopwatch();
						stopwatch.Start();
						long num3 = 0L;
						while (num3 < num2 && !cancellationToken.IsCancellationRequested)
						{
							byte[] array2 = await MtkDaxService.ReadAsync(device, cancellationToken);
							await outputStream.WriteAsync(array2, 0, array2.Length);
							num3 = checked(num3 + array2.Length);
							Form1.ProcessBar(num3, num2);
						}
						stopwatch.Stop();
						await MtkDaxService.SendAsync(device, 0u, cancellationToken);
						Console.WriteLine("Reading complete status response");
						num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
						if ((long)num != 0L)
						{
							Console.WriteLine($"Invalid complete status response: 0x{num:X8}");
						}
						return;
					}
					Console.WriteLine("Invalid partition size buffer length: " + Conversions.ToString(array.Length));
				}
				Console.WriteLine($"Invalid partition name param status: 0x{num:X8}");
			}
			Console.WriteLine($"Invalid DAX upload command status: 0x{num:X8}");
		}
		Console.WriteLine($"Invalid START_DL_INFO status: 0x{num:X8}");
	}
}
