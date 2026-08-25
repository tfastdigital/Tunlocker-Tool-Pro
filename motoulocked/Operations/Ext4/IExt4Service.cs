using System.Threading.Tasks;

namespace motoulocked.Operations.Ext4;

internal interface IExt4Service
{
	Task<long> GetFileSizeAsync(byte[] partitionData, int blockSize, string targetPath);

	Task<byte[]> ReadFileAsync(byte[] partitionData, int blockSize, string targetPath);

	Task WriteFileAsync(byte[] partitionData, int blockSize, string targetPath, byte[] data);

	Task DeleteFileAsync(byte[] partitionData, int blockSize, string targetPath);
}
