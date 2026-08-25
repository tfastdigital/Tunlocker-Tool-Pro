using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.mtkclient2.library;
using motoulocked.mtkclient2.library.xflash;

namespace motoulocked.mtkclient2.MTK.Client.Scatter;

internal class MtkScatter
{
	public class mtk
	{
		public string Partition_index;

		public string Partition_name;

		public string File_name;

		public string Is_download;

		public string Linear_start_addr;

		public string Partition_size;

		public mtk(string Partition_index, string Partition_name, string File_name, string Is_download, string Linear_start_addr, string Partition_size)
		{
			this.Partition_index = Partition_index;
			this.Partition_name = Partition_name;
			this.File_name = File_name;
			this.Is_download = Is_download;
			this.Linear_start_addr = Linear_start_addr;
			this.Partition_size = Partition_size;
		}
	}

	public class Firmware
	{
		public string Index { get; set; }

		public string Filepath { get; set; }

		public Firmware(string Index, string Filepath)
		{
			this.Index = Index;
			this.Filepath = Filepath;
		}
	}

	public static string CPU { get; set; }

	public static string CPUType { get; set; }

	public static string Cache { get; set; }

	public static string Userdata { get; set; }

	public static string Cachepath { get; set; }

	public static string Userpath { get; set; }

	public static string ScatterBuilder()
	{
		string text = string.Concat("############################################### By Tfast Digital Agency ################################################" + Environment.NewLine);
		text = string.Concat(text, "#  General Setting" + Environment.NewLine);
		text = string.Concat(text, "############################################################################################################" + Environment.NewLine);
		text = string.Concat(text, "- general: MTK_PLATFORM_CFG" + Environment.NewLine);
		text = string.Concat(text, "  info: " + Environment.NewLine);
		text = string.Concat(text, "    - config_version: V1.1.2" + Environment.NewLine);
		text = string.Concat(text, "      platform: " + Mediatek.Platform + Environment.NewLine);
		text = string.Concat(text, "      project: Genererate_By Tunlocker Tool_" + Mediatek.PreloaderName.Replace("preloader_", "").Replace(".bin", "").ToUpper() + Environment.NewLine);
		text = string.Concat(text, "      storage: " + Mediatek.Storage + Environment.NewLine);
		text = string.Concat(text, "      boot_channel: MSDC_0" + Environment.NewLine);
		text = string.Concat(text, "      block_size: 0x20000" + Environment.NewLine);
		text = string.Concat(text, "############################################### By Tfast Digital Agency ################################################" + Environment.NewLine);
		text = string.Concat(text, "#  " + Mediatek.Storage + " Layout Setting" + Environment.NewLine);
		text = string.Concat(text, "############################################################################################################" + Environment.NewLine);
		int num = 0;
		foreach (DataGridViewRow item in (IEnumerable)Protocol_MTK_By_Devronix.SharedUI.DataViewmtk.Rows)
		{
			text = string.Concat(text, "- partition_index: SYS" + Conversions.ToString(num) + Environment.NewLine);
			text = string.Concat(text, "  partition_name: " + item.Cells[2].Value.ToString() + Environment.NewLine);
			text = ((Operators.CompareString(item.Cells[2].Value.ToString(), "preloader", TextCompare: false) != 0) ? string.Concat(text, "  file_name: " + item.Cells[2].Value.ToString() + ".img" + Environment.NewLine) : string.Concat(text, "  file_name: " + Mediatek.PreloaderName + Environment.NewLine));
			text = string.Concat(text, "  is_download: true" + Environment.NewLine);
			text = ((Operators.CompareString(item.Cells[2].Value.ToString(), "preloader", TextCompare: false) != 0) ? string.Concat(text, "  type: NORMAL_ROM" + Environment.NewLine) : string.Concat(text, "  type: SV5_BL_BIN" + Environment.NewLine));
			text = string.Concat(text, "  linear_start_addr: " + item.Cells[3].Value.ToString() + Environment.NewLine);
			text = string.Concat(text, "  physical_start_addr: " + item.Cells[3].Value.ToString() + Environment.NewLine);
			text = string.Concat(text, "  partition_size: " + item.Cells[4].Value.ToString() + Environment.NewLine);
			text = ((Operators.CompareString(Mediatek.Storage, "UFS", TextCompare: false) != 0) ? ((Operators.CompareString(item.Cells[2].Value.ToString(), "preloader", TextCompare: false) != 0) ? string.Concat(text, "  region: " + Mediatek.Storage + "_USER" + Environment.NewLine) : string.Concat(text, "  region: " + Mediatek.Storage + "_BOOT1_BOOT2" + Environment.NewLine)) : ((Operators.CompareString(item.Cells[2].Value.ToString(), "preloader", TextCompare: false) != 0) ? string.Concat(text, "  region: UFS_LU2" + Environment.NewLine) : string.Concat(text, "  region: UFS_LU0_LU1" + Environment.NewLine)));
			text = string.Concat(text, "  storage: HW_STORAGE_" + Mediatek.Storage + Environment.NewLine);
			text = string.Concat(text, "  boundary_check: true" + Environment.NewLine);
			text = string.Concat(text, "  is_reserved: false" + Environment.NewLine);
			text = string.Concat(text, ScatterOpr(item.Cells[2].Value.ToString()) + Environment.NewLine);
			text = string.Concat(text, "  is_upgradable: true" + Environment.NewLine);
			text = string.Concat(text, "  empty_boot_needed: false" + Environment.NewLine);
			text = string.Concat(text, "  combo_partsize_check: false" + Environment.NewLine);
			text = string.Concat(text, "  reserve: 0x00" + Environment.NewLine);
			text += Environment.NewLine;
			num = checked(num + 1);
		}
		return text;
	}

	public static string ScatterBuilderGPT(MtkGpt gpt)
	{
		checked
		{
			string text;
			if (gpt.Partitions.Length > 0)
			{
				text = string.Concat("############################################### By Tfast Digital Agency ################################################" + Environment.NewLine);
				text = string.Concat(text, "#  General Setting" + Environment.NewLine);
				text = string.Concat(text, "############################################################################################################" + Environment.NewLine);
				text = string.Concat(text, "- general: MTK_PLATFORM_CFG" + Environment.NewLine);
				text = string.Concat(text, "  info: " + Environment.NewLine);
				text = string.Concat(text, "    - config_version: V1.1.2" + Environment.NewLine);
				text = string.Concat(text, "      platform: " + Mediatek.Platform + Environment.NewLine);
				text = string.Concat(text, "      project: Genererate_By Tunlocker Tool_" + Mediatek.PreloaderName.Replace("preloader_", "").Replace(".bin", "").ToUpper() + Environment.NewLine);
				text = string.Concat(text, "      storage: " + Mediatek.Storage + Environment.NewLine);
				text = string.Concat(text, "      boot_channel: MSDC_0" + Environment.NewLine);
				text = string.Concat(text, "      block_size: 0x20000" + Environment.NewLine);
				text = string.Concat(text, "############################################### By Tfast Digital Agency ################################################" + Environment.NewLine);
				text = string.Concat(text, "#  " + Mediatek.Storage + " Layout Setting" + Environment.NewLine);
				text = string.Concat(text, "############################################################################################################" + Environment.NewLine);
				int num = 0;
				text = string.Concat(text, "- partition_index: SYS" + Conversions.ToString(num) + Environment.NewLine);
				text = string.Concat(text, "  partition_name: preloader" + Environment.NewLine);
				text = string.Concat(text, "  file_name: " + Mediatek.PreloaderName + Environment.NewLine);
				text = string.Concat(text, "  is_download: true" + Environment.NewLine);
				text = string.Concat(text, "  type: SV5_BL_BIN" + Environment.NewLine);
				text = string.Concat(text, "  linear_start_addr: 0x0" + Environment.NewLine);
				text = string.Concat(text, "  physical_start_addr: 0x0" + Environment.NewLine);
				text = string.Concat(text, "  partition_size: " + utils.LongToHex(Mediatek.BootSize) + Environment.NewLine);
				text = string.Concat(text, "  region: " + Mediatek.Storage + "_BOOT1_BOOT2" + Environment.NewLine);
				text = string.Concat(text, "  storage: HW_STORAGE_" + Mediatek.Storage + Environment.NewLine);
				text = string.Concat(text, "  boundary_check: true" + Environment.NewLine);
				text = string.Concat(text, "  is_reserved: false" + Environment.NewLine);
				text = string.Concat(text, ScatterOpr("preloader") + Environment.NewLine);
				text = string.Concat(text, "  is_upgradable: true" + Environment.NewLine);
				text = string.Concat(text, "  empty_boot_needed: false" + Environment.NewLine);
				text = string.Concat(text, "  combo_partsize_check: false" + Environment.NewLine);
				text = string.Concat(text, "  reserve: 0x00" + Environment.NewLine);
				text += Environment.NewLine;
				num++;
				MtkGptPartition[] partitions = gpt.Partitions;
				foreach (MtkGptPartition mtkGptPartition in partitions)
				{
					text = string.Concat(text, "- partition_index: SYS" + Conversions.ToString(num) + Environment.NewLine);
					text = string.Concat(text, "  partition_name: " + mtkGptPartition.Name + Environment.NewLine);
					text = string.Concat(text, "  file_name: " + mtkGptPartition.Name + ".img" + Environment.NewLine);
					text = string.Concat(text, "  is_download: true" + Environment.NewLine);
					text = string.Concat(text, "  type: SV5_BL_BIN" + Environment.NewLine);
					text = string.Concat(text, "  linear_start_addr: " + utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize) + Environment.NewLine);
					text = string.Concat(text, "  physical_start_addr: " + utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize) + Environment.NewLine);
					text = string.Concat(text, "  partition_size: " + utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize) + Environment.NewLine);
					text = string.Concat(text, "  region: " + Mediatek.Storage + "_USER" + Environment.NewLine);
					text = string.Concat(text, "  storage: HW_STORAGE_" + Mediatek.Storage + Environment.NewLine);
					text = string.Concat(text, "  boundary_check: true" + Environment.NewLine);
					text = string.Concat(text, "  is_reserved: false" + Environment.NewLine);
					text = string.Concat(text, ScatterOpr(mtkGptPartition.Name) + Environment.NewLine);
					text = string.Concat(text, "  is_upgradable: true" + Environment.NewLine);
					text = string.Concat(text, "  empty_boot_needed: false" + Environment.NewLine);
					text = string.Concat(text, "  combo_partsize_check: false" + Environment.NewLine);
					text = string.Concat(text, "  reserve: 0x00" + Environment.NewLine);
					text += Environment.NewLine;
					num++;
				}
			}
			else
			{
				text = "";
			}
			return text;
		}
	}

	private static string ScatterOpr(string PartName)
	{
		if (Operators.CompareString(PartName, "preloader", TextCompare: false) == 0)
		{
			return "  operation_type: BOOTLOADERS";
		}
		if (Operators.CompareString(PartName, "proinfo", TextCompare: false) == 0)
		{
			return "  operation_type: PROTECTED";
		}
		if (Operators.CompareString(PartName, "nvcfg", TextCompare: false) == 0)
		{
			return "  operation_type: PROTECTED";
		}
		if (Operators.CompareString(PartName, "persist", TextCompare: false) == 0)
		{
			return "  operation_type: PROTECTED";
		}
		return PartName switch
		{
			"protect1" => "  operation_type: PROTECTED", 
			"protect2" => "  operation_type: PROTECTED", 
			"pgpt" => "  operation_type: INVISIBLE", 
			"boot_para" => "  operation_type: INVISIBLE", 
			"para" => "  operation_type: INVISIBLE", 
			"expdb" => "  operation_type: INVISIBLE", 
			"frp" => "  operation_type: INVISIBLE", 
			"nvdata" => "  operation_type: INVISIBLE", 
			"metadata" => "  operation_type: INVISIBLE", 
			"md_udc" => "  operation_type: INVISIBLE", 
			"seccfg" => "  operation_type: INVISIBLE", 
			"persist" => "  operation_type: INVISIBLE", 
			"sec1" => "  operation_type: INVISIBLE", 
			"efuse" => "  operation_type: INVISIBLE", 
			"gz1" => "  operation_type: INVISIBLE", 
			"pad" => "  operation_type: INVISIBLE", 
			"devinfo" => "  operation_type: INVISIBLE", 
			"otp" => "  operation_type: RESERVED", 
			"flashinfo" => "  operation_type: RESERVED", 
			"sgpt" => "  operation_type: RESERVED", 
			_ => "  operation_type: UPDATE", 
		};
	}

	public static bool IsSupport(string scatter)
	{
		bool result = false;
		try
		{
			bool flag = false;
			string s = File.ReadAllText(scatter);
			using (StringReader stringReader = new StringReader(s))
			{
				while (stringReader.Peek() != -1)
				{
					string text = stringReader.ReadLine();
					if (text.Contains("platform:"))
					{
						CPU = text.Substring(checked(text.IndexOf(":") + 2));
						flag = true;
					}
					else if (text.Contains("storage: EMMC"))
					{
						CPUType = "EMMC";
					}
					else if (text.Contains("storage: NAND"))
					{
						CPUType = "NAND";
					}
					else if (text.Contains("storage: UFS"))
					{
						CPUType = "UFS";
					}
				}
			}
			result = flag;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Console.WriteLine("Scatter cant support !");
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static List<mtk> ScatterTable(string Scatterfile)
	{
		List<mtk> list = new List<mtk>();
		string[] array = File.ReadAllText(Scatterfile).Replace("- partition_index:", "+ partition_index:").Split('+');
		checked
		{
			foreach (string text in array)
			{
				if (!text.Contains("partition_name"))
				{
					continue;
				}
				string partition_index = "";
				string partition_name = "";
				string file_name = "";
				string is_download = "";
				string linear_start_addr = "";
				string partition_size = "";
				using (StringReader stringReader = new StringReader(text))
				{
					while (stringReader.Peek() != -1)
					{
						string text2 = stringReader.ReadLine();
						if (text2.Contains("partition_index"))
						{
							partition_index = text2.Substring(text2.IndexOf(":") + 2).Replace("SYS", "");
						}
						if (text2.Contains("partition_name"))
						{
							partition_name = text2.Substring(text2.IndexOf(":") + 2);
						}
						if (text2.Contains("file_name"))
						{
							file_name = text2.Substring(text2.IndexOf(":") + 2);
						}
						if (text2.Contains("is_download"))
						{
							is_download = text2.Substring(text2.IndexOf(":") + 2);
						}
						if (text2.Contains("linear_start_addr"))
						{
							linear_start_addr = text2.Substring(text2.IndexOf(":") + 2);
						}
						if (text2.Contains("partition_size"))
						{
							partition_size = text2.Substring(text2.IndexOf(":") + 2);
						}
					}
				}
				list.Add(new mtk(partition_index, partition_name, file_name, is_download, linear_start_addr, partition_size));
			}
			return list;
		}
	}
}
