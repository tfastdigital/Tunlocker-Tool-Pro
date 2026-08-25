using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.mtkclient2.devicehandler;
using motoulocked.mtkclient2.Tasks;

namespace motoulocked.mtkclient2.library.xflash;

internal class MtkDeviceWaiterService
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__6_002D0
	{
		public int _0024VB_0024Local_current;

		public Action _0024I0;

		public _Closure_0024__6_002D0(_Closure_0024__6_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_current = arg0._0024VB_0024Local_current;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			Form1.SharedUI.ProgressBar4.Value = _0024VB_0024Local_current;
		}
	}

	public static bool reconnect = false;

	public static string com;

	public static async Task<MtkDeviceWaitResult> WaitSerialAsync(bool doHandshake, CancellationToken cancellationToken)
	{
		MtkTask.CHECK = "";
		int num = -1;
		checked
		{
			while (true)
			{
				cancellationToken.ThrowIfCancellationRequested();
				int num2 = num + 1;
				num = num2;
				if (num != 180)
				{
					IMtkSerialDevice[] array = await MtkSerialDeviceFinderService.FindAsync();
					if (array.Length != 0)
					{
						if (array.Length <= 1)
						{
							com = array[0].ToString();
							if (Operators.CompareString(MtkTask.Crashing, "OK", TextCompare: false) == 0)
							{
								try
								{
									await array[0].ConnectAsync();
								}
								catch (Exception projectError)
								{
									ProjectData.SetProjectError(projectError);
									array[0].Dispose();
									Thread.Sleep(1000);
									ProjectData.ClearProjectError();
									continue;
								}
							}
							else
							{
								try
								{
									await array[0].ConnectAsync();
								}
								catch (Exception projectError2)
								{
									ProjectData.SetProjectError(projectError2);
									array[0].Dispose();
									gui.Richlog("Failed Try Again", Color.Red);
									MtkTask.CHECK = "no";
									ProjectData.ClearProjectError();
									break;
								}
							}
							bool isBootloader;
							MtkDeviceInfo deviceInfo;
							if (doHandshake)
							{
								try
								{
									isBootloader = await MtkHandshakeService.DoHandshakeAsync(array[0], cancellationToken);
									_ = reconnect;
									deviceInfo = await MtkHandshakeService.GetDeviceInfoAsyncC(array[0], cancellationToken);
									reconnect = true;
								}
								catch (Exception projectError3)
								{
									ProjectData.SetProjectError(projectError3);
									array[0].Dispose();
									MtkTask.CHECK = "no";
									ProjectData.ClearProjectError();
									break;
								}
							}
							else
							{
								isBootloader = false;
								deviceInfo = new MtkDeviceInfo(0u, 0u, IsSecure: false, "", new MtkChipConfig());
							}
							return new MtkDeviceWaitResult(array[0], isBootloader, deviceInfo);
						}
						IMtkSerialDevice[] array2 = array;
						int num3 = array2.Length - 1;
						for (num2 = 0; num2 <= num3; num2++)
						{
							array2[num2].Dispose();
						}
						Thread.Sleep(1000);
					}
					else
					{
						Thread.Sleep(1000);
					}
					continue;
				}
				MtkTask.CHECK = "no";
				return null;
			}
			return null;
		}
	}

	public static async Task<MtkDeviceWaitResult> WaitSerialAsync5(bool doHandshake, CancellationToken cancellationToken)
	{
		MtkTask.CHECK = "";
		int num = -1;
		checked
		{
			while (true)
			{
				cancellationToken.ThrowIfCancellationRequested();
				int num2 = num + 1;
				num = num2;
				if (num == 180)
				{
					break;
				}
				IMtkSerialDevice[] array = await MtkSerialDeviceFinderService.FindAsync();
				if (array.Length != 0)
				{
					if (array.Length <= 1)
					{
						if (!reconnect)
						{
							com = array[0].ToString();
						}
						if (Operators.CompareString(MtkTask.Crashing, "OK", TextCompare: false) == 0)
						{
							try
							{
								await array[0].ConnectAsync();
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								array[0].Dispose();
								Console.WriteLine("Error connecting to mtk serial device");
								Thread.Sleep(1000);
								ProjectData.ClearProjectError();
								continue;
							}
						}
						else
						{
							try
							{
								await array[0].ConnectAsync();
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								array[0].Dispose();
								gui.Richlog("Failed Try Again", Color.Red);
								MtkTask.CHECK = "no";
								MtkDeviceWaitResult result = null;
								ProjectData.ClearProjectError();
								return result;
							}
						}
						bool isBootloader;
						MtkDeviceInfo deviceInfo;
						if (doHandshake)
						{
							try
							{
								isBootloader = await MtkHandshakeService.DoHandshakeAsync(array[0], cancellationToken);
								_ = reconnect;
								deviceInfo = await MtkHandshakeService.GetDeviceInfoAsyn(array[0], cancellationToken);
								reconnect = true;
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								array[0].Dispose();
								MtkTask.CHECK = "no";
								MtkDeviceWaitResult result = null;
								ProjectData.ClearProjectError();
								return result;
							}
						}
						else
						{
							isBootloader = false;
							deviceInfo = new MtkDeviceInfo(0u, 0u, IsSecure: false, "", new MtkChipConfig());
						}
						return new MtkDeviceWaitResult(array[0], isBootloader, deviceInfo);
					}
					IMtkSerialDevice[] array2 = array;
					int num3 = array2.Length - 1;
					for (num2 = 0; num2 <= num3; num2++)
					{
						array2[num2].Dispose();
					}
					Thread.Sleep(1000);
				}
				else
				{
					Thread.Sleep(1000);
				}
			}
			MtkTask.CHECK = "no";
			return null;
		}
	}

	public static async Task<MtkDeviceWaitResult> WaitSerialAsync6(bool doHandshake, CancellationToken cancellationToken)
	{
		_Closure_0024__6_002D0 arg = default(_Closure_0024__6_002D0);
		_Closure_0024__6_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__6_002D0(arg);
		MtkTask.Timeout = true;
		MtkTask.CHECK = "";
		CS_0024_003C_003E8__locals0._0024VB_0024Local_current = 0;
		int num = 100;
		checked
		{
			while (CS_0024_003C_003E8__locals0._0024VB_0024Local_current < num)
			{
				cancellationToken.ThrowIfCancellationRequested();
				CS_0024_003C_003E8__locals0._0024VB_0024Local_current++;
				Form1.SharedUI.ProgressBar4.Invoke((Action)([SpecialName] () =>
				{
					Form1.SharedUI.ProgressBar4.Value = CS_0024_003C_003E8__locals0._0024VB_0024Local_current;
				}));
				string text = Conversions.ToString(Form1.SharedUI.ProgressBar4.Value);
				Form1.SharedUI.ProgressBar4.Text = "Wait For Device.." + text + "%";
				IMtkSerialDevice[] array = await MtkSerialDeviceFinderService.FindAsync();
				if (array.Length != 0)
				{
					if (array.Length == 1)
					{
						if (!reconnect)
						{
							com = array[0].ToString();
						}
						try
						{
							await array[0].ConnectAsync();
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							array[0].Dispose();
							gui.Richlog("Failed Try Again", Color.Red);
							MtkTask.CHECK = "no";
							MtkDeviceWaitResult result = null;
							ProjectData.ClearProjectError();
							return result;
						}
						if (doHandshake)
						{
							try
							{
								bool isBootloader = await MtkHandshakeService.DoHandshakeAsync(array[0], cancellationToken);
								MtkDeviceInfo deviceInfo = await MtkHandshakeService.GetDeviceInfoAsyn(array[0], cancellationToken);
								reconnect = true;
								return new MtkDeviceWaitResult(array[0], isBootloader, deviceInfo);
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								array[0].Dispose();
								MtkTask.CHECK = "no";
								MtkDeviceWaitResult result = null;
								ProjectData.ClearProjectError();
								return result;
							}
						}
						return new MtkDeviceWaitResult(array[0], IsBootloader: false, new MtkDeviceInfo(0u, 0u, IsSecure: false, "", new MtkChipConfig()));
					}
					IMtkSerialDevice[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						array2[i].Dispose();
					}
					await Task.Delay(1000);
				}
				else
				{
					await Task.Delay(1000);
				}
			}
			MtkTask.Timeout = false;
			return null;
		}
	}

	public static async Task<MtkDeviceWaitResult> WaitSerialAsync3(bool doHandshake, CancellationToken cancellationToken)
	{
		MtkTask.CHECK = "";
		int num = -1;
		checked
		{
			while (true)
			{
				cancellationToken.ThrowIfCancellationRequested();
				int num2 = num + 1;
				num = num2;
				if (num == 180)
				{
					break;
				}
				IMtkSerialDevice[] array = await MtkSerialDeviceFinderService.FindAsync();
				if (array.Length != 0)
				{
					if (array.Length <= 1)
					{
						if (!reconnect)
						{
							com = array[0].ToString();
						}
						if (Operators.CompareString(MtkTask.Crashing, "OK", TextCompare: false) == 0)
						{
							try
							{
								await array[0].ConnectAsync();
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								array[0].Dispose();
								Thread.Sleep(1000);
								ProjectData.ClearProjectError();
								continue;
							}
						}
						else
						{
							try
							{
								await array[0].ConnectAsync();
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								array[0].Dispose();
								gui.Richlog("Failed Try Again", Color.Red);
								MtkTask.CHECK = "no";
								MtkDeviceWaitResult result = null;
								ProjectData.ClearProjectError();
								return result;
							}
						}
						bool isBootloader;
						MtkDeviceInfo deviceInfo;
						if (doHandshake)
						{
							try
							{
								isBootloader = await MtkHandshakeService.DoHandshakeAsync(array[0], cancellationToken);
								_ = reconnect;
								deviceInfo = await MtkHandshakeService.GetDeviceInfoAsyncC(array[0], cancellationToken);
								reconnect = true;
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								array[0].Dispose();
								MtkTask.CHECK = "no";
								MtkDeviceWaitResult result = null;
								ProjectData.ClearProjectError();
								return result;
							}
						}
						else
						{
							isBootloader = false;
							deviceInfo = new MtkDeviceInfo(0u, 0u, IsSecure: false, "", new MtkChipConfig());
						}
						return new MtkDeviceWaitResult(array[0], isBootloader, deviceInfo);
					}
					IMtkSerialDevice[] array2 = array;
					int num3 = array2.Length - 1;
					for (num2 = 0; num2 <= num3; num2++)
					{
						array2[num2].Dispose();
					}
					Thread.Sleep(1000);
				}
				else
				{
					Thread.Sleep(1000);
				}
			}
			MtkTask.CHECK = "no";
			return null;
		}
	}

	public static async Task<MtkDeviceWaitResult> WaitSerialAsync4(bool doHandshake, CancellationToken cancellationToken)
	{
		MtkTask.CHECK = "";
		int num = -1;
		checked
		{
			while (true)
			{
				cancellationToken.ThrowIfCancellationRequested();
				int num2 = num + 1;
				num = num2;
				if (num == 180)
				{
					break;
				}
				IMtkSerialDevice[] array = await MtkSerialDeviceFinderService.FindAsync();
				if (array.Length != 0)
				{
					if (array.Length <= 1)
					{
						if (!reconnect)
						{
							com = array[0].ToString();
						}
						if (Operators.CompareString(MtkTask.Crashing, "OK", TextCompare: false) == 0)
						{
							try
							{
								await array[0].ConnectAsync();
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								array[0].Dispose();
								Thread.Sleep(1000);
								ProjectData.ClearProjectError();
								continue;
							}
						}
						else
						{
							try
							{
								await array[0].ConnectAsync();
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								array[0].Dispose();
								gui.Richlog("Failed Try Again", Color.Red);
								MtkTask.CHECK = "no";
								MtkDeviceWaitResult result = null;
								ProjectData.ClearProjectError();
								return result;
							}
						}
						bool isBootloader;
						MtkDeviceInfo deviceInfo;
						if (doHandshake)
						{
							try
							{
								isBootloader = await MtkHandshakeService.DoHandshakeAsync(array[0], cancellationToken);
								_ = reconnect;
								deviceInfo = await MtkHandshakeService.GetDeviceInfoAsyncC(array[0], cancellationToken);
								reconnect = true;
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								array[0].Dispose();
								MtkTask.CHECK = "no";
								MtkDeviceWaitResult result = null;
								ProjectData.ClearProjectError();
								return result;
							}
						}
						else
						{
							isBootloader = false;
							deviceInfo = new MtkDeviceInfo(0u, 0u, IsSecure: false, "", new MtkChipConfig());
						}
						return new MtkDeviceWaitResult(array[0], isBootloader, deviceInfo);
					}
					IMtkSerialDevice[] array2 = array;
					int num3 = array2.Length - 1;
					for (num2 = 0; num2 <= num3; num2++)
					{
						array2[num2].Dispose();
					}
					Thread.Sleep(1000);
				}
				else
				{
					Thread.Sleep(1000);
				}
			}
			MtkTask.CHECK = "no";
			return null;
		}
	}

	public static async Task<MtkDeviceWaitResult> WaitUsbAsync(bool doHandshake, CancellationToken cancellationToken)
	{
		MtkTask.CHECK = "";
		int num = -1;
		checked
		{
			IMtkUsbDevice[] array;
			bool isBootloader;
			MtkDeviceInfo deviceInfo;
			while (true)
			{
				cancellationToken.ThrowIfCancellationRequested();
				int num2 = num + 1;
				num = num2;
				if (num != 180)
				{
					array = await MtkUsbDeviceFinderService.FindAsync();
					if (array.Length == 0)
					{
						Thread.Sleep(1000);
						continue;
					}
					if (array.Length > 1)
					{
						IMtkUsbDevice[] array2 = array;
						int num3 = array2.Length - 1;
						for (num2 = 0; num2 <= num3; num2++)
						{
							array2[num2].Dispose();
						}
						Thread.Sleep(1000);
						continue;
					}
					if (!reconnect)
					{
						gui.Richlog(array[0].ToString(), Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					}
					if (Operators.CompareString(MtkTask.Crashing, "OK", TextCompare: false) == 0)
					{
						try
						{
							await array[0].ConnectAsync();
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							array[0].Dispose();
							gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
							Thread.Sleep(1000);
							ProjectData.ClearProjectError();
							continue;
						}
					}
					else
					{
						try
						{
							await array[0].ConnectAsync();
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							array[0].Dispose();
							gui.Richlog("Failed Try Again", Color.Red);
							MtkTask.CHECK = "no";
							MtkDeviceWaitResult result = null;
							ProjectData.ClearProjectError();
							return result;
						}
					}
					if (doHandshake)
					{
						try
						{
							isBootloader = await MtkHandshakeService.DoHandshakeAsync(array[0], cancellationToken);
							deviceInfo = await MtkHandshakeService.GetDeviceInfoAsyncC(array[0], cancellationToken);
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							array[0].Dispose();
							MtkTask.CHECK = "no";
							MtkDeviceWaitResult result = null;
							ProjectData.ClearProjectError();
							return result;
						}
					}
					else
					{
						isBootloader = false;
						deviceInfo = new MtkDeviceInfo(0u, 0u, IsSecure: false, "", new MtkChipConfig());
					}
					break;
				}
				MtkTask.CHECK = "no";
				return null;
			}
			return new MtkDeviceWaitResult(array[0], isBootloader, deviceInfo);
		}
	}
}
