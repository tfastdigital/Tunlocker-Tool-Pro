using System;

namespace motoulocked.mtkclient2.library;

internal class DeviceSecurityNotSupportedException : Exception
{
	public DeviceSecurityNotSupportedException()
		: base("Device security not supported")
	{
	}
}
