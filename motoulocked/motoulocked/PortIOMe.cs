using System;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.motoulocked;

[StandardModule]
internal sealed class PortIOMe
{
	public static SerialPort Ports = new SerialPort();

	public static int PortCOM { get; set; }

	public static bool isDebbuging { get; set; } = false;


	public static int WaktuCariPort { get; set; } = 600;


	public static bool PortsOpen()
	{
		Ports = new SerialPort
		{
			BaudRate = 921600,
			PortName = "COM" + Conversions.ToString(PortCOM)
		};
		int num = 0;
		while (IsResourceInUse())
		{
			if (num == WaktuCariPort)
			{
				if (Ports.IsOpen)
				{
					Ports.Close();
				}
				DiskWriter.Closeport();
				return false;
			}
			Task.Delay(100);
			num = checked(num + 1);
		}
		if (!Ports.IsOpen)
		{
			Ports.Open();
		}
		return Ports.IsOpen;
	}

	public static bool IsResourceInUse()
	{
		bool result;
		try
		{
			Ports.Open();
			result = false;
		}
		catch (UnauthorizedAccessException ex)
		{
			ProjectData.SetProjectError(ex);
			UnauthorizedAccessException ex2 = ex;
			if (Ports.IsOpen)
			{
				Ports.Close();
			}
			result = true;
			ProjectData.ClearProjectError();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			if (Ports.IsOpen)
			{
				Ports.Close();
			}
			result = true;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static byte[] PortRead(int timeSpan)
	{
		if (Ports == null || !Ports.IsOpen)
		{
			return new byte[0];
		}
		Thread.Sleep(timeSpan);
		int bytesToRead = Ports.BytesToRead;
		byte[] array = new byte[checked(bytesToRead - 1 + 1)];
		Ports.Read(array, 0, bytesToRead);
		return array;
	}

	public static void PortWrite(byte[] request)
	{
		if (Ports != null && Ports.IsOpen)
		{
			Ports.Write(request, 0, request.Length);
		}
	}
}
