using System;
using System.Threading;
using System.Threading.Tasks;

namespace motoulocked.mtkclient2.library;

internal class MtkDaxPartitionPacketLengthService
{
	public static async Task<PartitionPacketLength> GetAsync(IMtkDevice device, CancellationToken cancellationToken)
	{
		byte[] array = await MtkDaxDeviceControlService.SendDevCtrlAsync(device, 262151u, cancellationToken);
		if (array.Length < 8)
		{
			Console.WriteLine("Invalid partition packet length command response length");
		}
		return new PartitionPacketLength(BitConverter.ToInt32(array, 0), BitConverter.ToInt32(array, 4));
	}
}
