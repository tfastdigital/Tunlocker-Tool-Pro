using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;
using Properties;

namespace motoulocked.motoulocked;

[StandardModule]
internal sealed class FIREHOSE_CONFIG
{
	public static bool sending_config()
	{
		FIREHOSE_MANAGER.isFirehoseReady = false;
		FIREHOSE_MANAGER.isFirehoseHasDoAuth = false;
		FIREHOSE_MANAGER.isEDLUnlockAutoReboot = false;
		if (Operators.CompareString(FIREHOSE_MANAGER.TypeMemory, "auto", TextCompare: false) == 0)
		{
			return auto_config();
		}
		if (Operators.CompareString(FIREHOSE_MANAGER.TypeMemory, "emmc", TextCompare: false) == 0)
		{
			FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = "512";
			FIREHOSE_MANAGER.MaxPayloadSizeToTargetInBytes = "8192";
			FIREHOSE_MANAGER.maxPayloadSizeFromTargetInBytes = "4096";
		}
		else
		{
			FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = "4096";
			FIREHOSE_MANAGER.MaxPayloadSizeToTargetInBytes = "1048576";
			FIREHOSE_MANAGER.maxPayloadSizeFromTargetInBytes = "4096";
		}
		FIREHOSE.FIREHOSE_CONFIG config = default(FIREHOSE.FIREHOSE_CONFIG);
		config.Version = 4;
		config.MemoryName = FIREHOSE_MANAGER.TypeMemory;
		config.SkipWrite = 0;
		config.ZLPAwareHost = 1;
		config.SkipStorageInit = 0;
		config.ActivePartition = 0;
		config.MaxPayloadSizeToTargetInBytes = FIREHOSE_MANAGER.MaxPayloadSizeToTargetInBytes;
		config.AckRawDataEveryNumPackets = FIREHOSE_MANAGER.LogLevel;
		config.maxPayloadSizeFromTargetInBytes = FIREHOSE_MANAGER.maxPayloadSizeFromTargetInBytes;
		FIREHOSE_PACKET.SendXml(FIREHOSE.pkt_fhConfig(config));
		if (Memory_Configuration())
		{
			if (Operators.CompareString(FIREHOSE_MANAGER.TypeMemory, "emmc", TextCompare: false) == 0)
			{
				config = default(FIREHOSE.FIREHOSE_CONFIG);
				config.Version = 4;
				config.MemoryName = FIREHOSE_MANAGER.TypeMemory;
				config.SkipWrite = 0;
				config.ZLPAwareHost = 1;
				config.SkipStorageInit = 0;
				config.ActivePartition = 0;
				config.MaxPayloadSizeToTargetInBytes = FIREHOSE_MANAGER.MaxPayloadSizeToTargetInBytes;
				config.AckRawDataEveryNumPackets = FIREHOSE_MANAGER.LogLevel;
				config.maxPayloadSizeFromTargetInBytes = FIREHOSE_MANAGER.maxPayloadSizeFromTargetInBytes;
				FIREHOSE_PACKET.SendXml(FIREHOSE.pkt_fhConfig(config));
				FIREHOSE_MANAGER.isFirehoseReady = FIREHOSE_RESPONSE.IsAck(silent: true);
			}
			else
			{
				FIREHOSE_MANAGER.isFirehoseReady = true;
			}
		}
		return FIREHOSE_MANAGER.isFirehoseReady;
	}

	public static bool auto_config()
	{
		FIREHOSE_MANAGER.TypeMemory = "emmc";
		FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = "512";
		FIREHOSE_MANAGER.MaxPayloadSizeToTargetInBytes = "8192";
		FIREHOSE_MANAGER.maxPayloadSizeFromTargetInBytes = "4096";
		FIREHOSE.FIREHOSE_CONFIG config = default(FIREHOSE.FIREHOSE_CONFIG);
		config.Version = 4;
		config.MemoryName = FIREHOSE_MANAGER.TypeMemory;
		config.SkipWrite = 0;
		config.ZLPAwareHost = 1;
		config.SkipStorageInit = 0;
		config.ActivePartition = 0;
		config.MaxPayloadSizeToTargetInBytes = FIREHOSE_MANAGER.MaxPayloadSizeToTargetInBytes;
		config.AckRawDataEveryNumPackets = FIREHOSE_MANAGER.LogLevel;
		config.maxPayloadSizeFromTargetInBytes = FIREHOSE_MANAGER.maxPayloadSizeFromTargetInBytes;
		FIREHOSE_PACKET.SendXml(FIREHOSE.pkt_fhConfig(config));
		if (!Memory_Configuration(auto: true))
		{
			if (!FIREHOSE_MANAGER.isFirehoseHasDoAuth)
			{
				FIREHOSE_MANAGER.TypeMemory = "ufs";
				FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = "4096";
				UiManager.ComboTypeMemory();
				config = default(FIREHOSE.FIREHOSE_CONFIG);
				config.Version = 4;
				config.MemoryName = FIREHOSE_MANAGER.TypeMemory;
				config.SkipWrite = 0;
				config.ZLPAwareHost = 1;
				config.SkipStorageInit = 0;
				config.ActivePartition = 0;
				config.MaxPayloadSizeToTargetInBytes = FIREHOSE_MANAGER.MaxPayloadSizeToTargetInBytes;
				config.AckRawDataEveryNumPackets = FIREHOSE_MANAGER.LogLevel;
				config.maxPayloadSizeFromTargetInBytes = FIREHOSE_MANAGER.maxPayloadSizeFromTargetInBytes;
				FIREHOSE_PACKET.SendXml(FIREHOSE.pkt_fhConfig(config));
				Console.WriteLine(" ");
				Console.WriteLine("Memory Type is Changed To UFS!");
				Console.WriteLine(" ");
				FIREHOSE_MANAGER.isFirehoseReady = FIREHOSE_RESPONSE.IsAck(silent: true);
				return FIREHOSE_MANAGER.isFirehoseReady;
			}
			return FIREHOSE_MANAGER.isFirehoseReady;
		}
		UiManager.ComboTypeMemory();
		Console.WriteLine(" ");
		Console.WriteLine("Memory Type Is eMMC!");
		Console.WriteLine(" ");
		FIREHOSE_MANAGER.isFirehoseReady = true;
		return FIREHOSE_MANAGER.isFirehoseReady;
	}

	public static bool Memory_Configuration(bool auto = false)
	{
		string resp = "";
		checked
		{
			if (CheckResponse_OrDoAuth(ref resp))
			{
				if (resp.Contains("MaxPayloadSizeToTargetInBytesSupported"))
				{
					string[] array = resp.Split(' ');
					int num = array.Length - 1;
					int num2 = 0;
					string text = "8192";
					do
					{
						if (array[num2].Contains("MaxPayloadSizeToTargetInBytesSupported"))
						{
							text = CleanNum(array[num2]);
							break;
						}
						num2++;
					}
					while (num2 <= num);
					int result = 0;
					if (int.TryParse(text, out result) && Operators.CompareString(text, FIREHOSE_MANAGER.MaxPayloadSizeToTargetInBytes, TextCompare: false) != 0)
					{
						FIREHOSE_MANAGER.MaxPayloadSizeToTargetInBytes = text;
					}
				}
				if (auto)
				{
					FIREHOSE_PACKET.SendXml(FIREHOSE.pkt_eMMCinfo("0"));
					resp += FIREHOSE_RESPONSE.CekResponseConfig();
					if (!resp.Contains("Failed to open"))
					{
						return true;
					}
					return false;
				}
				return true;
			}
			return false;
		}
	}

	public static void Storage_Configuration()
	{
		FIREHOSE_MANAGER.RefreshDisk();
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		FIREHOSE_PACKET.SendXml(FIREHOSE.pkt_eMMCinfo("0"));
		string text = FIREHOSE_RESPONSE.CekResponseConfig();
		checked
		{
			if (!text.ToUpper().Contains("HANDLE_STORAGE_INFO_FAILURE"))
			{
				if (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.flash || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.ident || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.read || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.erase || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.patch || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.reboot)
				{
					UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
				}
				if (text.Contains("\"ACK\""))
				{
					string text2 = ("<firehose-response>" + text + "\n</firehose-response>").Replace("<?xml version=\"1.0\" encoding=\"UTF-8\" ?>", "\n").Replace("<data>", "").Replace("</data>", "")
						.Replace("{", "")
						.Replace("}", "")
						.Replace("INFO: ", "");
					if (text2.Contains("log") || !text2.Contains(";"))
					{
						XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(text2));
						while (xmlTextReader.Read())
						{
							if (Operators.CompareString(EDL.cancel, "Cancel", TextCompare: false) == 0)
							{
								return;
							}
							if (xmlTextReader.NodeType != XmlNodeType.Element || Operators.CompareString(xmlTextReader.Name.ToLower(), "log", TextCompare: false) != 0)
							{
								continue;
							}
							string attribute = xmlTextReader.GetAttribute("value");
							if (attribute.Contains("SECTOR_SIZE_IN_BYTES"))
							{
								if (Convert.ToInt64(attribute.Substring(attribute.IndexOf("=") + 1)) != 512)
								{
									FIREHOSE_MANAGER.TypeMemory = "ufs";
									FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = "4096";
									num = 4096;
								}
								else
								{
									FIREHOSE_MANAGER.TypeMemory = "emmc";
									FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = "512";
									num = 512;
								}
								if (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.flash || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.ident || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.read || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.erase || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.patch || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.reboot)
								{
									UiManager.Richlogs("- Storage Type : ", Color.Black, isBold: false);
									UiManager.Richlogs(FIREHOSE_MANAGER.TypeMemory.ToUpper(), Color.Lime, isBold: true, NextLine: true);
								}
							}
							if (attribute.Contains("num_partition_sectors"))
							{
								num4 = (int)Convert.ToInt64(attribute.Substring(attribute.IndexOf("=") + 1));
							}
							if (attribute.Contains("MFR") && (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.flash || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.ident || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.read || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.erase || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.patch || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.reboot))
							{
								UiManager.Richlogs("- Manufacturer : ", Color.Black, isBold: false);
								UiManager.Richlogs(Emmcid("0x" + Convert.ToInt64(attribute.Substring(attribute.IndexOf("=") + 1)).ToString("X")), Color.Lime, isBold: true, NextLine: true);
							}
							if (attribute.ToLower().Contains("product name") && (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.flash || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.ident || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.read || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.erase || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.patch || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.reboot))
							{
								UiManager.Richlogs("- Storage Name : ", Color.Black, isBold: false);
								UiManager.Richlogs(attribute.Substring(attribute.IndexOf("=") + 1), Color.Orange, isBold: true, NextLine: true);
							}
							if (num4 != 0 || !attribute.Contains("storage_info"))
							{
								continue;
							}
							string text3 = attribute.Replace("\"", "").Replace("storage_info: ", "").Replace(", ", "\n")
								.Replace(",", "\n");
							if (string.IsNullOrEmpty(text3))
							{
								continue;
							}
							string[] array = text3.Split(new char[1] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
							foreach (string text4 in array)
							{
								if (text4.Contains("total_blocks"))
								{
									num4 = (int)Convert.ToInt64(text4.Remove(0, text4.IndexOf(":") + 1));
								}
								if (text4.Contains("block_size"))
								{
									if (Convert.ToInt64(text4.Remove(0, text4.IndexOf(":") + 1)) == 512)
									{
										FIREHOSE_MANAGER.TypeMemory = "emmc";
										FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = "512";
										num = 512;
									}
									else
									{
										FIREHOSE_MANAGER.TypeMemory = "ufs";
										FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = "4096";
										num = 4096;
									}
									if (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.flash || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.ident || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.read || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.erase || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.patch || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.reboot)
									{
										UiManager.Richlogs("- Storage Type : ", Color.Black, isBold: false);
										UiManager.Richlogs(FIREHOSE_MANAGER.TypeMemory.ToUpper(), Color.Lime, isBold: true, NextLine: true);
									}
								}
								if (text4.Contains("manufacturer_id") && (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.flash || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.ident || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.read || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.erase || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.patch || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.reboot))
								{
									UiManager.Richlogs("- Manufacturer : ", Color.Black, isBold: false);
									UiManager.Richlogs(Emmcid("0x" + Convert.ToInt64(text4.Remove(0, text4.IndexOf(":") + 1)).ToString("X")), Color.Lime, isBold: true, NextLine: true);
								}
								if (text4.Contains("prod_name") && (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.flash || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.ident || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.read || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.erase || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.patch || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.reboot))
								{
									UiManager.Richlogs("- Storage Name : ", Color.Black, isBold: false);
									UiManager.Richlogs(text4.Remove(0, text4.IndexOf(":") + 1), Color.Orange, isBold: true, NextLine: true);
								}
							}
						}
					}
				}
				FIREHOSE_PACKET.SendXml(FIREHOSE.pkt_eMMCinfo("1"));
				text = FIREHOSE_RESPONSE.CekResponseConfig();
				if (text.Contains("\"ACK\""))
				{
					string text5 = ("<firehose-response>" + text + "\n</firehose-response>").Replace("<?xml version=\"1.0\" encoding=\"UTF-8\" ?>", "\n").Replace("<data>", "").Replace("</data>", "")
						.Replace("{", "")
						.Replace("}", "")
						.Replace("INFO: ", "");
					if (text5.Contains("log") || !text5.Contains(";"))
					{
						XmlTextReader xmlTextReader2 = new XmlTextReader(new StringReader(text5));
						while (xmlTextReader2.Read())
						{
							if (Operators.CompareString(EDL.cancel, "Cancel", TextCompare: false) == 0)
							{
								return;
							}
							if (xmlTextReader2.NodeType != XmlNodeType.Element || Operators.CompareString(xmlTextReader2.Name.ToLower(), "log", TextCompare: false) != 0)
							{
								continue;
							}
							string attribute2 = xmlTextReader2.GetAttribute("value");
							if (attribute2.Contains("num_partition_sectors"))
							{
								num3 = (int)Convert.ToInt64(attribute2.Substring(attribute2.IndexOf("=") + 1));
							}
							if (num3 != 0 || !attribute2.Contains("storage_info"))
							{
								continue;
							}
							string text6 = attribute2.Replace("\"", "").Replace("storage_info: ", "").Replace(", ", "\n")
								.Replace(",", "\n");
							if (string.IsNullOrEmpty(text6))
							{
								continue;
							}
							string[] array2 = text6.Split(new char[1] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
							foreach (string text7 in array2)
							{
								if (text7.Contains("total_blocks"))
								{
									num3 = (int)Convert.ToInt64(text7.Remove(0, text7.IndexOf(":") + 1));
								}
							}
						}
					}
				}
				FIREHOSE_PACKET.SendXml(FIREHOSE.pkt_eMMCinfo("2"));
				text = FIREHOSE_RESPONSE.CekResponseConfig();
				if (text.Contains("\"ACK\""))
				{
					string text8 = ("<firehose-response>" + text + "\n</firehose-response>").Replace("<?xml version=\"1.0\" encoding=\"UTF-8\" ?>", "\n").Replace("<data>", "").Replace("</data>", "")
						.Replace("{", "")
						.Replace("}", "")
						.Replace("INFO: ", "");
					if (text8.Contains("log") | !text8.Contains(";"))
					{
						XmlTextReader xmlTextReader3 = new XmlTextReader(new StringReader(text8));
						while (xmlTextReader3.Read())
						{
							if (Operators.CompareString(EDL.cancel, "Cancel", TextCompare: false) == 0)
							{
								return;
							}
							if (xmlTextReader3.NodeType != XmlNodeType.Element || Operators.CompareString(xmlTextReader3.Name.ToLower(), "log", TextCompare: false) != 0)
							{
								continue;
							}
							string attribute3 = xmlTextReader3.GetAttribute("value");
							if (attribute3.Contains("num_partition_sectors"))
							{
								num2 = (int)Convert.ToInt64(attribute3.Substring(attribute3.IndexOf("=") + 1));
							}
							if (num2 != 0 || !attribute3.Contains("storage_info"))
							{
								continue;
							}
							string text9 = attribute3.Replace("\"", "").Replace("storage_info: ", "").Replace(", ", "\n")
								.Replace(",", "\n");
							if (string.IsNullOrEmpty(text9))
							{
								continue;
							}
							string[] array3 = text9.Split(new char[1] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
							foreach (string text10 in array3)
							{
								if (text10.Contains("total_blocks"))
								{
									num2 = (int)Convert.ToInt64(text10.Remove(0, text10.IndexOf(":") + 1));
								}
							}
						}
					}
				}
				if (num2 != 0 && num3 != 0 && num4 != 0)
				{
					string fileSizes = UiManager.GetFileSizes((long)Math.Round(Convert.ToDouble(num4) * (double)num + Convert.ToDouble(num2) * (double)num + Convert.ToDouble(num2) * (double)num + Convert.ToDouble(num2) * (double)num));
					if (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.flash || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.ident || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.read || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.erase || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.patch || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.reboot)
					{
						UiManager.Richlogs("- Boot1 : ", Color.Black, isBold: false);
						UiManager.Richlogs(UiManager.GetFileSizes(num2 * num), Color.Lime, isBold: true, NextLine: true);
						UiManager.Richlogs("- Boot2 : ", Color.Black, isBold: false);
						UiManager.Richlogs(UiManager.GetFileSizes(num3 * num), Color.Lime, isBold: true, NextLine: true);
						UiManager.Richlogs("- RPMB : ", Color.Black, isBold: false);
						UiManager.Richlogs(UiManager.GetFileSizes(num3 * num), Color.Lime, isBold: true, NextLine: true);
						UiManager.Richlogs("- Userdata : ", Color.Black, isBold: false);
						UiManager.Richlogs(fileSizes, Color.Lime, isBold: true, NextLine: true);
					}
				}
				if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name, "frp", TextCompare: false) != 0)
				{
					return;
				}
				if (FIREHOSE_MANAGER.TypeMemory.ToUpper().Contains("EMMC"))
				{
					if (UiManager.Hh.Contains("14."))
					{
						FIREHOSE_OPERATIONS.MenuMan = FIREHOSE_OPERATIONS.MenuManual.readgpt_erase_patch;
					}
					else
					{
						FIREHOSE_OPERATIONS.MenuMan = FIREHOSE_OPERATIONS.MenuManual.readgpt_erase;
					}
				}
				else
				{
					FIREHOSE_OPERATIONS.MenuMan = FIREHOSE_OPERATIONS.MenuManual.readgpt_erase_patch;
				}
			}
			else
			{
				UiManager.Richlogs("Failed", Color.Red, isBold: true, NextLine: true);
				FIREHOSE_MANAGER.isFirehoseReady = false;
			}
		}
	}

	public static bool CheckResponse_OrDoAuth(ref string resp)
	{
		resp = FIREHOSE_RESPONSE.CekResponseConfig();
		if (resp.ToLower().Contains("ack"))
		{
			return true;
		}
		if (!resp.Contains("xml"))
		{
			return false;
		}
		checked
		{
			if (resp.Contains("Only nop and sig tag"))
			{
				if (!FIREHOSE_MANAGER.isFirehoseHasDoAuth)
				{
					UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
					UiManager.Richlogs("- Sending Mi Auth Token : ", Color.Black, isBold: false);
					Form1.SharedUI.ProgressBar1.Text = "Bypass Auth Token..";
					string text = "";
					FIREHOSE_PACKET.SendXml(FIREHOSE.pkt_SendSign());
					Thread.Sleep(100);
					if (!FIREHOSE_RESPONSE.IsAck(silent: true))
					{
						UiManager.Richlogs("Failed", Color.Red, isBold: true, NextLine: true);
						FIREHOSE_MANAGER.isFirehoseHasDoAuth = true;
						FIREHOSE_MANAGER.isFirehoseReady = false;
						return false;
					}
					DiskWriter.DiskWrite(Resources.skip);
					byte[] array = DiskWriter.DiskRead();
					text = Encoding.UTF8.GetString(array, 0, array.Length);
					Console.WriteLine("");
					Console.WriteLine("Bypass Auth Response : ");
					Console.WriteLine("");
					Console.WriteLine(text);
					Console.WriteLine("");
					Thread.Sleep(200);
					if (text.Contains("Authenticated") || text.Contains("\"ACK\""))
					{
						FIREHOSE.FIREHOSE_CONFIG config = default(FIREHOSE.FIREHOSE_CONFIG);
						config.Version = 4;
						config.MemoryName = FIREHOSE_MANAGER.TypeMemory;
						config.SkipWrite = 0;
						config.ZLPAwareHost = 1;
						config.SkipStorageInit = 0;
						config.ActivePartition = 0;
						config.MaxPayloadSizeToTargetInBytes = FIREHOSE_MANAGER.MaxPayloadSizeToTargetInBytes;
						config.AckRawDataEveryNumPackets = FIREHOSE_MANAGER.LogLevel;
						config.maxPayloadSizeFromTargetInBytes = FIREHOSE_MANAGER.maxPayloadSizeFromTargetInBytes;
						FIREHOSE_PACKET.SendXml(FIREHOSE.pkt_fhConfig(config));
						resp = FIREHOSE_RESPONSE.CekResponseConfig();
						Thread.Sleep(100);
						if (!resp.Contains("Failed to open") && resp.Contains("MaxPayloadSizeToTargetInBytesSupported"))
						{
							string[] array2 = resp.Split(' ');
							int num = array2.Length - 1;
							int num2 = 0;
							string text2 = "8192";
							do
							{
								if (array2[num2].Contains("MaxPayloadSizeToTargetInBytesSupported"))
								{
									text2 = CleanNum(array2[num2]);
									break;
								}
								num2++;
							}
							while (num2 <= num);
							int result = 0;
							if (int.TryParse(text2, out result) && Operators.CompareString(text2, FIREHOSE_MANAGER.MaxPayloadSizeToTargetInBytes, TextCompare: false) != 0)
							{
								FIREHOSE_MANAGER.MaxPayloadSizeToTargetInBytes = text2;
								config = default(FIREHOSE.FIREHOSE_CONFIG);
								config.Version = 4;
								config.MemoryName = FIREHOSE_MANAGER.TypeMemory;
								config.SkipWrite = 0;
								config.ZLPAwareHost = 1;
								config.SkipStorageInit = 0;
								config.ActivePartition = 0;
								config.MaxPayloadSizeToTargetInBytes = FIREHOSE_MANAGER.MaxPayloadSizeToTargetInBytes;
								config.AckRawDataEveryNumPackets = FIREHOSE_MANAGER.LogLevel;
								config.maxPayloadSizeFromTargetInBytes = FIREHOSE_MANAGER.maxPayloadSizeFromTargetInBytes;
								FIREHOSE_PACKET.SendXml(FIREHOSE.pkt_fhConfig(config));
								resp = FIREHOSE_RESPONSE.CekResponseConfig();
							}
						}
						if (resp.Contains("\"ACK\""))
						{
							UiManager.Richlogs("Done", Color.Lime, isBold: true, NextLine: true);
							FIREHOSE_MANAGER.isFirehoseHasDoAuth = true;
							FIREHOSE_MANAGER.isFirehoseReady = true;
							return true;
						}
						Thread.Sleep(100);
						if (resp.Contains("Failed to open"))
						{
							if (Operators.CompareString(FIREHOSE_MANAGER.TypeMemory, "emmc", TextCompare: false) == 0 || Operators.CompareString(FIREHOSE_MANAGER.TypeMemory, "auto", TextCompare: false) == 0)
							{
								FIREHOSE_MANAGER.TypeMemory = "ufs";
								FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = "4096";
								UiManager.ComboTypeMemory();
							}
							else
							{
								FIREHOSE_MANAGER.TypeMemory = "emmc";
								FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = "512";
								UiManager.ComboTypeMemory();
							}
						}
						if (resp.Contains("MaxPayloadSizeToTargetInBytesSupported"))
						{
							string[] array3 = resp.Split(' ');
							int num3 = array3.Length - 1;
							int num4 = 0;
							string text3 = "8192";
							do
							{
								if (array3[num4].Contains("MaxPayloadSizeToTargetInBytesSupported"))
								{
									text3 = CleanNum(array3[num4]);
									break;
								}
								num4++;
							}
							while (num4 <= num3);
							int result2 = 0;
							if (int.TryParse(text3, out result2) && Operators.CompareString(text3, FIREHOSE_MANAGER.MaxPayloadSizeToTargetInBytes, TextCompare: false) != 0)
							{
								FIREHOSE_MANAGER.MaxPayloadSizeToTargetInBytes = text3;
							}
						}
						config = default(FIREHOSE.FIREHOSE_CONFIG);
						config.Version = 4;
						config.MemoryName = FIREHOSE_MANAGER.TypeMemory;
						config.SkipWrite = 0;
						config.ZLPAwareHost = 1;
						config.SkipStorageInit = 0;
						config.ActivePartition = 0;
						config.MaxPayloadSizeToTargetInBytes = FIREHOSE_MANAGER.MaxPayloadSizeToTargetInBytes;
						config.AckRawDataEveryNumPackets = FIREHOSE_MANAGER.LogLevel;
						config.maxPayloadSizeFromTargetInBytes = FIREHOSE_MANAGER.maxPayloadSizeFromTargetInBytes;
						FIREHOSE_PACKET.SendXml(FIREHOSE.pkt_fhConfig(config));
						resp = FIREHOSE_RESPONSE.CekResponseConfig();
						if (resp.Contains("\"ACK\""))
						{
							FIREHOSE_MANAGER.isFirehoseHasDoAuth = true;
							FIREHOSE_MANAGER.isFirehoseReady = true;
							return true;
						}
						FIREHOSE_MANAGER.isFirehoseHasDoAuth = true;
						FIREHOSE_MANAGER.isFirehoseReady = false;
						return false;
					}
					if (text.Contains("Signature Verification Failed"))
					{
						UiManager.Richlogs("Signature Verification Failed", Color.Red, isBold: true, NextLine: true);
					}
					else
					{
						UiManager.Richlogs("Failed", Color.Red, isBold: true, NextLine: true);
					}
					FIREHOSE_MANAGER.isFirehoseReady = false;
					FIREHOSE_MANAGER.isFirehoseHasDoAuth = true;
					return false;
				}
				FIREHOSE_MANAGER.isFirehoseHasDoAuth = true;
				return false;
			}
			return true;
		}
	}

	public static string Emmcid(string s)
	{
		if (Operators.CompareString(s, "0xA8", TextCompare: false) != 0)
		{
			if (!((Operators.CompareString(s, "0x15", TextCompare: false) == 0) | (Operators.CompareString(s, "0x1CE", TextCompare: false) == 0)))
			{
				if (!((Operators.CompareString(s, "0x15", TextCompare: false) == 0) | (Operators.CompareString(s, "0x11", TextCompare: false) == 0)))
				{
					if ((Operators.CompareString(s, "0x90", TextCompare: false) == 0) | (Operators.CompareString(s, "0x1AD", TextCompare: false) == 0))
					{
						return "SkHynix";
					}
					switch (s)
					{
					case "0xFE":
						return "Micron";
					case "0x9D":
						return "ISSI";
					case "0x88":
						return "Foresee";
					case "0x13":
						return "Micron";
					default:
						if (!((Operators.CompareString(s, "0x02", TextCompare: false) == 0) | (Operators.CompareString(s, "0x45", TextCompare: false) == 0)))
						{
							if (!((Operators.CompareString(s, "0x70", TextCompare: false) == 0) | (Operators.CompareString(s, "0x79", TextCompare: false) == 0)))
							{
								return "Leahkinn";
							}
							return "Kingston";
						}
						return "SanDisk";
					}
				}
				return "Toshiba";
			}
			return "SAMSUNG";
		}
		return "UNKOWN";
	}

	private static string CleanNum(string input)
	{
		if (!string.IsNullOrEmpty(input))
		{
			string pattern = "[^0-9]";
			return Regex.Replace(input, pattern, string.Empty);
		}
		return "0";
	}
}
