using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.motoulocked;
using motoulocked.mtkclient2.MTK.Client.Scatter;
using motoulocked.mtkclient2.Tasks;

namespace motoulocked.mtkclient2.library.xflash;

internal class MtkHandshakeService
{
	public static async Task<bool> DoHandshakeAsync(IMtkDevice device, CancellationToken cancellationToken)
	{
		byte[] array = new byte[4] { 160, 10, 80, 5 };
		bool result = false;
		int num = 0;
		int num2 = 0;
		while (num2 < array.Length)
		{
			Console.WriteLine("Sending handshake: index={0}; char=0x{1:X2}", num2, array[num2]);
			await device.WriteAsync(array, num2, 1, cancellationToken);
			byte b = await MtkDeviceExtension.ReadByteAsync(device, cancellationToken);
			if (b == 82)
			{
				Console.WriteLine("Consuming EADY");
				byte[] array2 = new byte[4];
				await MtkDeviceExtension.ReadExactAsync(device, array2, 0, array2.Length, cancellationToken);
				string @string = Encoding.ASCII.GetString(array2);
				if (Operators.CompareString(@string, "EADY", TextCompare: false) != 0)
				{
					Console.WriteLine("Invalid sync EADY: " + @string);
				}
				num2 = -1;
				result = true;
			}
			else if (b != (byte)(~array[num2]))
			{
				if (num >= 100)
				{
					Console.WriteLine($"Invalid sync response at {num2}: 0x{(byte)(~array[num2]):X2} vs 0x{b:X2}");
				}
				checked
				{
					_ = num + 1;
					_ = num2 - 1;
					break;
				}
			}
			int num3 = checked(num2 + 1);
			num2 = num3;
		}
		return result;
	}

	public static async Task<MtkDeviceInfo> GetDeviceInfoAsyncC(IMtkDevice device, CancellationToken cancellationToken)
	{
		Form1.SharedUI.ProgressBar1.Text = "Analyzeing...";
		await MtkDeviceExtension.EchoAsync(device, 253, cancellationToken);
		TaskAwaiter<ushort> taskAwaiter = MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken).GetAwaiter();
		if (!taskAwaiter.IsCompleted)
		{
			//await taskAwaiter;
			TaskAwaiter<ushort> taskAwaiter2 = default(TaskAwaiter<ushort>);
			taskAwaiter = taskAwaiter2;
		}
		ushort result = taskAwaiter.GetResult();
		await MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken);
		MtkChipConfig mtkChipConfig = MtkChipConfig.ChipConfigs.Where([SpecialName] (MtkChipConfig x) => x.HardwareCode == result).FirstOrDefault();
		if ((object)mtkChipConfig != null)
		{
			await MtkDeviceExtension.EchoAsync(device, 252, cancellationToken);
			await MtkDeviceExtension.ReadWordAsync(device, little: false, cancellationToken);
			ushort hardwareVersion = await MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken);
			ushort softwareVersion = await MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken);
			await MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken);
			if (!MtkDeviceWaiterService.reconnect)
			{
				gui.Richlog("Mediatek USB Port (" + MtkDeviceWaiterService.com + ")", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Chipset : ", Color.Black);
				string name = mtkChipConfig.Name;
				if (name.Contains("/"))
				{
					Mediatek.Platform = name.Split("/".ToCharArray())[0];
				}
				else
				{
					Mediatek.Platform = name;
				}
			}
			if (!MtkDeviceWaiterService.reconnect)
			{
				Mediatek.basebandmtk = result.ToString("X4") + ":8A00:" + hardwareVersion.ToString("X4") + ":" + softwareVersion.ToString("X4");
				gui.Richlog(Mediatek.basebandmtk.ToUpper(), Color.FromArgb(21, 87, 255));
				gui.Richlog("[" + Mediatek.Platform + "]", Color.LightGreen, isBold: false, NextLine: true);
			}
			await MtkDeviceExtension.EchoAsync(device, 216, cancellationToken);
			uint num = await MtkDeviceExtension.ReadDwordAsync(device, little: true, cancellationToken);
			await MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken);
			bool flag = Convert.ToBoolean(num & 1u);
			bool flag2 = Convert.ToBoolean(num & 2u);
			bool flag3 = Convert.ToBoolean(num & 4u);
			bool isSecure = flag2 || flag3;
			string securityLevel = "NON_SECURE";
			if (flag || flag2 || flag3)
			{
				List<string> list = new List<string>();
				if (flag)
				{
					list.Add("SBC");
				}
				if (flag2)
				{
					list.Add("SLA");
				}
				if (flag3)
				{
					list.Add("SDA");
				}
				MtkTask.SBC = false;
				MtkTask.SLA = false;
				MtkTask.SDA = false;
				if (!MtkDeviceWaiterService.reconnect)
				{
					if (flag && flag2 && flag3)
					{
						MtkTask.SBC = true;
						MtkTask.SLA = true;
						MtkTask.SDA = true;
					}
					else if (flag && flag2)
					{
						MtkTask.SBC = true;
						MtkTask.SLA = true;
					}
					else if (flag2 && flag3)
					{
						MtkTask.SLA = true;
						MtkTask.SDA = true;
					}
					else if (flag && flag3)
					{
						MtkTask.SBC = true;
						MtkTask.SDA = true;
					}
					else if (flag)
					{
						MtkTask.SBC = true;
					}
					else if (flag2)
					{
						MtkTask.SLA = true;
					}
					else if (flag3)
					{
						MtkTask.SDA = true;
					}
				}
				securityLevel = string.Join("+", list);
			}
			return new MtkDeviceInfo(hardwareVersion, softwareVersion, isSecure, securityLevel, mtkChipConfig);
		}
		MtkTask.CHECK = "not";
		return null;
	}

	public static async Task<MtkDeviceInfo> GetDeviceInfoAsyn(IMtkDevice device, CancellationToken cancellationToken)
	{
		Form1.SharedUI.ProgressBar1.Text = "Analyzeing...";
		SerialCOM.MSL = "DISREAD";
		Form1.SharedUI.ProgressBar4.Text = "";
		Form1.SharedUI.ProgressBar4.Value = 0;
		await MtkDeviceExtension.EchoAsync(device, 253, cancellationToken);
		TaskAwaiter<ushort> taskAwaiter = MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken).GetAwaiter();
		if (!taskAwaiter.IsCompleted)
		{
			//await taskAwaiter;
			TaskAwaiter<ushort> taskAwaiter2 = default(TaskAwaiter<ushort>);
			taskAwaiter = taskAwaiter2;
		}
		ushort result = taskAwaiter.GetResult();
		await MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken);
		MtkChipConfig mtkChipConfig = MtkChipConfig.ChipConfigs.Where([SpecialName] (MtkChipConfig x) => x.HardwareCode == result).FirstOrDefault();
		if ((object)mtkChipConfig != null)
		{
			await MtkDeviceExtension.EchoAsync(device, 252, cancellationToken);
			await MtkDeviceExtension.ReadWordAsync(device, little: false, cancellationToken);
			ushort hardwareVersion = await MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken);
			ushort softwareVersion = await MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken);
			await MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken);
			if (!MtkDeviceWaiterService.reconnect)
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- BootMode : ", Color.Black);
				gui.Richlog("BootROM [" + MtkDeviceWaiterService.com + "]", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Chip Name : ", Color.Black);
				string name = mtkChipConfig.Name;
				if (name.Contains("/"))
				{
					Mediatek.Platform = name.Split("/".ToCharArray())[0];
				}
				else
				{
					Mediatek.Platform = name;
				}
				gui.Richlog(Mediatek.Platform, Color.Green, isBold: false, NextLine: true);
			}
			if (!MtkDeviceWaiterService.reconnect)
			{
				gui.Richlog("- Chip Info : ", Color.Black);
				gui.Richlog(result.ToString("X4").ToLower() + "_8a00_" + hardwareVersion.ToString("X4").ToLower(), Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
				Mediatek.basebandmtk = result.ToString("X4").ToLower() + "_8a00_" + hardwareVersion.ToString("X4").ToLower();
			}
			await MtkDeviceExtension.EchoAsync(device, 216, cancellationToken);
			uint num = await MtkDeviceExtension.ReadDwordAsync(device, little: true, cancellationToken);
			await MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken);
			bool flag = Convert.ToBoolean(num & 1u);
			bool flag2 = Convert.ToBoolean(num & 2u);
			bool flag3 = Convert.ToBoolean(num & 4u);
			bool isSecure = flag2 || flag3;
			string securityLevel = "NON_SECURE";
			if (flag || flag2 || flag3)
			{
				List<string> list = new List<string>();
				if (flag)
				{
					list.Add("SBC");
				}
				if (flag2)
				{
					list.Add("SLA");
				}
				if (flag3)
				{
					list.Add("SDA");
				}
				if (!MtkDeviceWaiterService.reconnect)
				{
					gui.Richlog("- Brom Security : [", Color.Black);
					if (flag && flag2 && flag3)
					{
						gui.Richlog("SBC", Color.Green);
						gui.Richlog("-SLA", Color.Green);
						gui.Richlog("-SDA", Color.Green);
						gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
					}
					else if (flag && flag2)
					{
						gui.Richlog("SBC", Color.Green);
						gui.Richlog("-SLA", Color.Green);
						gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
					}
					else if (flag2 && flag3)
					{
						gui.Richlog("SLA", Color.Green);
						gui.Richlog("-SDA", Color.Green);
						gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
					}
					else if (flag && flag3)
					{
						gui.Richlog("SBC", Color.Green);
						gui.Richlog("-SDA", Color.Green);
						gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
					}
					else if (flag)
					{
						gui.Richlog("SBC", Color.Green);
						gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
					}
					else if (flag2)
					{
						gui.Richlog("SLA", Color.Green);
						gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
					}
					else if (flag3)
					{
						gui.Richlog("SDA", Color.Green);
						gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
					}
					else
					{
						gui.Richlog("Nothing", Color.Red);
						gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
					}
				}
				securityLevel = string.Join("+", list);
			}
			return new MtkDeviceInfo(hardwareVersion, softwareVersion, isSecure, securityLevel, mtkChipConfig);
		}
		MtkTask.CHECK = "not";
		return null;
	}

	public static async Task<MtkDeviceInfo> GetDeviceInfoAsync(IMtkDevice device, CancellationToken cancellationToken)
	{
		await MtkDeviceExtension.EchoAsync(device, 253, cancellationToken);
		TaskAwaiter<ushort> taskAwaiter = MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken).GetAwaiter();
		if (!taskAwaiter.IsCompleted)
		{
			//await taskAwaiter;
			TaskAwaiter<ushort> taskAwaiter2 = default(TaskAwaiter<ushort>);
			taskAwaiter = taskAwaiter2;
		}
		ushort result = taskAwaiter.GetResult();
		await MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken);
		Form1.SharedUI.ProgressBar1.Text = "Analyzeing...";
		MtkChipConfig mtkChipConfig = MtkChipConfig.ChipConfigs.Where([SpecialName] (MtkChipConfig x) => x.HardwareCode == result).FirstOrDefault();
		if ((object)mtkChipConfig != null)
		{
			await MtkDeviceExtension.EchoAsync(device, 252, cancellationToken);
			await MtkDeviceExtension.ReadWordAsync(device, little: false, cancellationToken);
			ushort hardwareVersion = await MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken);
			ushort softwareVersion = await MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken);
			await MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken);
			if (!MtkDeviceWaiterService.reconnect)
			{
				gui.Richlog("- Chip Name : ", Color.Black);
				string name = mtkChipConfig.Name;
				if (name.Contains("/"))
				{
					Mediatek.Platform = name.Split("/".ToCharArray())[0];
				}
				else
				{
					Mediatek.Platform = name;
				}
				gui.Richlog(Mediatek.Platform, Color.Green, isBold: false, NextLine: true);
			}
			if (!MtkDeviceWaiterService.reconnect)
			{
				gui.Richlog("- Chip Info : ", Color.Black);
				gui.Richlog(result.ToString("X4").ToLower() + "_8a00_" + hardwareVersion.ToString("X4").ToLower(), Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				Mediatek.basebandmtk = result.ToString("X4").ToLower() + "_8a00_" + hardwareVersion.ToString("X4").ToLower();
			}
			await MtkDeviceExtension.EchoAsync(device, 216, cancellationToken);
			uint num = await MtkDeviceExtension.ReadDwordAsync(device, little: true, cancellationToken);
			await MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken);
			bool flag = Convert.ToBoolean(num & 1u);
			bool flag2 = Convert.ToBoolean(num & 2u);
			bool flag3 = Convert.ToBoolean(num & 4u);
			bool isSecure = flag2 || flag3;
			string securityLevel = "NON_SECURE";
			if (flag || flag2 || flag3)
			{
				List<string> list = new List<string>();
				if (flag)
				{
					if (!MtkDeviceWaiterService.reconnect)
					{
						gui.Richlog("- Brom Security : [", Color.Black);
						gui.Richlog("SBC", Color.Green);
					}
					list.Add("SBC");
				}
				if (flag2)
				{
					if (!MtkDeviceWaiterService.reconnect)
					{
						gui.Richlog("-SLA", Color.Green);
					}
					list.Add("SLA");
				}
				if (flag3)
				{
					if (!MtkDeviceWaiterService.reconnect)
					{
						gui.Richlog("-SDA", Color.Green);
						gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
					}
					list.Add("SDA");
				}
				securityLevel = string.Join("+", list);
			}
			return new MtkDeviceInfo(hardwareVersion, softwareVersion, isSecure, securityLevel, mtkChipConfig);
		}
		MessageBox.Show("Device Security Is Not Supported... Please Use Other Device!", "Info!", MessageBoxButtons.OK);
		return null;
	}
}
