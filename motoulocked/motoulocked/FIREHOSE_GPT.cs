using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.motoulocked;

[StandardModule]
internal sealed class FIREHOSE_GPT
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__34_002D0
	{
		public int _0024VB_0024Local_kk;

		public _Closure_0024__34_002D0(_Closure_0024__34_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_kk = arg0._0024VB_0024Local_kk;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__34_002D1
	{
		public string _0024VB_0024Local_hh2;

		public _Closure_0024__34_002D0 _0024VB_0024NonLocal__0024VB_0024Closure_2;

		public _Closure_0024__34_002D1(_Closure_0024__34_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_hh2 = arg0._0024VB_0024Local_hh2;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__2()
		{
			EDL.SharedEDL.DataView.Rows.Add(false, GPT_PartitionName.Items[_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_kk].ToString().Trim(charsToTrim), "Double Click For Add File", GPT_StartSector.Items[_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_kk].ToString(), checked(long.Parse(GPT_LastSector.Items[_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_kk].ToString()) - long.Parse(GPT_StartSector.Items[_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_kk].ToString()) + 1).ToString(), GPT_PhysicalPartition.Items[_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_kk].ToString(), "512", _0024VB_0024Local_hh2);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__34_002D2
	{
		public int _0024VB_0024Local_kk;

		public _Closure_0024__34_002D2(_Closure_0024__34_002D2 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_kk = arg0._0024VB_0024Local_kk;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__34_002D3
	{
		public string _0024VB_0024Local_hh2;

		public _Closure_0024__34_002D2 _0024VB_0024NonLocal__0024VB_0024Closure_3;

		public _Closure_0024__34_002D3(_Closure_0024__34_002D3 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_hh2 = arg0._0024VB_0024Local_hh2;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__3()
		{
			EDL.SharedEDL.DataView.Rows.Add(false, GPT_PartitionName.Items[_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_kk].ToString().Trim(charsToTrim), "Double Click For Add File", GPT_StartSector.Items[_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_kk].ToString(), checked(long.Parse(GPT_LastSector.Items[_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_kk].ToString()) - long.Parse(GPT_StartSector.Items[_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_kk].ToString()) + 1).ToString(), GPT_PhysicalPartition.Items[_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_kk].ToString(), "4096", _0024VB_0024Local_hh2);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__34_002D4
	{
		public int _0024VB_0024Local_kk;

		public _Closure_0024__34_002D4(_Closure_0024__34_002D4 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_kk = arg0._0024VB_0024Local_kk;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__34_002D5
	{
		public string _0024VB_0024Local_hh2;

		public _Closure_0024__34_002D4 _0024VB_0024NonLocal__0024VB_0024Closure_4;

		public _Closure_0024__34_002D5(_Closure_0024__34_002D5 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_hh2 = arg0._0024VB_0024Local_hh2;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__4()
		{
			EDL.SharedEDL.DataView.Rows.Add(false, GPT_PartitionName.Items[_0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024Local_kk].ToString().Trim(charsToTrim), "Double Click For Add File", GPT_StartSector.Items[_0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024Local_kk].ToString(), Convert.ToString(long.Parse(GPT_LastSector.Items[_0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024Local_kk].ToString())), GPT_PhysicalPartition.Items[_0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024Local_kk].ToString(), "4096", _0024VB_0024Local_hh2);
		}
	}

	private static char[] charsToTrim { get; set; } = new char[2] { '\0', '\u0010' };


	public static ListBox GPT_PartitionName { get; set; } = new ListBox();


	public static ListBox GPT_LastSector { get; set; } = new ListBox();


	public static ListBox GPT_PhysicalPartition { get; set; } = new ListBox();


	public static ListBox GPT_SectorSize { get; set; } = new ListBox();


	public static ListBox GPT_StartSector { get; set; } = new ListBox();


	private static bool GPT_reconfig { get; set; } = false;


	public static void Clear_GPT()
	{
		GPT_reconfig = false;
		GPT_PartitionName.Items.Clear();
		GPT_StartSector.Items.Clear();
		GPT_LastSector.Items.Clear();
		GPT_SectorSize.Items.Clear();
		GPT_PhysicalPartition.Items.Clear();
	}

	public static bool GPT_Reader(bool silent = false)
	{
		Console.WriteLine(" ");
		Console.WriteLine("Reading GPT ...");
		if (!FIREHOSE_MANAGER.isFirehoseReady)
		{
			return false;
		}
		FIREHOSE_MANAGER.RefreshDisk();
		FIREHOSE_MANAGER.isNewUFS = false;
		if (!silent)
		{
			if (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.flash || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.ident || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.read || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.erase || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.patch || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.reboot)
			{
				UiManager.Richlogs("- Scanning Partitions Data : ", Color.Black, isBold: false);
			}
			Form1.SharedUI.ProgressBar1.Text = "Scanning...";
		}
		if (Operators.CompareString(FIREHOSE_MANAGER.TypeMemory, "emmc", TextCompare: false) == 0)
		{
			if (ParseGPT(FIREHOSE_MANAGER.TypeMemory, "0"))
			{
				ParsePartions(FIREHOSE_MANAGER.TypeMemory, "0");
			}
			if (ParseGPT(FIREHOSE_MANAGER.TypeMemory, "1"))
			{
				ParsePartions(FIREHOSE_MANAGER.TypeMemory, "1");
			}
			if (ParseGPT(FIREHOSE_MANAGER.TypeMemory, "2"))
			{
				ParsePartions(FIREHOSE_MANAGER.TypeMemory, "2");
			}
			if (ParseGPT(FIREHOSE_MANAGER.TypeMemory, "3"))
			{
				ParsePartions(FIREHOSE_MANAGER.TypeMemory, "3");
			}
			if (ParseGPT(FIREHOSE_MANAGER.TypeMemory, "4"))
			{
				ParsePartions(FIREHOSE_MANAGER.TypeMemory, "4");
			}
			if (ParseGPT(FIREHOSE_MANAGER.TypeMemory, "5"))
			{
				ParsePartions(FIREHOSE_MANAGER.TypeMemory, "5");
			}
		}
		else
		{
			FIREHOSE_MANAGER.TypeMemory = "ufs";
			ParsePartions(FIREHOSE_MANAGER.TypeMemory, "0");
			ParsePartions(FIREHOSE_MANAGER.TypeMemory, "1");
			ParsePartions(FIREHOSE_MANAGER.TypeMemory, "2");
			ParsePartions(FIREHOSE_MANAGER.TypeMemory, "3");
			ParsePartions(FIREHOSE_MANAGER.TypeMemory, "4");
			ParsePartions(FIREHOSE_MANAGER.TypeMemory, "5");
		}
		if (GPT_PartitionName.Items.Count > 0)
		{
			if (!silent && (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.flash || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.ident || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.read || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.erase || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.patch || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.reboot))
			{
				UiManager.Richlogs($"Found {GPT_PartitionName.Items.Count} Total Partitions!", Color.FromArgb(21, 87, 255), isBold: true, NextLine: true);
			}
			if (!silent)
			{
				Show_GPT();
			}
			return true;
		}
		if (!GPT_reconfig)
		{
			FIREHOSE_MANAGER.RefreshDisk();
			GPT_reconfig = true;
			if (Operators.CompareString(FIREHOSE_MANAGER.TypeMemory, "emmc", TextCompare: false) == 0)
			{
				FIREHOSE_MANAGER.TypeMemory = "ufs";
				FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = "4096";
			}
			else
			{
				FIREHOSE_MANAGER.TypeMemory = "emmc";
				FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = "512";
			}
			UiManager.ComboTypeMemory();
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
			FIREHOSE_PACKET.SendXmlFast(FIREHOSE.pkt_fhConfig(config));
			FIREHOSE_MANAGER.isFirehoseReady = true;
			FIREHOSE_CONFIG.Storage_Configuration();
			bool result = GPT_Reader(silent: true);
			if (!silent)
			{
				Show_GPT();
			}
			return result;
		}
		if (!silent)
		{
			UiManager.Richlogs("Not Found", Color.Red);
		}
		return false;
	}

	public static bool ParseGPT(string storage, string lun, bool silent = false)
	{
		FIREHOSE_MANAGER.RefreshDisk();
		if (Operators.CompareString(storage.ToLower(), "emmc", TextCompare: false) == 0)
		{
			FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = "512";
			FIREHOSE_PACKET.SendXml(FIREHOSE.pkt_read("512", "1", lun, "1"));
			byte[] array = FIREHOSE_PACKET.ReadByte("512");
			if (array.Length > 200)
			{
				if (!Encoding.UTF8.GetString(array, 0, array.Length).Contains("EFI"))
				{
					FIREHOSE_MANAGER.RefreshDisk();
					return false;
				}
				FIREHOSE.gpt.header = new FIREHOSE.gpt_header
				{
					signature = Encoding.UTF8.GetString(array.Skip(0).Take(8).ToArray(), 0, 8),
					revision = BitConverter.ToInt32(array.Skip(8).Take(4).ToArray(), 0),
					header_size = BitConverter.ToInt32(array.Skip(12).Take(4).ToArray(), 0),
					crc_header = BitConverter.ToInt32(array.Skip(16).Take(4).ToArray(), 0),
					reserved = BitConverter.ToInt32(array.Skip(20).Take(4).ToArray(), 0),
					current_lba = BitConverter.ToInt32(array.Skip(24).Take(8).ToArray(), 0),
					backup_lba = BitConverter.ToInt32(array.Skip(32).Take(8).ToArray(), 0),
					first_usable_lba = BitConverter.ToInt32(array.Skip(40).Take(8).ToArray(), 0),
					last_usable_lba = BitConverter.ToInt32(array.Skip(48).Take(8).ToArray(), 0),
					disk_guid = array.Skip(56).Take(16).ToArray(),
					starting_lba_pe = BitConverter.ToInt32(array.Skip(72).Take(8).ToArray(), 0)
				};
				FIREHOSE.gpt.header.number_partitions = BitConverter.ToInt32(array.Skip(80).Take(4).ToArray(), 0);
				FIREHOSE.gpt.header.size_partition_entries = BitConverter.ToInt32(array.Skip(84).Take(4).ToArray(), 0);
				FIREHOSE_MANAGER.RefreshDisk();
				return true;
			}
		}
		else if (Operators.CompareString(storage.ToLower(), "ufs", TextCompare: false) == 0)
		{
			FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = "4096";
			int num = 1;
			byte[] array2;
			string @string;
			while (true)
			{
				if (FIREHOSE_MANAGER.FirehoseWorker.CancellationPending)
				{
					throw new Exception(" • Operations Stopped...");
				}
				if (num == 3)
				{
					FIREHOSE_MANAGER.RefreshDisk();
					return false;
				}
				FIREHOSE_PACKET.SendXml(FIREHOSE.pkt_read("4096", "1", lun, num.ToString()));
				array2 = FIREHOSE_PACKET.ReadByte("4096");
				if (array2.Length > 200)
				{
					@string = Encoding.UTF8.GetString(array2, 0, array2.Length);
					if (@string.Contains("EFI"))
					{
						break;
					}
				}
				num = checked(num + 1);
			}
			Console.WriteLine(@string);
			FIREHOSE.gpt.header = new FIREHOSE.gpt_header
			{
				signature = Encoding.UTF8.GetString(array2.Skip(0).Take(8).ToArray(), 0, 8),
				revision = BitConverter.ToInt32(array2.Skip(8).Take(4).ToArray(), 0),
				header_size = BitConverter.ToInt32(array2.Skip(12).Take(4).ToArray(), 0),
				crc_header = BitConverter.ToInt32(array2.Skip(16).Take(4).ToArray(), 0),
				reserved = BitConverter.ToInt32(array2.Skip(20).Take(4).ToArray(), 0),
				current_lba = BitConverter.ToInt32(array2.Skip(24).Take(8).ToArray(), 0),
				backup_lba = BitConverter.ToInt32(array2.Skip(32).Take(8).ToArray(), 0),
				first_usable_lba = BitConverter.ToInt32(array2.Skip(40).Take(8).ToArray(), 0),
				last_usable_lba = BitConverter.ToInt32(array2.Skip(48).Take(8).ToArray(), 0),
				disk_guid = array2.Skip(56).Take(16).ToArray(),
				starting_lba_pe = BitConverter.ToInt32(array2.Skip(72).Take(8).ToArray(), 0)
			};
			FIREHOSE.gpt.header.number_partitions = BitConverter.ToInt32(array2.Skip(80).Take(4).ToArray(), 0);
			FIREHOSE.gpt.header.size_partition_entries = BitConverter.ToInt32(array2.Skip(84).Take(4).ToArray(), 0);
			FIREHOSE_MANAGER.RefreshDisk();
			return true;
		}
		FIREHOSE_MANAGER.RefreshDisk();
		return false;
	}

	public static void ParsePartions(string storage, string lun)
	{
		checked
		{
			if (Operators.CompareString(storage.ToLower(), "emmc", TextCompare: false) == 0)
			{
				FIREHOSE_PACKET.SendXml(FIREHOSE.pkt_read("512", "100", lun, "2"));
				byte[] source = FIREHOSE_PACKET.ReadByte(51200.ToString());
				int num = 0;
				FIREHOSE.gpt.entries = new List<FIREHOSE.gpt_partition_entry>();
				while (true)
				{
					FIREHOSE.gpt_partition_entry gpt_partition_entry = default(FIREHOSE.gpt_partition_entry);
					if (num > 128)
					{
						break;
					}
					if (num == 0)
					{
						gpt_partition_entry.partTypeGUID = Encoding.UTF8.GetString(source.Skip(0).Take(16).ToArray(), 0, 16);
						gpt_partition_entry.partID = Encoding.UTF8.GetString(source.Skip(16).Take(16).ToArray(), 0, 16);
						gpt_partition_entry.first_lba = (ulong)BitConverter.ToInt32(source.Skip(32).Take(8).ToArray(), 0);
						gpt_partition_entry.last_lba = (ulong)BitConverter.ToInt32(source.Skip(40).Take(8).ToArray(), 0);
						gpt_partition_entry.flags = source.Skip(48).Take(8).ToArray();
						gpt_partition_entry.partName = CleanName(source.Skip(53).Take(72).ToArray());
					}
					else
					{
						int num2 = num * 128;
						gpt_partition_entry.partTypeGUID = Encoding.UTF8.GetString(source.Skip(num2).Take(16).ToArray(), 0, 16);
						gpt_partition_entry.partID = Encoding.UTF8.GetString(source.Skip(num2 + 16).Take(16).ToArray(), 0, 16);
						gpt_partition_entry.first_lba = (ulong)BitConverter.ToInt32(source.Skip(num2 + 32).Take(8).ToArray(), 0);
						gpt_partition_entry.last_lba = (ulong)BitConverter.ToInt32(source.Skip(num2 + 40).Take(8).ToArray(), 0);
						gpt_partition_entry.flags = source.Skip(num2 + 48).Take(8).ToArray();
						gpt_partition_entry.partName = CleanName(source.Skip(num2 + 53).Take(72).ToArray());
					}
					if (string.IsNullOrEmpty(CleanStr(gpt_partition_entry.partName)))
					{
						break;
					}
					if (!string.IsNullOrEmpty(CleanStr(gpt_partition_entry.partName)))
					{
						if (!Check_GPT_Existing_List(CleanStr(gpt_partition_entry.partName), lun))
						{
							GPT_PartitionName.Items.Add(CleanStr(gpt_partition_entry.partName));
							GPT_StartSector.Items.Add(CleanNum(gpt_partition_entry.first_lba.ToString()));
							GPT_LastSector.Items.Add(CleanNum(gpt_partition_entry.last_lba.ToString()));
							GPT_SectorSize.Items.Add("512");
							GPT_PhysicalPartition.Items.Add(lun);
						}
						num++;
					}
				}
			}
			else
			{
				if (Operators.CompareString(storage.ToLower(), "ufs", TextCompare: false) != 0)
				{
					return;
				}
				FIREHOSE_PACKET.SendXml(FIREHOSE.pkt_read("4096", "100", lun, "2"));
				byte[] array = FIREHOSE_PACKET.ReadByte(409600.ToString());
				if (Encoding.UTF8.GetString(array.Skip(2).Take(3).ToArray()).Contains("xml"))
				{
					array = array.Skip(96).Take(array.Length - 96).ToArray();
				}
				int num3 = 0;
				FIREHOSE.gpt.entries = new List<FIREHOSE.gpt_partition_entry>();
				while (true)
				{
					FIREHOSE.gpt_partition_entry gpt_partition_entry2 = default(FIREHOSE.gpt_partition_entry);
					if (num3 > 128)
					{
						break;
					}
					if (num3 == 0)
					{
						gpt_partition_entry2.partTypeGUID = Encoding.UTF8.GetString(array.Skip(0).Take(16).ToArray(), 0, 16);
						gpt_partition_entry2.partID = Encoding.UTF8.GetString(array.Skip(16).Take(16).ToArray(), 0, 16);
						gpt_partition_entry2.first_lba = (ulong)BitConverter.ToInt32(array.Skip(32).Take(8).ToArray(), 0);
						gpt_partition_entry2.last_lba = (ulong)BitConverter.ToInt32(array.Skip(40).Take(8).ToArray(), 0);
						gpt_partition_entry2.flags = array.Skip(48).Take(8).ToArray();
						gpt_partition_entry2.partName = CleanName(array.Skip(53).Take(72).ToArray());
					}
					else
					{
						int num4 = num3 * 128;
						gpt_partition_entry2.partTypeGUID = Encoding.UTF8.GetString(array.Skip(num4).Take(16).ToArray(), 0, 16);
						gpt_partition_entry2.partID = Encoding.UTF8.GetString(array.Skip(num4 + 16).Take(16).ToArray(), 0, 16);
						gpt_partition_entry2.first_lba = (ulong)BitConverter.ToInt32(array.Skip(num4 + 32).Take(8).ToArray(), 0);
						gpt_partition_entry2.last_lba = (ulong)BitConverter.ToInt32(array.Skip(num4 + 40).Take(8).ToArray(), 0);
						gpt_partition_entry2.flags = array.Skip(num4 + 48).Take(8).ToArray();
						gpt_partition_entry2.partName = CleanName(array.Skip(num4 + 53).Take(72).ToArray());
					}
					if (string.IsNullOrEmpty(CleanStr(gpt_partition_entry2.partName)))
					{
						break;
					}
					if (decimal.Compare(new decimal(gpt_partition_entry2.first_lba), 0m) == 0)
					{
						FIREHOSE_MANAGER.isNewUFS = true;
						break;
					}
					if (!string.IsNullOrEmpty(CleanStr(gpt_partition_entry2.partName)))
					{
						if (!Check_GPT_Existing_List(CleanStr(gpt_partition_entry2.partName), lun))
						{
							GPT_PartitionName.Items.Add(CleanStr(gpt_partition_entry2.partName));
							GPT_StartSector.Items.Add(CleanNum(gpt_partition_entry2.first_lba.ToString()));
							GPT_LastSector.Items.Add(CleanNum(gpt_partition_entry2.last_lba.ToString()));
							GPT_SectorSize.Items.Add("4096");
							GPT_PhysicalPartition.Items.Add(lun);
						}
						num3++;
					}
				}
				if (!FIREHOSE_MANAGER.isNewUFS)
				{
					return;
				}
				num3 = 0;
				FIREHOSE.gpt.entries = new List<FIREHOSE.gpt_partition_entry>();
				while (true)
				{
					FIREHOSE.gpt_partition_entry gpt_partition_entry3 = default(FIREHOSE.gpt_partition_entry);
					if (num3 > 128)
					{
						break;
					}
					if (num3 == 0)
					{
						gpt_partition_entry3.partTypeGUID = Encoding.UTF8.GetString(array.Skip(0).Take(16).ToArray(), 0, 16);
						gpt_partition_entry3.partID = Encoding.UTF8.GetString(array.Skip(16).Take(16).ToArray(), 0, 16);
						gpt_partition_entry3.first_lba = (ulong)BitConverter.ToInt32(array.Skip(29).Take(3).Concat(new byte[1])
							.ToArray(), 0);
						byte[] second = array.Skip(45).Take(1).ToArray();
						byte[] first = array.Skip(46).Take(1).ToArray();
						byte[] first2 = array.Skip(47).Take(1).ToArray();
						byte[] source2 = new byte[1].Concat(first2.Concat(first.Concat(second))).ToArray();
						gpt_partition_entry3.last_lba = (ulong)BitConverter.ToInt32(source2.Reverse().ToArray(), 0);
						gpt_partition_entry3.flags = array.Skip(48).Take(8).ToArray();
						gpt_partition_entry3.partName = CleanName(array.Skip(53).Take(72).ToArray());
					}
					else
					{
						int num5 = num3 * 128;
						gpt_partition_entry3.partTypeGUID = Encoding.UTF8.GetString(array.Skip(num5).Take(16).ToArray(), 0, 16);
						gpt_partition_entry3.partID = Encoding.UTF8.GetString(array.Skip(num5 + 16).Take(16).ToArray(), 0, 16);
						gpt_partition_entry3.first_lba = (ulong)BitConverter.ToInt32(array.Skip(num5 + 29).Take(3).Concat(new byte[1])
							.ToArray(), 0);
						byte[] second2 = array.Skip(num5 + 45).Take(1).ToArray();
						byte[] first3 = array.Skip(num5 + 46).Take(1).ToArray();
						byte[] first4 = array.Skip(num5 + 47).Take(1).ToArray();
						byte[] source3 = new byte[1].Concat(first4.Concat(first3.Concat(second2))).ToArray();
						gpt_partition_entry3.last_lba = (ulong)BitConverter.ToInt32(source3.Reverse().ToArray(), 0);
						gpt_partition_entry3.flags = array.Skip(num5 + 48).Take(8).ToArray();
						gpt_partition_entry3.partName = CleanName(array.Skip(num5 + 53).Take(72).ToArray());
					}
					if (string.IsNullOrEmpty(CleanStr(gpt_partition_entry3.partName)))
					{
						break;
					}
					if (!string.IsNullOrEmpty(CleanStr(gpt_partition_entry3.partName)))
					{
						if (decimal.Compare(new decimal(gpt_partition_entry3.last_lba), 0m) > 0 && !Check_GPT_Existing_List(CleanStr(gpt_partition_entry3.partName), lun))
						{
							GPT_PartitionName.Items.Add(CleanStr(gpt_partition_entry3.partName));
							GPT_StartSector.Items.Add(CleanNum(gpt_partition_entry3.first_lba.ToString()));
							GPT_LastSector.Items.Add(CleanNum(gpt_partition_entry3.last_lba.ToString()));
							GPT_SectorSize.Items.Add("4096");
							GPT_PhysicalPartition.Items.Add(lun);
						}
						num3++;
					}
				}
			}
		}
	}

	private static bool Check_GPT_Existing_List(string partition, string lun)
	{
		if (partition.Contains("ACK"))
		{
			return true;
		}
		checked
		{
			if (GPT_PartitionName.Items.Count > 0)
			{
				int num = GPT_PartitionName.Items.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(GPT_PartitionName.Items[i].ToString().ToLower(), partition.ToLower(), TextCompare: false) == 0 && Operators.CompareString(GPT_PhysicalPartition.Items[i].ToString(), lun, TextCompare: false) == 0)
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	public static void Show_GPT()
	{
		if (!FIREHOSE_MANAGER.isShowListGPT)
		{
			return;
		}
		checked
		{
			if (Operators.CompareString(FIREHOSE_MANAGER.TypeMemory, "emmc", TextCompare: false) == 0)
			{
				_Closure_0024__34_002D0 arg = default( _Closure_0024__34_002D0);
				EDL.SharedEDL.DataView.Invoke((Action)([SpecialName] () =>
				{
					EDL.SharedEDL.DataView.Rows.Add(false, "PrimaryGPT", "Double Click For Add File", "0", "34", "0", "512");
				}));
				EDL.SharedEDL.DataView.Invoke((Action)([SpecialName] () =>
				{
					EDL.SharedEDL.DataView.Rows.Add(false, "BackupGPT", "Double Click For Add File", "NUM_DISK_SECTORS-33.", "33", "0", "512");
				}));
				_Closure_0024__34_002D0 closure_0024__34_002D = arg;
				int num = GPT_PartitionName.Items.Count - 1;
				closure_0024__34_002D._0024VB_0024Local_kk = 0;
				_Closure_0024__34_002D1 closure_0024__34_002D2 = default(_Closure_0024__34_002D1);
				while (arg._0024VB_0024Local_kk <= num)
				{
					closure_0024__34_002D2 = new _Closure_0024__34_002D1(closure_0024__34_002D2);
					closure_0024__34_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2 = arg;
					double byteCount = Conversions.ToDouble((long.Parse(GPT_LastSector.Items[closure_0024__34_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_kk].ToString()) - long.Parse(GPT_StartSector.Items[closure_0024__34_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_kk].ToString()) + 1).ToString()) * 1024.0 / 2.0;
					closure_0024__34_002D2._0024VB_0024Local_hh2 = UiManager.GetFileCalculator(byteCount);
					EDL.SharedEDL.DataView.Invoke(new Action(closure_0024__34_002D2._Lambda_0024__2));
					arg._0024VB_0024Local_kk++;
				}
			}
			else if (!FIREHOSE_MANAGER.isNewUFS)
			{
				_Closure_0024__34_002D2 arg2 = default(_Closure_0024__34_002D2);
				_Closure_0024__34_002D2 closure_0024__34_002D3 = arg2;
				int num2 = GPT_PartitionName.Items.Count - 1;
				closure_0024__34_002D3._0024VB_0024Local_kk = 0;
				_Closure_0024__34_002D3 closure_0024__34_002D4 = default(_Closure_0024__34_002D3);
				while (arg2._0024VB_0024Local_kk <= num2)
				{
					closure_0024__34_002D4 = new _Closure_0024__34_002D3(closure_0024__34_002D4);
					closure_0024__34_002D4._0024VB_0024NonLocal__0024VB_0024Closure_3 = arg2;
					double byteCount2 = Conversions.ToDouble((long.Parse(GPT_LastSector.Items[closure_0024__34_002D4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_kk].ToString()) - long.Parse(GPT_StartSector.Items[closure_0024__34_002D4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_kk].ToString()) + 1).ToString()) * 1024.0 / 2.0;
					closure_0024__34_002D4._0024VB_0024Local_hh2 = UiManager.GetFileCalculator(byteCount2);
					EDL.SharedEDL.DataView.Invoke(new Action(closure_0024__34_002D4._Lambda_0024__3));
					arg2._0024VB_0024Local_kk++;
				}
			}
			else
			{
				_Closure_0024__34_002D4 arg3 = default(_Closure_0024__34_002D4);
				_Closure_0024__34_002D4 closure_0024__34_002D5 = arg3;
				int num3 = GPT_PartitionName.Items.Count - 1;
				closure_0024__34_002D5._0024VB_0024Local_kk = 0;
				_Closure_0024__34_002D5 closure_0024__34_002D6 = default(_Closure_0024__34_002D5);
				while (arg3._0024VB_0024Local_kk <= num3)
				{
					closure_0024__34_002D6 = new _Closure_0024__34_002D5(closure_0024__34_002D6);
					closure_0024__34_002D6._0024VB_0024NonLocal__0024VB_0024Closure_4 = arg3;
					double byteCount3 = Conversions.ToDouble(Convert.ToString(long.Parse(GPT_LastSector.Items[closure_0024__34_002D6._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024Local_kk].ToString()))) * 1024.0 / 2.0;
					closure_0024__34_002D6._0024VB_0024Local_hh2 = UiManager.GetFileCalculator(byteCount3);
					EDL.SharedEDL.DataView.Invoke(new Action(closure_0024__34_002D6._Lambda_0024__4));
					arg3._0024VB_0024Local_kk++;
				}
			}
			if (EDL.SharedEDL.DataView.Rows.Count <= 0)
			{
				return;
			}
			foreach (DataGridViewRow item in (IEnumerable)EDL.SharedEDL.DataView.Rows)
			{
				if (Operators.CompareString(item.Cells[1].Value.ToString(), "cfg", TextCompare: false) == 0 || Operators.CompareString(item.Cells[1].Value.ToString(), "efs", TextCompare: false) == 0 || Operators.CompareString(item.Cells[1].Value.ToString(), "fsc", TextCompare: false) == 0 || Operators.CompareString(item.Cells[1].Value.ToString(), "fsg", TextCompare: false) == 0 || Operators.CompareString(item.Cells[1].Value.ToString(), "mdm19kefs1", TextCompare: false) == 0 || Operators.CompareString(item.Cells[1].Value.ToString(), "mdm19kefs2", TextCompare: false) == 0 || Operators.CompareString(item.Cells[1].Value.ToString(), "mdm19kefs3", TextCompare: false) == 0 || Operators.CompareString(item.Cells[1].Value.ToString(), "mdm19kefsc", TextCompare: false) == 0 || Operators.CompareString(item.Cells[1].Value.ToString(), "modem", TextCompare: false) == 0 || Operators.CompareString(item.Cells[1].Value.ToString(), "modem_a", TextCompare: false) == 0 || Operators.CompareString(item.Cells[1].Value.ToString(), "modem_b", TextCompare: false) == 0 || Operators.CompareString(item.Cells[1].Value.ToString(), "modemst1", TextCompare: false) == 0 || Operators.CompareString(item.Cells[1].Value.ToString(), "modemst2", TextCompare: false) == 0 || Operators.CompareString(item.Cells[1].Value.ToString(), "oppodycnvbk", TextCompare: false) == 0 || Operators.CompareString(item.Cells[1].Value.ToString(), "oppostanvbk", TextCompare: false) == 0)
				{
					item.DefaultCellStyle.ForeColor = Color.Red;
				}
			}
		}
	}

	public static bool Check_Partition_FRP()
	{
		if (GPT_PartitionName.Items.Contains("frp"))
		{
			return true;
		}
		if (GPT_PartitionName.Items.Contains("persistent"))
		{
			return true;
		}
		if (GPT_PartitionName.Items.Contains("config"))
		{
			return true;
		}
		return false;
	}

	public static void Create_XML_FlashPart()
	{
		Console.WriteLine("Create XML Flash Partition");
		Thread.Sleep(100);
		FIREHOSE_MANAGER.StringXml = "";
		FIREHOSE_MANAGER.StringXml += "<?xml version=\"1.0\" ?>\r\n";
		FIREHOSE_MANAGER.StringXml += "<data>\r\n";
		FIREHOSE_MANAGER.totalchecked = 0;
		checked
		{
			if (GPT_PartitionName.Items.Count > 0)
			{
				int num = 0;
				int num2 = GPT_PartitionName.Items.Count - 1;
				for (num = 0; num <= num2; num++)
				{
					if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name.ToLower(), "clean_kg", TextCompare: false) == 0)
					{
						if (Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "sec_efs", TextCompare: false) == 0)
						{
							FIREHOSE_MANAGER.totalchecked++;
							if (!FIREHOSE_MANAGER.isNewUFS)
							{
								string text = ($"<program SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString()) - long.Parse(GPT_StartSector.Items[num].ToString()) + 1}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
								FIREHOSE_MANAGER.StringXml += text;
							}
							else
							{
								string text2 = ($"<program SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString())}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
								FIREHOSE_MANAGER.StringXml += text2;
							}
						}
					}
					else if (Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), FIREHOSE_MANAGER.Partition_Name.ToLower(), TextCompare: false) == 0)
					{
						FIREHOSE_MANAGER.totalchecked++;
						if (!FIREHOSE_MANAGER.isNewUFS)
						{
							string text3 = ($"<program SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString()) - long.Parse(GPT_StartSector.Items[num].ToString()) + 1}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
							FIREHOSE_MANAGER.StringXml += text3;
						}
						else
						{
							string text4 = ($"<program SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString())}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
							FIREHOSE_MANAGER.StringXml += text4;
						}
					}
				}
			}
			FIREHOSE_MANAGER.StringXml += "</data>";
		}
	}

	public static void Create_XML_ErasePart()
	{
		Console.WriteLine("Create XML Erase Partition");
		Thread.Sleep(100);
		FIREHOSE_MANAGER.StringXml = "";
		FIREHOSE_MANAGER.StringXml += "<?xml version=\"1.0\" ?>\r\n";
		FIREHOSE_MANAGER.StringXml += "<data>\r\n";
		FIREHOSE_MANAGER.totalchecked = 0;
		checked
		{
			if (GPT_PartitionName.Items.Count > 0)
			{
				int num = 0;
				int num2 = GPT_PartitionName.Items.Count - 1;
				for (num = 0; num <= num2; num++)
				{
					if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name.ToLower(), "frp", TextCompare: false) == 0)
					{
						if (Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), FIREHOSE_MANAGER.Partition_Name.ToLower(), TextCompare: false) == 0)
						{
							FIREHOSE_MANAGER.totalchecked++;
							if (!FIREHOSE_MANAGER.isNewUFS)
							{
								string text = ($"<program SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString()) - long.Parse(GPT_StartSector.Items[num].ToString()) + 1}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
								FIREHOSE_MANAGER.StringXml += text;
							}
							else
							{
								string text2 = ($"<program SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString())}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
								FIREHOSE_MANAGER.StringXml += text2;
							}
						}
						else if (Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "persistent", TextCompare: false) == 0)
						{
							FIREHOSE_MANAGER.totalchecked++;
							if (!FIREHOSE_MANAGER.isNewUFS)
							{
								string text3 = ($"<program SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString()) - long.Parse(GPT_StartSector.Items[num].ToString()) + 1}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
								FIREHOSE_MANAGER.StringXml += text3;
							}
							else
							{
								string text4 = ($"<program SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString())}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
								FIREHOSE_MANAGER.StringXml += text4;
							}
						}
						else if (Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "config", TextCompare: false) == 0)
						{
							FIREHOSE_MANAGER.totalchecked++;
							if (!FIREHOSE_MANAGER.isNewUFS)
							{
								string text5 = ($"<program SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString()) - long.Parse(GPT_StartSector.Items[num].ToString()) + 1}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
								FIREHOSE_MANAGER.StringXml += text5;
							}
							else
							{
								string text6 = ($"<program SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString())}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
								FIREHOSE_MANAGER.StringXml += text6;
							}
						}
					}
					else if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name.ToLower(), "efs", TextCompare: false) == 0)
					{
						if (Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "cfg", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "efs", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "fsc", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "fsg", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "mdm19kefs1", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "mdm19kefs2", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "mdm19kefs3", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "mdm19kefsc", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "modem", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "modem_a", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "modem_b", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "modemst1", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "modemst2", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "oppodycnvbk", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "oppostanvbk", TextCompare: false) == 0)
						{
							FIREHOSE_MANAGER.totalchecked++;
							if (!FIREHOSE_MANAGER.isNewUFS)
							{
								string text7 = ($"<program SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString()) - long.Parse(GPT_StartSector.Items[num].ToString()) + 1}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
								FIREHOSE_MANAGER.StringXml += text7;
							}
							else
							{
								string text8 = ($"<program SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString())}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
								FIREHOSE_MANAGER.StringXml += text8;
							}
						}
					}
					else if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name.ToLower(), "modems", TextCompare: false) == 0)
					{
						if (Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "fsg", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "mdm19kefs1", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "mdm19kefs2", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "mdm19kefs3", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "mdm19kefsc", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "modem", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "modem_a", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "modem_b", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "modemst1", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "modemst2", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "oppodycnvbk", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "oppostanvbk", TextCompare: false) == 0)
						{
							FIREHOSE_MANAGER.totalchecked++;
							if (!FIREHOSE_MANAGER.isNewUFS)
							{
								string text9 = ($"<program SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString()) - long.Parse(GPT_StartSector.Items[num].ToString()) + 1}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
								FIREHOSE_MANAGER.StringXml += text9;
							}
							else
							{
								string text10 = ($"<program SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString())}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
								FIREHOSE_MANAGER.StringXml += text10;
							}
						}
					}
					else if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name.ToLower(), "ID", TextCompare: false) == 0)
					{
						if (Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "omginfo", TextCompare: false) == 0)
						{
							FIREHOSE_MANAGER.totalchecked++;
							if (!FIREHOSE_MANAGER.isNewUFS)
							{
								string text11 = ($"<program SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString()) - long.Parse(GPT_StartSector.Items[num].ToString()) + 1}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
								FIREHOSE_MANAGER.StringXml += text11;
							}
							else
							{
								string text12 = ($"<program SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString())}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
								FIREHOSE_MANAGER.StringXml += text12;
							}
						}
					}
					else if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name.ToLower(), "knox", TextCompare: false) == 0)
					{
						if (Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "sec_efs", TextCompare: false) == 0)
						{
							FIREHOSE_MANAGER.totalchecked++;
							if (!FIREHOSE_MANAGER.isNewUFS)
							{
								string text13 = ($"<program SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString()) - long.Parse(GPT_StartSector.Items[num].ToString()) + 1}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
								FIREHOSE_MANAGER.StringXml += text13;
							}
							else
							{
								string text14 = ($"<program SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString())}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
								FIREHOSE_MANAGER.StringXml += text14;
							}
						}
					}
					else if (Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), FIREHOSE_MANAGER.Partition_Name.ToLower(), TextCompare: false) == 0)
					{
						FIREHOSE_MANAGER.totalchecked++;
						if (!FIREHOSE_MANAGER.isNewUFS)
						{
							string text15 = ($"<program SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString()) - long.Parse(GPT_StartSector.Items[num].ToString()) + 1}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
							FIREHOSE_MANAGER.StringXml += text15;
						}
						else
						{
							string text16 = ($"<program SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString())}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
							FIREHOSE_MANAGER.StringXml += text16;
						}
					}
				}
			}
			FIREHOSE_MANAGER.StringXml += "</data>";
			Console.WriteLine("");
			Console.WriteLine("XML Command Erase Part : ");
			Console.WriteLine(FIREHOSE_MANAGER.StringXml);
			Console.WriteLine("");
			Console.WriteLine("");
		}
	}

	public static void Create_XML_ReadPartition()
	{
		Console.WriteLine("Create XML Read Partition");
		Thread.Sleep(100);
		FIREHOSE_MANAGER.StringXml = "";
		FIREHOSE_MANAGER.StringXml += "<?xml version=\"1.0\" ?>\r\n";
		FIREHOSE_MANAGER.StringXml += "<data>\r\n";
		FIREHOSE_MANAGER.totalchecked = 0;
		checked
		{
			if (GPT_PartitionName.Items.Count > 0)
			{
				int num = 0;
				bool flag = false;
				string arg = string.Empty;
				string arg2 = string.Empty;
				string arg3 = string.Empty;
				bool flag2 = false;
				string arg4 = string.Empty;
				string arg5 = string.Empty;
				string arg6 = string.Empty;
				bool flag3 = false;
				string arg7 = string.Empty;
				string arg8 = string.Empty;
				string arg9 = string.Empty;
				bool flag4 = false;
				string arg10 = string.Empty;
				string arg11 = string.Empty;
				string arg12 = string.Empty;
				bool flag5 = false;
				string arg13 = string.Empty;
				string arg14 = string.Empty;
				string arg15 = string.Empty;
				bool flag6 = false;
				string arg16 = string.Empty;
				string arg17 = string.Empty;
				string arg18 = string.Empty;
				bool flag7 = false;
				string arg19 = string.Empty;
				string arg20 = string.Empty;
				string arg21 = string.Empty;
				int num2 = GPT_PartitionName.Items.Count - 1;
				for (num = 0; num <= num2; num++)
				{
					if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name.ToLower(), "efs", TextCompare: false) == 0)
					{
						if (Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "cfg", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "efs", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "fsc", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "fsg", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "mdm19kefs1", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "mdm19kefs2", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "mdm19kefs3", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "mdm19kefsc", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "modem", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "modem_a", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "modem_b", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "modemst1", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "modemst2", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "oppodycnvbk", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "oppostanvbk", TextCompare: false) == 0)
						{
							FIREHOSE_MANAGER.totalchecked++;
							if (!FIREHOSE_MANAGER.isNewUFS)
							{
								string text = ($"<read SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString()) - long.Parse(GPT_StartSector.Items[num].ToString()) + 1}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
								FIREHOSE_MANAGER.StringXml += text;
							}
							else
							{
								string text2 = ($"<read SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString())}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
								FIREHOSE_MANAGER.StringXml += text2;
							}
						}
					}
					else if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name.ToLower(), "clean_mi", TextCompare: false) == 0)
					{
						if (Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "persist", TextCompare: false) == 0)
						{
							FIREHOSE_MANAGER.totalchecked++;
							if (!FIREHOSE_MANAGER.isNewUFS)
							{
								string text3 = ($"<read SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString()) - long.Parse(GPT_StartSector.Items[num].ToString()) + 1}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
								FIREHOSE_MANAGER.StringXml += text3;
							}
							else
							{
								string text4 = ($"<read SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString())}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
								FIREHOSE_MANAGER.StringXml += text4;
							}
						}
					}
					else if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name.ToLower(), "clean_kg", TextCompare: false) == 0)
					{
						if (Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "sec_efs", TextCompare: false) == 0)
						{
							FIREHOSE_MANAGER.totalchecked++;
							if (!FIREHOSE_MANAGER.isNewUFS)
							{
								string text5 = ($"<read SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString()) - long.Parse(GPT_StartSector.Items[num].ToString()) + 1}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
								FIREHOSE_MANAGER.StringXml += text5;
							}
							else
							{
								string text6 = ($"<read SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString())}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
								FIREHOSE_MANAGER.StringXml += text6;
							}
						}
					}
					else if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name.ToLower(), "patch_mi", TextCompare: false) == 0)
					{
						if (Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "modem", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "modem_a", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "modem_b", TextCompare: false) == 0 || Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "persist", TextCompare: false) == 0)
						{
							FIREHOSE_MANAGER.totalchecked++;
							if (!FIREHOSE_MANAGER.isNewUFS)
							{
								string text7 = ($"<read SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString()) - long.Parse(GPT_StartSector.Items[num].ToString()) + 1}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
								FIREHOSE_MANAGER.StringXml += text7;
							}
							else
							{
								string text8 = ($"<read SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString())}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
								FIREHOSE_MANAGER.StringXml += text8;
							}
						}
					}
					else if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name.ToLower(), "readinfo", TextCompare: false) == 0)
					{
						if (Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "boot", TextCompare: false) == 0)
						{
							flag = true;
							arg = (FIREHOSE_MANAGER.isNewUFS ? long.Parse(GPT_LastSector.Items[num].ToString()).ToString() : (long.Parse(GPT_LastSector.Items[num].ToString()) - long.Parse(GPT_StartSector.Items[num].ToString()) + 1).ToString());
							arg2 = GPT_PhysicalPartition.Items[num].ToString();
							arg3 = GPT_StartSector.Items[num].ToString();
						}
						else if (Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "boot_a", TextCompare: false) == 0)
						{
							flag2 = true;
							arg4 = (FIREHOSE_MANAGER.isNewUFS ? long.Parse(GPT_LastSector.Items[num].ToString()).ToString() : (long.Parse(GPT_LastSector.Items[num].ToString()) - long.Parse(GPT_StartSector.Items[num].ToString()) + 1).ToString());
							arg5 = GPT_PhysicalPartition.Items[num].ToString();
							arg6 = GPT_StartSector.Items[num].ToString();
						}
						else if (Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "boot_b", TextCompare: false) == 0)
						{
							flag3 = true;
							arg7 = (FIREHOSE_MANAGER.isNewUFS ? long.Parse(GPT_LastSector.Items[num].ToString()).ToString() : (long.Parse(GPT_LastSector.Items[num].ToString()) - long.Parse(GPT_StartSector.Items[num].ToString()) + 1).ToString());
							arg8 = GPT_PhysicalPartition.Items[num].ToString();
							arg9 = GPT_StartSector.Items[num].ToString();
						}
						else if (Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "recovery", TextCompare: false) == 0)
						{
							flag4 = true;
							arg10 = (FIREHOSE_MANAGER.isNewUFS ? long.Parse(GPT_LastSector.Items[num].ToString()).ToString() : (long.Parse(GPT_LastSector.Items[num].ToString()) - long.Parse(GPT_StartSector.Items[num].ToString()) + 1).ToString());
							arg11 = GPT_PhysicalPartition.Items[num].ToString();
							arg12 = GPT_StartSector.Items[num].ToString();
						}
						else if (Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "recovery_a", TextCompare: false) == 0)
						{
							flag5 = true;
							arg13 = (FIREHOSE_MANAGER.isNewUFS ? long.Parse(GPT_LastSector.Items[num].ToString()).ToString() : (long.Parse(GPT_LastSector.Items[num].ToString()) - long.Parse(GPT_StartSector.Items[num].ToString()) + 1).ToString());
							arg14 = GPT_PhysicalPartition.Items[num].ToString();
							arg15 = GPT_StartSector.Items[num].ToString();
						}
						else if (Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "recovery_b", TextCompare: false) == 0)
						{
							flag6 = true;
							arg16 = (FIREHOSE_MANAGER.isNewUFS ? long.Parse(GPT_LastSector.Items[num].ToString()).ToString() : (long.Parse(GPT_LastSector.Items[num].ToString()) - long.Parse(GPT_StartSector.Items[num].ToString()) + 1).ToString());
							arg17 = GPT_PhysicalPartition.Items[num].ToString();
							arg18 = GPT_StartSector.Items[num].ToString();
						}
						else if (Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), "recovery_ramdisk", TextCompare: false) == 0)
						{
							flag7 = true;
							arg19 = (FIREHOSE_MANAGER.isNewUFS ? long.Parse(GPT_LastSector.Items[num].ToString()).ToString() : (long.Parse(GPT_LastSector.Items[num].ToString()) - long.Parse(GPT_StartSector.Items[num].ToString()) + 1).ToString());
							arg20 = GPT_PhysicalPartition.Items[num].ToString();
							arg21 = GPT_StartSector.Items[num].ToString();
						}
					}
					else if (Operators.CompareString(GPT_PartitionName.Items[num].ToString().ToLower(), FIREHOSE_MANAGER.Partition_Name.ToLower(), TextCompare: false) == 0)
					{
						FIREHOSE_MANAGER.totalchecked++;
						if (!FIREHOSE_MANAGER.isNewUFS)
						{
							string text9 = ($"<read SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString()) - long.Parse(GPT_StartSector.Items[num].ToString()) + 1}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
							FIREHOSE_MANAGER.StringXml += text9;
						}
						else
						{
							string text10 = ($"<read SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + $" filename=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(GPT_PartitionName.Items[num].ToString())}\"" + $" label=\"{RuntimeHelpers.GetObjectValue(GPT_PartitionName.Items[num])}\"" + $" num_partition_sectors=\"{long.Parse(GPT_LastSector.Items[num].ToString())}\"" + $" physical_partition_number=\"{RuntimeHelpers.GetObjectValue(GPT_PhysicalPartition.Items[num])}\"" + $" start_sector=\"{RuntimeHelpers.GetObjectValue(GPT_StartSector.Items[num])}\"/>" + "\r\n") ?? "";
							FIREHOSE_MANAGER.StringXml += text10;
						}
					}
				}
				if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name.ToLower(), "readinfo", TextCompare: false) == 0)
				{
					if (flag7)
					{
						FIREHOSE_MANAGER.totalchecked++;
						string text11 = ($"<read SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + string.Format(" filename=\"{0}\"", FIREHOSE_PARTITIONS.Get_Partition_Filenames("recovery_ramdisk")) + " label=\"recovery_ramdisk\"" + $" num_partition_sectors=\"{arg19}\"" + $" physical_partition_number=\"{arg20}\"" + $" start_sector=\"{arg21}\"/>" + "\r\n") ?? "";
						FIREHOSE_MANAGER.StringXml += text11;
					}
					else if (flag5)
					{
						FIREHOSE_MANAGER.totalchecked++;
						string text12 = ($"<read SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + string.Format(" filename=\"{0}\"", FIREHOSE_PARTITIONS.Get_Partition_Filenames("recovery_a")) + " label=\"recovery\"" + $" num_partition_sectors=\"{arg13}\"" + $" physical_partition_number=\"{arg14}\"" + $" start_sector=\"{arg15}\"/>" + "\r\n") ?? "";
						FIREHOSE_MANAGER.StringXml += text12;
					}
					else if (flag6)
					{
						FIREHOSE_MANAGER.totalchecked++;
						string text13 = ($"<read SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + string.Format(" filename=\"{0}\"", FIREHOSE_PARTITIONS.Get_Partition_Filenames("recovery_b")) + " label=\"recovery\"" + $" num_partition_sectors=\"{arg16}\"" + $" physical_partition_number=\"{arg17}\"" + $" start_sector=\"{arg18}\"/>" + "\r\n") ?? "";
						FIREHOSE_MANAGER.StringXml += text13;
					}
					else if (flag4)
					{
						FIREHOSE_MANAGER.totalchecked++;
						string text14 = ($"<read SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + string.Format(" filename=\"{0}\"", FIREHOSE_PARTITIONS.Get_Partition_Filenames("recovery")) + " label=\"recovery\"" + $" num_partition_sectors=\"{arg10}\"" + $" physical_partition_number=\"{arg11}\"" + $" start_sector=\"{arg12}\"/>" + "\r\n") ?? "";
						FIREHOSE_MANAGER.StringXml += text14;
					}
					else if (flag2)
					{
						FIREHOSE_MANAGER.totalchecked++;
						string text15 = ($"<read SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + string.Format(" filename=\"{0}\"", FIREHOSE_PARTITIONS.Get_Partition_Filenames("boot_a")) + " label=\"boot_a\"" + $" num_partition_sectors=\"{arg4}\"" + $" physical_partition_number=\"{arg5}\"" + $" start_sector=\"{arg6}\"/>" + "\r\n") ?? "";
						FIREHOSE_MANAGER.StringXml += text15;
					}
					else if (flag3)
					{
						FIREHOSE_MANAGER.totalchecked++;
						string text16 = ($"<read SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + string.Format(" filename=\"{0}\"", FIREHOSE_PARTITIONS.Get_Partition_Filenames("boot_b")) + " label=\"boot_a\"" + $" num_partition_sectors=\"{arg7}\"" + $" physical_partition_number=\"{arg8}\"" + $" start_sector=\"{arg9}\"/>" + "\r\n") ?? "";
						FIREHOSE_MANAGER.StringXml += text16;
					}
					else if (flag)
					{
						FIREHOSE_MANAGER.totalchecked++;
						string text17 = ($"<read SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + string.Format(" filename=\"{0}\"", FIREHOSE_PARTITIONS.Get_Partition_Filenames("boot")) + " label=\"boot\"" + $" num_partition_sectors=\"{arg}\"" + $" physical_partition_number=\"{arg2}\"" + $" start_sector=\"{arg3}\"/>" + "\r\n") ?? "";
						FIREHOSE_MANAGER.StringXml += text17;
					}
				}
				if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name.ToLower(), "readinfo2", TextCompare: false) == 0)
				{
					if (flag7)
					{
						FIREHOSE_MANAGER.totalchecked++;
						string text18 = ($"<read SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + string.Format(" filename=\"{0}\"", FIREHOSE_PARTITIONS.Get_Partition_Filenames("recovery_ramdisk")) + " label=\"recovery_ramdisk\"" + $" num_partition_sectors=\"{arg19}\"" + $" physical_partition_number=\"{arg20}\"" + $" start_sector=\"{arg21}\"/>" + "\r\n") ?? "";
						FIREHOSE_MANAGER.StringXml += text18;
					}
					else if (flag5)
					{
						FIREHOSE_MANAGER.totalchecked++;
						string text19 = ($"<read SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + string.Format(" filename=\"{0}\"", FIREHOSE_PARTITIONS.Get_Partition_Filenames("recovery_a")) + " label=\"recovery\"" + $" num_partition_sectors=\"{arg13}\"" + $" physical_partition_number=\"{arg14}\"" + $" start_sector=\"{arg15}\"/>" + "\r\n") ?? "";
						FIREHOSE_MANAGER.StringXml += text19;
					}
					else if (flag6)
					{
						FIREHOSE_MANAGER.totalchecked++;
						string text20 = ($"<read SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + string.Format(" filename=\"{0}\"", FIREHOSE_PARTITIONS.Get_Partition_Filenames("recovery_b")) + " label=\"recovery\"" + $" num_partition_sectors=\"{arg16}\"" + $" physical_partition_number=\"{arg17}\"" + $" start_sector=\"{arg18}\"/>" + "\r\n") ?? "";
						FIREHOSE_MANAGER.StringXml += text20;
					}
					else if (flag4)
					{
						FIREHOSE_MANAGER.totalchecked++;
						string text21 = ($"<read SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\"" + " file_sector_offset=\"0\"" + string.Format(" filename=\"{0}\"", FIREHOSE_PARTITIONS.Get_Partition_Filenames("recovery")) + " label=\"recovery\"" + $" num_partition_sectors=\"{arg10}\"" + $" physical_partition_number=\"{arg11}\"" + $" start_sector=\"{arg12}\"/>" + "\r\n") ?? "";
						FIREHOSE_MANAGER.StringXml += text21;
					}
				}
			}
			FIREHOSE_MANAGER.StringXml += "</data>";
			Console.WriteLine("");
			Console.WriteLine("XML Command Read Part : ");
			Console.WriteLine(FIREHOSE_MANAGER.StringXml);
			Console.WriteLine("");
			Console.WriteLine("");
		}
	}

	private static string CleanStr(string input)
	{
		if (!string.IsNullOrEmpty(input))
		{
			string input2 = input.Replace("last_parti", "last_partition");
			string pattern = "[^a-zA-Z0-9_]";
			return Regex.Replace(input2, pattern, string.Empty);
		}
		return input;
	}

	private static string CleanName(byte[] pname)
	{
		string @string = Encoding.ASCII.GetString(pname);
		if (pname.Length > 3)
		{
			string left = BitConverter.ToString(pname.Take(3).ToArray()).Replace("-", " ");
			if (Operators.CompareString(left, "00 44 10", TextCompare: false) == 0)
			{
				pname = pname.Skip(3).ToArray();
			}
			else if (Operators.CompareString(left, "00 44 00", TextCompare: false) == 0)
			{
				pname = pname.Skip(3).ToArray();
			}
			@string = Encoding.ASCII.GetString(pname);
		}
		return @string.Trim(charsToTrim).Replace("\0", "").Replace("\u0010", "");
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
