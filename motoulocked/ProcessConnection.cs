using System.Management;

namespace motoulocked;

internal class ProcessConnection
{
	public static ManagementScope ConnectionScope(string machineName, ConnectionOptions options, string path)
	{
		ManagementScope managementScope = new ManagementScope();
		managementScope.Path = new ManagementPath("\\\\" + machineName + path);
		managementScope.Options = options;
		managementScope.Connect();
		return managementScope;
	}

	public static ConnectionOptions ProcessConnectionOptions()
	{
		return new ConnectionOptions
		{
			Impersonation = ImpersonationLevel.Impersonate,
			Authentication = AuthenticationLevel.Default,
			EnablePrivileges = true
		};
	}
}
