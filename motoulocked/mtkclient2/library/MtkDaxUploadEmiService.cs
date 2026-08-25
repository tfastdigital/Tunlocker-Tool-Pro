using System.Threading;
using System.Threading.Tasks;

namespace motoulocked.mtkclient2.library;

internal class MtkDaxUploadEmiService
{
	public static async Task UploadEmiAsync(IMtkDevice device, byte[] emi, CancellationToken cancellationToken)
	{
		await MtkDaxService.SendAsync(device, 65546u, cancellationToken);
		if ((long)(await MtkDaxService.ReadStatusAsync(device, cancellationToken)) == 0L)
		{
			await MtkDaxService.SendAsync(device, checked((uint)emi.Length), cancellationToken);
			await MtkDaxService.SendAsync(device, emi, cancellationToken);
			await MtkDaxService.ReadStatusAsync(device, cancellationToken);
		}
	}
}
