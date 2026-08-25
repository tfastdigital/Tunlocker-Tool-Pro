using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.mtkclient2.MTK.Client;

namespace motoulocked.mtkclient2.library.xflash;

internal class MtkCustomWrite
{
	public static async Task<bool> writeBoot(IMtkDevice device, MtkDaxFlashInfo flashInfo, string partname, byte[] v, CancellationToken cancellationToken)
	{
		checked
		{
			bool result;
			if (!(await utils.send00000(device, cancellationToken, 16, "Write Part format", "09 00 01 00", "100")))
			{
				result = false;
			}
			else if (!(await utils.send00000(device, cancellationToken, 16, "Write Part format", "07 00 04 00", "100")))
			{
				result = false;
			}
			else
			{
				utils.BytesToHextring(await utils.readmtk(device, cancellationToken, "20"));
				int num = flashInfo.WriteBufferSize;
				utils.BytesToHextring(await utils.readmtk(device, cancellationToken, "16"));
				if (!(await utils.send00000(device, cancellationToken, 16, "Write byname 2", "01 00 01 00", "100")))
				{
					result = false;
				}
				else
				{
					string text = utils.penggenapan4belakang(Convert.ToString(partname.Length, 16).ToUpper());
					byte[] data = utils.HexStringToBytes("EF EE EE FE 01 00 00 00 " + text);
					await utils.writemtk(device, cancellationToken, data);
					data = Encoding.UTF8.GetBytes(partname);
					await utils.writemtk(device, cancellationToken, data);
					int num2 = v.Length;
					data = utils.HexStringToBytes(utils.penggenapan8(utils.penggenapan4belakang(utils.applyshiftKiri2(Convert.ToString(num2, 16).ToUpper()))));
					await utils.xsend8(device, cancellationToken, data);
					await Task.Delay(TimeSpan.FromMilliseconds(100.0));
					utils.BytesToHextring(await utils.readmtk(device, cancellationToken, "16"));
					if (num2 <= num)
					{
						num = num2;
					}
					using (MemoryStream memoryStream = new MemoryStream(v))
					{
						int num3 = 0;
						Stopwatch stopwatch = new Stopwatch();
						stopwatch.Start();
						while (true)
						{
							if (!cancellationToken.IsCancellationRequested)
							{
								if (num2 == num3)
								{
									break;
								}
								if (num2 - num3 < num)
								{
									num = num2 - num3;
									byte[] array = new byte[num - 1 + 1 - 1 + 1];
									await memoryStream.ReadAsync(array, 0, num);
									string text2 = utils.penggenapan4belakang(utils.applyshiftKiri2(Convert.ToString(num, 16).ToUpper()));
									string s = sumarray(array);
									data = utils.HexStringToBytes("EF EE EE FE 01 00 00 00 04 00 00 00");
									await utils.writemtk(device, cancellationToken, data);
									data = utils.HexStringToBytes("00 00 00 00");
									await utils.writemtk(device, cancellationToken, data);
									data = utils.HexStringToBytes("EF EE EE FE 01 00 00 00 04 00 00 00");
									await utils.writemtk(device, cancellationToken, data);
									data = utils.HexStringToBytes(s);
									await utils.writemtk(device, cancellationToken, data);
									data = utils.HexStringToBytes("EF EE EE FE 01 00 00 00 " + text2);
									await utils.writemtk(device, cancellationToken, data);
									await utils.writemtk(device, cancellationToken, array);
									num3 += array.Length;
									_ = (double)num3 / stopwatch.Elapsed.TotalSeconds;
									Form1.ProcessBar(num3, num2);
									await Task.Delay(TimeSpan.FromMilliseconds(100.0));
								}
								else
								{
									byte[] array2 = new byte[num - 1 + 1 - 1 + 1];
									await memoryStream.ReadAsync(array2, 0, num);
									string text3 = utils.penggenapan4belakang(utils.applyshiftKiri2(Convert.ToString(num, 16).ToUpper()));
									string s2 = sumarray(array2);
									data = utils.HexStringToBytes("EF EE EE FE 01 00 00 00 04 00 00 00");
									await utils.writemtk(device, cancellationToken, data);
									data = utils.HexStringToBytes("00 00 00 00");
									await utils.writemtk(device, cancellationToken, data);
									data = utils.HexStringToBytes("EF EE EE FE 01 00 00 00 04 00 00 00");
									await utils.writemtk(device, cancellationToken, data);
									data = utils.HexStringToBytes(s2);
									await utils.writemtk(device, cancellationToken, data);
									data = utils.HexStringToBytes("EF EE EE FE 01 00 00 00 " + text3);
									await utils.writemtk(device, cancellationToken, data);
									await utils.writemtk(device, cancellationToken, array2);
									num3 += array2.Length;
									_ = (double)num3 / stopwatch.Elapsed.TotalSeconds;
									Form1.ProcessBar(num3, num2);
									await Task.Delay(TimeSpan.FromMilliseconds(50.0));
								}
								continue;
							}
							stopwatch.Stop();
							return true;
						}
						stopwatch.Stop();
						memoryStream.Close();
					}
					await Task.Delay(TimeSpan.FromMilliseconds(100.0));
					string text4 = utils.BytesToHextring(await utils.readmtk(device, cancellationToken, "16"));
					if (Operators.CompareString(text4.Substring(text4.Length - 8), "00000000", TextCompare: false) != 0)
					{
						if ((Operators.CompareString(partname, "preloader", TextCompare: false) == 0 || Operators.CompareString(partname, "preloader_backup", TextCompare: false) == 0) && Operators.CompareString(text4.Substring(text4.Length - 8), "010001c0", TextCompare: false) == 0)
						{
							utils.BytesToHextring(await utils.readmtk(device, cancellationToken, "16"));
							result = true;
						}
						else
						{
							gui.logs("error " + text4.Substring(text4.Length - 8), newline: true);
							result = false;
						}
					}
					else
					{
						text4 = utils.BytesToHextring(await utils.readmtk(device, cancellationToken, "16"));
						if (Operators.CompareString(text4.Substring(text4.Length - 8), "00000000", TextCompare: false) != 0)
						{
							if ((Operators.CompareString(partname, "preloader", TextCompare: false) == 0 || Operators.CompareString(partname, "preloader_backup", TextCompare: false) == 0) && Operators.CompareString(text4.Substring(text4.Length - 8), "010001c0", TextCompare: false) == 0)
							{
								utils.BytesToHextring(await utils.readmtk(device, cancellationToken, "16"));
								result = true;
							}
							else
							{
								gui.logs("error " + text4.Substring(text4.Length - 8), newline: true);
								result = false;
							}
						}
						else
						{
							if (Operators.CompareString(partname, "preloader_backup", TextCompare: false) == 0)
							{
								await utils.send00000(device, cancellationToken, 16, "swi2", "09 00 01 00", "100");
								await utils.send00000(device, cancellationToken, 16, "swi 3", "09 00 04 00", "100");
								await utils.readmtk(device, cancellationToken, "16");
								await utils.readmtk(device, cancellationToken, "16");
								await utils.readmtk(device, cancellationToken, "16");
							}
							await Task.Delay(TimeSpan.FromMilliseconds(1000.0));
							result = true;
						}
					}
				}
			}
			return result;
		}
	}

	public static async Task<bool> Read_RPMP(IMtkDevice device, CancellationToken cancellationToken)
	{
		byte[] data = utils.HexStringToBytes("EF EE EE FE 01 00 00 00 04 00 00 00");
		await utils.writemtk(device, cancellationToken, data);
		data = utils.HexStringToBytes("04 00 0C 00");
		await utils.writemtk(device, cancellationToken, data);
		utils.BytesToHextring(await utils.readmtk(device, cancellationToken, "0"));
		data = utils.HexStringToBytes("EF EE EE FE 01 00 00 00 04 00 00 00");
		await utils.writemtk(device, cancellationToken, data);
		data = utils.HexStringToBytes("c2 00 00 00");
		await utils.writemtk(device, cancellationToken, data);
		data = utils.HexStringToBytes("EF EE EE FE 01 00 00 00 04 00 00 00");
		await utils.writemtk(device, cancellationToken, data);
		data = utils.HexStringToBytes("02 00 0C 00");
		await utils.writemtk(device, cancellationToken, data);
		utils.BytesToHextring(await utils.readmtk(device, cancellationToken, "0"));
		Thread.Sleep(10);
		string text = utils.BytesToHextring(await utils.readmtk(device, cancellationToken, "0"));
		int yangdi_skip = 0;
		utils.skipoffset(new string[3] { "49", "4D", "45" }, ref yangdi_skip, text);
		checked
		{
			gui.Richlog("IMEI 1 : " + Encoding.UTF8.GetString(utils.HexStringToBytes(text.Substring(yangdi_skip + 10, 30))), Color.Black, isBold: false, NextLine: true);
			gui.Richlog("IMEI 2 : " + Encoding.UTF8.GetString(utils.HexStringToBytes(text.Substring(yangdi_skip + 54, 30))), Color.Black, isBold: false, NextLine: true);
			bool result = default(bool);
			return result;
		}
	}

	public static async Task<bool> writeByPartitionName(IMtkDevice device, MtkDaxFlashInfo flashInfo, string partname, string v, CancellationToken cancellationToken)
	{
		bool result;
		if (!(await utils.send00000(device, cancellationToken, 16, "Write Part format", "09 00 01 00", "100")))
		{
			result = false;
		}
		else if (!(await utils.send00000(device, cancellationToken, 16, "Write byname 1", "07 00 04 00", "100")))
		{
			result = false;
		}
		else
		{
			utils.BytesToHextring(await utils.readmtk(device, cancellationToken, "20"));
			int writeBufferSize = flashInfo.WriteBufferSize;
			utils.BytesToHextring(await utils.readmtk(device, cancellationToken, "16"));
			if (!(await utils.send00000(device, cancellationToken, 16, "Write byname 2", "01 00 01 00", "100")))
			{
				result = false;
			}
			else
			{
				string text = utils.penggenapan4belakang(Convert.ToString(partname.Length, 16).ToUpper());
				byte[] data = utils.HexStringToBytes("EF EE EE FE 01 00 00 00 " + text);
				await utils.writemtk(device, cancellationToken, data);
				data = Encoding.UTF8.GetBytes(partname);
				await utils.writemtk(device, cancellationToken, data);
				data = utils.HexStringToBytes(utils.penggenapan8(utils.penggenapan4belakang(utils.applyshiftKiri2(Convert.ToString(new FileInfo(v).Length, 16).ToUpper()))));
				await utils.xsend8(device, cancellationToken, data);
				await Task.Delay(TimeSpan.FromMilliseconds(100.0));
				utils.BytesToHextring(await utils.readmtk(device, cancellationToken, "16"));
				result = await WriteUnsparseAsync(device, cancellationToken, v, writeBufferSize);
			}
		}
		return result;
	}

	public static async Task<bool> WriteUnsparseAsync(IMtkDevice device, CancellationToken cancellationToken, string v, long pktlen)
	{
		FileInfo fileInfo = new FileInfo(v);
		if (fileInfo.Length <= pktlen)
		{
			pktlen = fileInfo.Length;
		}
		checked
		{
			using (FileStream fileStream = new FileStream(v, FileMode.Open))
			{
				long num = 0L;
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				while (true)
				{
					if (!cancellationToken.IsCancellationRequested)
					{
						if (fileInfo.Length == num)
						{
							break;
						}
						if (fileInfo.Length - num < pktlen)
						{
							pktlen = fileInfo.Length - num;
							byte[] array = new byte[(int)(pktlen - 1) + 1 - 1 + 1];
							await fileStream.ReadAsync(array, 0, (int)pktlen);
							string text = utils.penggenapan4belakang(utils.applyshiftKiri2(Convert.ToString(pktlen, 16).ToUpper()));
							string s = sumarray(array);
							byte[] data = utils.HexStringToBytes("EF EE EE FE 01 00 00 00 04 00 00 00");
							await utils.writemtk(device, cancellationToken, data);
							data = utils.HexStringToBytes("00 00 00 00");
							await utils.writemtk(device, cancellationToken, data);
							data = utils.HexStringToBytes("EF EE EE FE 01 00 00 00 04 00 00 00");
							await utils.writemtk(device, cancellationToken, data);
							data = utils.HexStringToBytes(s);
							await utils.writemtk(device, cancellationToken, data);
							data = utils.HexStringToBytes("EF EE EE FE 01 00 00 00 " + text);
							await utils.writemtk(device, cancellationToken, data);
							await utils.writemtk(device, cancellationToken, array);
							num += array.Length;
							_ = (double)num / stopwatch.Elapsed.TotalSeconds;
							Form1.ProcessBar(num, fileInfo.Length);
							await Task.Delay(TimeSpan.FromMilliseconds(100.0));
							utils.BytesToHextring(await utils.readmtk(device, cancellationToken, "16"));
						}
						else
						{
							byte[] array2 = new byte[(int)(pktlen - 1) + 1 - 1 + 1];
							await fileStream.ReadAsync(array2, 0, (int)pktlen);
							string text2 = utils.penggenapan4belakang(utils.applyshiftKiri2(Convert.ToString(pktlen, 16).ToUpper()));
							string s2 = sumarray(array2);
							byte[] data2 = utils.HexStringToBytes("EF EE EE FE 01 00 00 00 04 00 00 00");
							await utils.writemtk(device, cancellationToken, data2);
							data2 = utils.HexStringToBytes("00 00 00 00");
							await utils.writemtk(device, cancellationToken, data2);
							data2 = utils.HexStringToBytes("EF EE EE FE 01 00 00 00 04 00 00 00");
							await utils.writemtk(device, cancellationToken, data2);
							data2 = utils.HexStringToBytes(s2);
							await utils.writemtk(device, cancellationToken, data2);
							data2 = utils.HexStringToBytes("EF EE EE FE 01 00 00 00 " + text2);
							await utils.writemtk(device, cancellationToken, data2);
							await utils.writemtk(device, cancellationToken, array2);
							num += array2.Length;
							_ = (double)num / stopwatch.Elapsed.TotalSeconds;
							Form1.ProcessBar(num, fileInfo.Length);
							await Task.Delay(TimeSpan.FromMilliseconds(100.0));
							utils.BytesToHextring(await utils.readmtk(device, cancellationToken, "16"));
						}
						continue;
					}
					stopwatch.Stop();
					return true;
				}
				stopwatch.Stop();
				fileStream.Close();
			}
			await Task.Delay(TimeSpan.FromMilliseconds(100.0));
			string text3 = utils.BytesToHextring(await utils.readmtk(device, cancellationToken, "16"));
			bool result;
			if (Operators.CompareString(text3.Substring(text3.Length - 8), "00000000", TextCompare: false) != 0)
			{
				gui.logs("error " + text3.Substring(text3.Length - 8), newline: true);
				result = false;
			}
			else
			{
				await Task.Delay(TimeSpan.FromMilliseconds(1000.0));
				result = true;
			}
			return result;
		}
	}

	public static async Task<bool> ForMatBoot(IMtkDevice device, string starsec, string lensec, CancellationToken cancellationToken)
	{
		checked
		{
			bool result;
			try
			{
				string ptype = "boot1";
				if (!(await utils.send00000(device, cancellationToken, 16, "cmd format 1", "09 00 01 00", "100")))
				{
					result = false;
				}
				else if (!(await utils.send00000(device, cancellationToken, 16, "cmd format 2", "07 00 04 00", "100")))
				{
					result = false;
				}
				else
				{
					utils.BytesToHextring(await utils.readmtk(device, cancellationToken, "20"));
					utils.BytesToHextring(await utils.readmtk(device, cancellationToken, "16"));
					byte[] data = cmdformat(ptype, Convert.ToString(Convert.ToInt64(starsec), 16).ToUpper(), Convert.ToString(Convert.ToInt64(lensec), 16).ToUpper());
					if (!(await utils.send00000(device, cancellationToken, 16, "cmd format 3", "03 00 01 00", "100")))
					{
						result = false;
					}
					else
					{
						byte[] data2 = utils.HexStringToBytes("EF EE EE FE 01 00 00 00 38 00 00 00");
						await utils.writemtk(device, cancellationToken, data2);
						await utils.writemtk(device, cancellationToken, data);
						await Task.Delay(TimeSpan.FromMilliseconds(100.0));
						string text = utils.BytesToHextring(await utils.readmtk(device, cancellationToken, "16"));
						if (Operators.CompareString(text.Substring(text.Length - 6), "000000", TextCompare: false) != 0)
						{
							gui.logs("Error 0x: " + utils.applyshiftKiri2(text.Substring(text.Length - 6)), newline: true);
							result = false;
						}
						else
						{
							await Task.Delay(TimeSpan.FromMilliseconds(1000.0));
							result = true;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.ToString());
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public static byte[] cmdformat(string ptype, string starsec, string leng)
	{
		string text = "01 00 00 00";
		string text2 = "";
		if (Operators.CompareString(ptype.ToLower(), "boot1", TextCompare: false) == 0)
		{
			text2 = "01 00 00 00";
		}
		else if (Operators.CompareString(ptype, "userarea", TextCompare: false) == 0)
		{
			text2 = "08 00 00 00";
		}
		string text3 = utils.penggenapan8(utils.applyshiftKiri2(starsec));
		string text4 = utils.penggenapan8(utils.applyshiftKiri2(leng));
		string text5 = "00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
		string text6 = "00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
		return utils.HexStringToBytes(text + text2 + text3 + text4 + text5 + text6);
	}

	public static string sumarray(byte[] data)
	{
		int num = 0;
		checked
		{
			int num2 = data.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				num += data[i];
			}
			string text = utils.DecimalToHexadecimal(num);
			if (text.Length > 4)
			{
				return utils.penggenapan4belakang(utils.applyshiftKiri2(text.Substring(text.Length - 4)));
			}
			return utils.penggenapan4belakang(utils.applyshiftKiri2(text));
		}
	}
}
