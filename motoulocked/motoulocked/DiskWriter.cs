using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32.SafeHandles;

namespace motoulocked.motoulocked;

public class DiskWriter : IDisposable
{
	private static SafeFileHandle OpenReadWritePort = new SafeFileHandle(IntPtr.Zero, ownsHandle: true);

    public static bool isDebbugging = false;

	private readonly object m_disposeLock;

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern SafeFileHandle CreateFile(string fileName, uint desiredAccess, uint shareMode, IntPtr securityAttributes, uint creationDisposition, uint flagsAndAttributes, IntPtr hTemplateFile);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int ReadFile(SafeFileHandle handle, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] bytes, int numBytesToRead, ref int numBytesRead, IntPtr overlapped_MustBeZero);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int WriteFile(SafeFileHandle handle, byte[] bytes, int numBytesToWrite, ref int numBytesWritten, IntPtr overlapped_MustBeZero);

	public DiskWriter()
	{
		m_disposeLock = RuntimeHelpers.GetObjectValue(new object());
	}

	public static bool Openport(string devices)
	{
		//OpenReadWritePort = new SafeFileHandle(IntPtr.Zero, ownsHandle: true);
        OpenReadWritePort = CreateFile(devices, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
		if (OpenReadWritePort.IsInvalid)
		{
			return false;
		}
		return true;
	}

	public static void Closeport()
	{
		if (OpenReadWritePort != null && !OpenReadWritePort.IsInvalid)
		{
			OpenReadWritePort.Close();
		}
		try
		{
			OpenReadWritePort.Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void DiskWrite(byte[] data)
	{
		int numBytesWritten = -1;
		Task.Run([SpecialName] () =>
		{
			WriteFile(OpenReadWritePort, data, data.Length, ref numBytesWritten, IntPtr.Zero);
			if (isDebbugging)
			{
				Console.WriteLine(string.Format("Write  -> [{0}] : {1}", data.Length, BitConverter.ToString(data).Replace("-", " ")));
			}
		}).Wait(5000);
		_ = numBytesWritten;
		_ = -1;
	}

	public static byte[] DiskRead()
	{
		int num = 8192;
		num = int.Parse(FIREHOSE_MANAGER.MaxPayloadSizeToTargetInBytes);
		byte[] array = new byte[checked(num - 1 + 1)];
		int numBytesRead = -1;
		byte[] result = array;
		Task.Run([SpecialName] () =>
		{
			ReadFile(OpenReadWritePort, array, array.Length, ref numBytesRead, IntPtr.Zero);
			if (isDebbugging)
			{
				Console.WriteLine(string.Format("Read   <- [{0}] : {1}", numBytesRead, BitConverter.ToString(array.Take(numBytesRead).ToArray()).Replace("-", " ")));
			}
			result = array.Take(numBytesRead).ToArray();
		}).Wait(5000);
		if (numBytesRead == -1)
		{
			throw new Exception(" • USB Read Operations Timeout...");
		}
		return result;
	}

	public void Dispose()
	{
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Dispose
		this.Dispose();
	}
}
