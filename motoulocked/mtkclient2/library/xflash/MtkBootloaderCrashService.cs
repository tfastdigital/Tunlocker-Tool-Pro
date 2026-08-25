using System.Threading;
using System.Threading.Tasks;

namespace motoulocked.mtkclient2.library.xflash;

internal class MtkBootloaderCrashService
{
	private static byte[] DA_CRASH_PAYLOAD;

	public static Task CrashAsync(IMtkDevice device, CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();
		NewMtkBootloaderCrashService();
		return MtkDaWriteService.WriteAsync(device, 0u, 0, DA_CRASH_PAYLOAD, validateUploadStatus: false, cancellationToken);
	}

	private static void NewMtkBootloaderCrashService()
	{
		DA_CRASH_PAYLOAD = new byte[32]
		{
			92, 120, 48, 48, 92, 120, 48, 49, 92, 120,
			57, 70, 92, 120, 69, 53, 92, 120, 49, 48,
			92, 120, 70, 70, 92, 120, 50, 70, 92, 120,
			69, 49
		};
	}
}
