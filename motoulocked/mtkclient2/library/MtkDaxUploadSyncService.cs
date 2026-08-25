using System;
using System.Threading;
using System.Threading.Tasks;
using motoulocked.mtkclient2.library.xflash;

namespace motoulocked.mtkclient2.library;

internal class MtkDaxUploadSyncService
{
	public static async Task SyncAsync(IMtkDevice device, CancellationToken cancellationToken)
	{
		Console.WriteLine("Reading DA sync");
		byte b = await MtkDeviceExtension.ReadByteAsync(device, cancellationToken);
		if (b != 192)
		{
			Console.WriteLine($"Invalid DA sync: 0x{b:X2}");
		}
		await MtkDaxService.SendAsync(device, 1129208147u, cancellationToken);
		await MtkDaxUploadSetupService.SetupEnvAsync(device, cancellationToken);
		await MtkDaxUploadSetupService.SetupHardwareInitAsync(device, cancellationToken);
		Console.WriteLine("Reading status");
		uint num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
		if ((ulong)num != 1129208147)
		{
			Console.WriteLine($"Invalid DA sync status: 0x{num:X8}");
		}
	}
}
