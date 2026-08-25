using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.motoulocked;

namespace motoulocked.mtkclient2.library.xflash;

internal class MtkPreloaderService
{
	private static byte[] ConvertDwordsToByteArray(uint[] dwords)
	{
		checked
		{
			using MemoryStream memoryStream = new MemoryStream(dwords.Length * 4);
			int num = dwords.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				byte[] bytes = BitConverter.GetBytes(dwords[i]);
				memoryStream.Write(bytes, 0, bytes.Length);
			}
			return memoryStream.ToArray();
		}
	}

	public static async Task<MtkPreloader> DumpAsynctest(IMtkDevice device, MtkChipConfig chipConfig, CancellationToken cancellationToken)
	{
		Form1.SharedUI.ProgressBar4.Text = "Sending EMI Data...[0%]";
		Form1.SharedUI.ProgressBar4.Maximum = 100;
		Form1.SharedUI.ProgressBar4.Value = 0;
		SerialCOM.MSL = "ENREAD";
		checked
		{
			try
			{
				byte[] data = ConvertDwordsToByteArray(await MtkReadWrite32Service.ReadResultAsync(device, 2097152u, 16384, little: true, cancellationToken));
				MtkPreloaderIndex mtkPreloaderIndex = MtkPreloaderParserService.ParseIndex(data);
				MemoryStream memoryStream = new MemoryStream();
				int i = mtkPreloaderIndex.Index;
				int num = 32;
				_ = mtkPreloaderIndex.Length + num * 16;
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				for (; i - mtkPreloaderIndex.Index <= mtkPreloaderIndex.Length; i += num * 16)
				{
					uint address = (uint)(2097152 + i);
					_ = (double)i / stopwatch.Elapsed.TotalSeconds;
					UiManager.ProcessBar_Sending_EMI(i, mtkPreloaderIndex.Length);
					data = ConvertDwordsToByteArray(await MtkReadWrite32Service.ReadResultAsync(device, address, num * 4, little: true, cancellationToken));
					await memoryStream.WriteAsync(data, 0, data.Length);
				}
				stopwatch.Stop();
				memoryStream.Seek(0L, SeekOrigin.Begin);
				return await LoadAsync(memoryStream, chipConfig, cancellationToken);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				MtkPreloader result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static async Task<MtkPreloader> DumpAsynctest2(IMtkDevice device, MtkChipConfig chipConfig, CancellationToken cancellationToken)
	{
		checked
		{
			try
			{
				MemoryStream memoryStream = new MemoryStream();
				int i = 0;
				int num = 32;
				int num2 = 16384;
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				for (; i < num2; i += num * 4)
				{
					uint address = (uint)(2097152 + i);
					_ = (double)i / stopwatch.Elapsed.TotalSeconds;
					Form1.ProcessBar(i, num2);
					byte[] array = ConvertDwordsToByteArray(await MtkReadWrite32Service.ReadResultAsync(device, address, num * 4, little: true, cancellationToken));
					await memoryStream.WriteAsync(array, 0, array.Length);
				}
				stopwatch.Stop();
				memoryStream.Seek(0L, SeekOrigin.Begin);
				return await LoadAsync(memoryStream, chipConfig, cancellationToken);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				MtkPreloader result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static async Task<MtkPreloader> LoadAsync(Stream preloaderStream, MtkChipConfig chipConfig, CancellationToken cancellationToken)
	{
		byte[] array = new byte[checked((int)preloaderStream.Length - 1 + 1)];
		await preloaderStream.ReadAsync(array, 0, array.Length, cancellationToken);
		string name = MtkPreloaderParserService.ParseName(array);
		MtkPreloaderEmi mtkPreloaderEmi = MtkPreloaderParserService.ParseEmi(array, chipConfig.UseXFlash);
		return new MtkPreloader(name, mtkPreloaderEmi.Version, mtkPreloaderEmi.Emi, array);
	}
}
