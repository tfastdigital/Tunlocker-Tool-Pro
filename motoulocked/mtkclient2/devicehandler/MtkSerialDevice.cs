using System;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.mtkclient2.library.xflash;

namespace motoulocked.mtkclient2.devicehandler;

internal class MtkSerialDevice : IDisposable, IMtkSerialDevice, IMtkDevice
{
	private readonly object m_disposeLock;

	private SerialPort m_port;

	public MtkSerialDevice(SerialPort port)
	{
		m_disposeLock = RuntimeHelpers.GetObjectValue(new object());
		m_port = port;
	}

	public Task ConnectAsync()
	{
		if (m_port == null)
		{
			throw new ObjectDisposedException("MtkSerialDevice");
		}
		m_port.Open();
		m_port.BaseStream.WriteTimeout = m_port.WriteTimeout;
		m_port.BaseStream.ReadTimeout = m_port.ReadTimeout;
		return Task.CompletedTask;
	}

	Task IMtkDevice.ConnectAsync()
	{
		//ILSpy generated this explicit interface implementation from .override directive in ConnectAsync
		return this.ConnectAsync();
	}

	public void Dispose()
	{
		object disposeLock = m_disposeLock;
		ObjectFlowControl.CheckForSyncLockOnValueType(disposeLock);
		bool lockTaken = false;
		try
		{
			Monitor.Enter(disposeLock, ref lockTaken);
			if (m_port == null)
			{
				return;
			}
			try
			{
				if (m_port.IsOpen)
				{
					m_port.DiscardInBuffer();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (m_port.IsOpen)
				{
					m_port.DiscardOutBuffer();
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				m_port.Dispose();
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			m_port = null;
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(disposeLock);
			}
		}
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Dispose
		this.Dispose();
	}

	public async Task<int> ReadAsync(byte[] buffer, int offset, int length, CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();
		if (m_port != null)
		{
			CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
			Task<int> task = m_port.BaseStream.ReadAsync(buffer, offset, length, cancellationTokenSource.Token);
			Task task2 = Task.Delay(m_port.ReadTimeout);
			await Task.WhenAny(task, task2);
			if (task2.IsCompleted && !task.IsCompleted)
			{
				cancellationTokenSource.Cancel();
				throw new TimeoutException();
			}
			return await task;
		}
		throw new InvalidOperationException("Port not connected");
	}

	Task<int> IMtkDevice.ReadAsync(byte[] buffer, int offset, int length, CancellationToken cancellationToken)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ReadAsync
		return this.ReadAsync(buffer, offset, length, cancellationToken);
	}

	public async Task<byte[]> ReadCustomAsync(CancellationToken cancellationToken, int len)
	{
		cancellationToken.ThrowIfCancellationRequested();
		checked
		{
			if (m_port != null)
			{
				CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
				byte[] array = new byte[len - 1 + 1];
				Task<int> task = m_port.BaseStream.ReadAsync(array, 0, array.Length, cancellationTokenSource.Token);
				Task task2 = Task.Delay(m_port.ReadTimeout);
				await Task.WhenAny(task, task2);
				if (task2.IsCompleted && !task.IsCompleted)
				{
					cancellationTokenSource.Cancel();
					throw new TimeoutException();
				}
				int num = await task;
				byte[] array2 = new byte[num - 1 + 1];
				Array.Copy(array, 0, array2, 0, num);
				return array2;
			}
			throw new InvalidOperationException("Port not connected");
		}
	}

	Task<byte[]> IMtkDevice.ReadCustomAsync(CancellationToken cancellationToken, int len)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ReadCustomAsync
		return this.ReadCustomAsync(cancellationToken, len);
	}

	public async Task WriteAsync(byte[] buffer, int offset, int length, CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();
		if (m_port != null)
		{
			CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
			Task task = m_port.BaseStream.WriteAsync(buffer, offset, length, cancellationTokenSource.Token);
			Task task2 = Task.Delay(m_port.WriteTimeout);
			await Task.WhenAny(task, task2);
			if (task2.IsCompleted && !task.IsCompleted)
			{
				cancellationTokenSource.Cancel();
				throw new TimeoutException();
			}
			return;
		}
		throw new InvalidOperationException("Port not connected");
	}

	Task IMtkDevice.WriteAsync(byte[] buffer, int offset, int length, CancellationToken cancellationToken)
	{
		//ILSpy generated this explicit interface implementation from .override directive in WriteAsync
		return this.WriteAsync(buffer, offset, length, cancellationToken);
	}

	public override string ToString()
	{
		SerialPort port = m_port;
		object portName;
		if (port != null)
		{
			portName = port.PortName;
			if (portName != null)
			{
				return (string)portName;
			}
		}
		else
		{
			portName = null;
		}
		portName = "MtkSerialDevice";
		return (string)portName;
	}
}
