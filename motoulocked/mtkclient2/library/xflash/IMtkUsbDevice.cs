using System;
using System.Threading;
using System.Threading.Tasks;

namespace motoulocked.mtkclient2.library.xflash;

internal interface IMtkUsbDevice : IDisposable, IMtkDevice
{
	Task<int> SendControlMessageAsync(byte requestType, byte request, ushort value, ushort index, byte[] data, CancellationToken cancellationToken);

	Task ResetAsync();
}
