using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using motoulocked.mtkclient2.library.xflash;

namespace motoulocked.mtkclient2.library;

internal class MtkDaxGptService
{
	public static async Task<MtkGpt> ReadAsync(IMtkDevice device, MtkDaxFlashInfo flashInfo, CancellationToken cancellationToken)
	{
		checked
		{
			using MemoryStream memoryStream = new MemoryStream();
			await MtkDaxPartitionService.ReadAsync(device, flashInfo, 0L, 2 * flashInfo.PageSize, memoryStream, cancellationToken);
			MtkGpt gpt = MtkGptParserService.Parse(memoryStream.ToArray(), flashInfo.PageSize);
			memoryStream.SetLength(0L);
			await MtkDaxPartitionService.ReadAsync(device, flashInfo, 0L, 34 * flashInfo.PageSize, memoryStream, cancellationToken);
			return MtkGptParserService.ParsePartitions(gpt, memoryStream.ToArray());
		}
	}

	public static async Task<MtkGpt> ReadAsync(Stream inputStream, int pageSize, CancellationToken cancellationToken)
	{
		checked
		{
			byte[] array = new byte[34 * pageSize - 1 + 1];
			await inputStream.ReadAsync(array, 0, 2 * pageSize, cancellationToken);
			MtkGpt gpt = MtkGptParserService.Parse(array.Take(2 * pageSize).ToArray(), pageSize);
			await inputStream.ReadAsync(array, 2 * pageSize, 32 * pageSize, cancellationToken);
			return MtkGptParserService.ParsePartitions(gpt, array);
		}
	}
}
