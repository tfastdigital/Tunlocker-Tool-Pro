using System;
using System.Threading;
using System.Threading.Tasks;

namespace motoulocked.mtkclient2;

internal interface IMtkDevice : IDisposable
{
	Task ConnectAsync();

	Task<int> ReadAsync(byte[] buff, int offset, int len, CancellationToken cancellationToken);

	Task<byte[]> ReadCustomAsync(CancellationToken cancellationToken, int len);

	Task WriteAsync(byte[] buff, int offset, int len, CancellationToken cancellationToken);
}
