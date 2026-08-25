using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.motoulocked;
using motoulocked.SPD.Worker;

namespace motoulocked.SPD;

public class PACExtractor
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__16_002D0
	{
		public string _0024VB_0024Local_partitionName;

		public ulong _0024VB_0024Local_hiDataOffset;

		public ulong _0024VB_0024Local_loDataOffset;

		public ulong _0024VB_0024Local_hiPartitionSize;

		public ulong _0024VB_0024Local_loPartitionSize;

		public string _0024VB_0024Local_fileName;

		public _Closure_0024__16_002D1 _0024VB_0024NonLocal__0024VB_0024Closure_2;

		public _Closure_0024__16_002D0(_Closure_0024__16_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_partitionName = arg0._0024VB_0024Local_partitionName;
				_0024VB_0024Local_hiDataOffset = arg0._0024VB_0024Local_hiDataOffset;
				_0024VB_0024Local_loDataOffset = arg0._0024VB_0024Local_loDataOffset;
				_0024VB_0024Local_hiPartitionSize = arg0._0024VB_0024Local_hiPartitionSize;
				_0024VB_0024Local_loPartitionSize = arg0._0024VB_0024Local_loPartitionSize;
				_0024VB_0024Local_fileName = arg0._0024VB_0024Local_fileName;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			checked
			{
				SPDR.SharedUI.DataView.Rows.Add(false, _0024VB_0024Local_partitionName, GetPartitionNames(_0024VB_0024Local_partitionName), _0024VB_0024Local_hiDataOffset + _0024VB_0024Local_loDataOffset, _0024VB_0024Local_hiPartitionSize + _0024VB_0024Local_loPartitionSize, string.Empty, _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_outputDir + "\\" + _0024VB_0024Local_fileName);
			}
		}

		[SpecialName]
		internal void _Lambda_0024__1()
		{
			checked
			{
				SPDR.SharedUI.DataView.Rows.Add(true, _0024VB_0024Local_partitionName, GetPartitionNames(_0024VB_0024Local_partitionName), _0024VB_0024Local_hiDataOffset + _0024VB_0024Local_loDataOffset, _0024VB_0024Local_hiPartitionSize + _0024VB_0024Local_loPartitionSize, string.Empty, _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_outputDir + "\\" + _0024VB_0024Local_fileName);
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__16_002D1
	{
		public string _0024VB_0024Local_outputDir;

		public _Closure_0024__16_002D1(_Closure_0024__16_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_outputDir = arg0._0024VB_0024Local_outputDir;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__18_002D0
	{
		public string _0024VB_0024Local_id;

		public string _0024VB_0024Local_blockId;

		public _Closure_0024__18_002D0(_Closure_0024__18_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_id = arg0._0024VB_0024Local_id;
				_0024VB_0024Local_blockId = arg0._0024VB_0024Local_blockId;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			foreach (DataGridViewRow item in (IEnumerable)SPDR.SharedUI.DataView.Rows)
			{
				if (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(item.Cells[SPDR.SharedUI.DataView.Columns[1].Index].Value)), _0024VB_0024Local_id, TextCompare: false) == 0)
				{
					item.Cells[SPDR.SharedUI.DataView.Columns[2].Index].Value = _0024VB_0024Local_blockId;
				}
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__18_002D1
	{
		public string _0024VB_0024Local_Partition;

		public string _0024VB_0024Local_Size;

		public _Closure_0024__18_002D1(_Closure_0024__18_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_Partition = arg0._0024VB_0024Local_Partition;
				_0024VB_0024Local_Size = arg0._0024VB_0024Local_Size;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__1()
		{
			foreach (DataGridViewRow item in (IEnumerable)SPDR.SharedUI.DataView.Rows)
			{
				if (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(item.Cells[SPDR.SharedUI.DataView.Columns[2].Index].Value)), _0024VB_0024Local_Partition, TextCompare: false) == 0)
				{
					if (Operators.CompareString(_0024VB_0024Local_Size, "0xFFFFFFFF", TextCompare: false) != 0)
					{
						item.Cells[SPDR.SharedUI.DataView.Columns[5].Index].Value = _0024VB_0024Local_Size + "MB";
					}
				}
				else if (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(item.Cells[SPDR.SharedUI.DataView.Columns[2].Index].Value)), "uboot", TextCompare: false) == 0)
				{
					item.Cells[SPDR.SharedUI.DataView.Columns[5].Index].Value = "1MB";
				}
				else if (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(item.Cells[SPDR.SharedUI.DataView.Columns[2].Index].Value)), "splloader", TextCompare: false) == 0)
				{
					item.Cells[SPDR.SharedUI.DataView.Columns[5].Index].Value = "1MB";
				}
			}
			checked
			{
				foreach (DataGridViewRow item2 in (IEnumerable)SPDR.SharedUI.DataView.Rows)
				{
					if (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(item2.Cells[SPDR.SharedUI.DataView.Columns[5].Index].Value)), "0xFFFFFFFF", TextCompare: false) == 0)
					{
						int num = 1;
						while (uni.StrToSize(num.ToString()) <= Convert.ToUInt64(RuntimeHelpers.GetObjectValue(item2.Cells[SPDR.SharedUI.DataView.Columns[4].Index].Value)))
						{
							num++;
						}
						item2.Cells[SPDR.SharedUI.DataView.Columns[5].Index].Value = Conversions.ToString(num - 1) + "MB";
					}
				}
			}
		}
	}

	public static string pacfile = null;

	public static string outputDir = null;

	public static bool debug = false;

	private static int partitionCount = 0;

	private static int currentCount = 0;

	public static Dictionary<string, object> PAC_HEADER = new Dictionary<string, object>
	{
		{
			"szVersion",
			string.Empty
		},
		{ "dwHiSize", 0 },
		{ "dwLoSize", 0 },
		{
			"productName",
			string.Empty
		},
		{
			"firmwareName",
			string.Empty
		},
		{ "partitionCount", 0 },
		{ "partitionsListStart", 0 },
		{ "dwMode", 0 },
		{ "dwFlashType", 0 },
		{ "dwNandStrategy", 0 },
		{ "dwIsNvBackup", 0 },
		{ "dwNandPageType", 0 },
		{
			"szPrdAlias",
			string.Empty
		},
		{ "dwOmaDmProductFlag", 0 },
		{ "dwIsOmaDM", 0 },
		{ "dwIsPreload", 0 },
		{ "dwReserved", 0 },
		{ "dwMagic", 0 },
		{ "wCRC1", 0 },
		{ "wCRC2", 0 }
	};

	public static Dictionary<string, object> FILE_HEADER = new Dictionary<string, object>
	{
		{ "length", 0 },
		{
			"partitionName",
			string.Empty
		},
		{
			"fileName",
			string.Empty
		},
		{
			"szFileName",
			string.Empty
		},
		{ "hiPartitionSize", 0 },
		{ "hiDataOffset", 0 },
		{ "loPartitionSize", 0 },
		{ "nFileFlag", 0 },
		{ "nCheckFlag", 0 },
		{ "loDataOffset", 0 },
		{ "dwCanOmitFlag", 0 },
		{ "dwAddrNum", 0 },
		{ "dwAddr", 0 },
		{ "dwReserved", 0 }
	};

	public static void Abort(string msg)
	{
		SPDR.TxtPacFirmware = string.Empty;
		WorkerDownload.UniFirmware = string.Empty;
	}

	public static string GetString(byte[] bytes)
	{
		return Encoding.Unicode.GetString(bytes).TrimEnd(default(char));
	}

	public static void PrintP(string name, object value)
	{
		Console.WriteLine($"{name,-13} = {RuntimeHelpers.GetObjectValue(value)}");
	}

	public static void PrintPacHeader(Dictionary<string, object> pacHeader)
	{
		if (Operators.CompareString(SPDR.String_13, "debug", TextCompare: false) == 0)
		{
			UiManager.Richlogs("- Firmware Name  : ", Color.Black, isBold: false);
			UiManager.Richlogs(string.Format("{0}", RuntimeHelpers.GetObjectValue(pacHeader["firmwareName"])), Color.FromArgb(0, 85, 207), isBold: true, NextLine: true);
			UiManager.Richlogs("- Firmware Product : ", Color.Black, isBold: false);
			UiManager.Richlogs(string.Format("{0}", RuntimeHelpers.GetObjectValue(pacHeader["productName"])), Color.FromArgb(0, 85, 207), isBold: true, NextLine: true);
			UiManager.Richlogs("- Firmware Version : ", Color.Black, isBold: false);
			UiManager.Richlogs(string.Format("{0}", RuntimeHelpers.GetObjectValue(pacHeader["szVersion"])), Color.FromArgb(0, 85, 207), isBold: true, NextLine: true);
		}
		PrintP("Version", RuntimeHelpers.GetObjectValue(pacHeader["szVersion"]));
		checked
		{
			if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(pacHeader["dwHiSize"])) == 0)
			{
				if (Operators.CompareString(SPDR.String_13, "debug", TextCompare: false) == 0)
				{
					UiManager.Richlogs("- Firmware Size : ", Color.Black, isBold: false);
					UiManager.Richlogs(string.Format("{0}", UiManager.GetFileSizess(Convert.ToInt64(RuntimeHelpers.GetObjectValue(pacHeader["dwLoSize"])))), Color.FromArgb(0, 85, 207));
				}
				PrintP("Size", RuntimeHelpers.GetObjectValue(pacHeader["dwLoSize"]));
			}
			else
			{
				if (Operators.CompareString(SPDR.String_13, "debug", TextCompare: false) == 0)
				{
					UiManager.Richlogs("- Firmware Size : ", Color.Black, isBold: false);
					UiManager.Richlogs(string.Format("{0}", UiManager.GetFileSizess(Convert.ToInt64(RuntimeHelpers.GetObjectValue(pacHeader["dwHiSize"])) + Convert.ToInt64(RuntimeHelpers.GetObjectValue(pacHeader["dwLoSize"])))), Color.FromArgb(0, 85, 207));
				}
				PrintP("Size", Convert.ToInt64(RuntimeHelpers.GetObjectValue(pacHeader["dwHiSize"])) + Convert.ToInt64(RuntimeHelpers.GetObjectValue(pacHeader["dwLoSize"])));
			}
			PrintP("PrdName", RuntimeHelpers.GetObjectValue(pacHeader["productName"]));
			PrintP("FirmwareName", RuntimeHelpers.GetObjectValue(pacHeader["firmwareName"]));
			PrintP("FileCount", RuntimeHelpers.GetObjectValue(pacHeader["partitionCount"]));
			PrintP("FileOffset", RuntimeHelpers.GetObjectValue(pacHeader["partitionsListStart"]));
			PrintP("Mode", RuntimeHelpers.GetObjectValue(pacHeader["dwMode"]));
			PrintP("FlashType", RuntimeHelpers.GetObjectValue(pacHeader["dwFlashType"]));
			PrintP("NandStrategy", RuntimeHelpers.GetObjectValue(pacHeader["dwNandStrategy"]));
			PrintP("IsNvBackup", RuntimeHelpers.GetObjectValue(pacHeader["dwIsNvBackup"]));
			PrintP("NandPageType", RuntimeHelpers.GetObjectValue(pacHeader["dwNandPageType"]));
			PrintP("PrdAlias", RuntimeHelpers.GetObjectValue(pacHeader["szPrdAlias"]));
			PrintP("OmaDmPrdFlag", RuntimeHelpers.GetObjectValue(pacHeader["dwOmaDmProductFlag"]));
			PrintP("IsOmaDM", RuntimeHelpers.GetObjectValue(pacHeader["dwIsOmaDM"]));
			PrintP("IsPreload", RuntimeHelpers.GetObjectValue(pacHeader["dwIsPreload"]));
			PrintP("Magic", "0x" + Convert.ToInt64(RuntimeHelpers.GetObjectValue(pacHeader["dwMagic"])).ToString("X").ToLower());
			PrintP("CRC1", RuntimeHelpers.GetObjectValue(pacHeader["wCRC1"]));
			PrintP("CRC2", RuntimeHelpers.GetObjectValue(pacHeader["wCRC2"]));
		}
	}

	public static Dictionary<string, object> ParsePacHeader(BinaryReader reader, string pacfile, bool debug)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>(PAC_HEADER);
		GCHandle gCHandle = GCHandle.Alloc(reader.ReadBytes(Marshal.SizeOf(typeof(PacHeaderStruct))), GCHandleType.Pinned);
		PacHeaderStruct pacHeaderStruct = (PacHeaderStruct)Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), typeof(PacHeaderStruct));
		gCHandle.Free();
		dictionary["szVersion"] = GetString(pacHeaderStruct.szVersion);
		dictionary["dwHiSize"] = pacHeaderStruct.dwHiSize;
		dictionary["dwLoSize"] = pacHeaderStruct.dwLoSize;
		dictionary["productName"] = GetString(pacHeaderStruct.productName);
		dictionary["firmwareName"] = GetString(pacHeaderStruct.firmwareName);
		dictionary["partitionCount"] = pacHeaderStruct.partitionCount;
		dictionary["partitionsListStart"] = pacHeaderStruct.partitionsListStart;
		dictionary["dwMode"] = pacHeaderStruct.dwMode;
		dictionary["dwFlashType"] = pacHeaderStruct.dwFlashType;
		dictionary["dwNandStrategy"] = pacHeaderStruct.dwNandStrategy;
		dictionary["dwIsNvBackup"] = pacHeaderStruct.dwIsNvBackup;
		dictionary["dwNandPageType"] = pacHeaderStruct.dwNandPageType;
		dictionary["szPrdAlias"] = GetString(pacHeaderStruct.szPrdAlias);
		dictionary["dwOmaDmProductFlag"] = pacHeaderStruct.dwOmaDmProductFlag;
		dictionary["dwIsOmaDM"] = pacHeaderStruct.dwIsOmaDM;
		dictionary["dwIsPreload"] = pacHeaderStruct.dwIsPreload;
		dictionary["dwReserved"] = pacHeaderStruct.dwReserved;
		dictionary["dwMagic"] = pacHeaderStruct.dwMagic;
		dictionary["wCRC1"] = pacHeaderStruct.wCRC1;
		dictionary["wCRC2"] = pacHeaderStruct.wCRC2;
		if (debug)
		{
			if (Operators.CompareString(SPDR.String_13, "debug", TextCompare: false) == 0)
			{
				UiManager.Richlogs("- Get Firmware Information : ", Color.Black, isBold: false);
				UiManager.Richlogs("OK", Color.FromArgb(0, 85, 207), isBold: true, NextLine: true);
			}
			PrintPacHeader(dictionary);
		}
		if (Operators.CompareString((string)dictionary["szVersion"], "BP_R1.0.0", TextCompare: false) != 0 && Operators.CompareString((string)dictionary["szVersion"], "BP_R2.0.1", TextCompare: false) != 0)
		{
			Abort("Unsupported PAC version");
		}
		long num = (uint)dictionary["dwHiSize"];
		ulong num2 = Convert.ToUInt64(decimal.Add(d2: new decimal((ulong)(uint)dictionary["dwLoSize"]), d1: new decimal((ulong)(num << 32))));
		FileInfo fileInfo = new FileInfo(pacfile);
		if (num2 != checked((ulong)fileInfo.Length))
		{
			Abort("Bin packet's size is not correct");
		}
		return dictionary;
	}

	public static void PrintFileHeader(Dictionary<string, object> fileHeader)
	{
		PrintP("Size", RuntimeHelpers.GetObjectValue(fileHeader["length"]));
		PrintP("FileID", RuntimeHelpers.GetObjectValue(fileHeader["partitionName"]));
		PrintP("FileName", RuntimeHelpers.GetObjectValue(fileHeader["fileName"]));
		checked
		{
			if (Convert.ToInt64(RuntimeHelpers.GetObjectValue(fileHeader["hiPartitionSize"])) == 0L)
			{
				PrintP("FileSize", RuntimeHelpers.GetObjectValue(fileHeader["loPartitionSize"]));
			}
			else
			{
				PrintP("FileSize", Convert.ToInt64(RuntimeHelpers.GetObjectValue(fileHeader["hiPartitionSize"])) + Convert.ToInt64(RuntimeHelpers.GetObjectValue(fileHeader["loPartitionSize"])));
			}
			PrintP("FileFlag", RuntimeHelpers.GetObjectValue(fileHeader["nFileFlag"]));
			PrintP("CheckFlag", RuntimeHelpers.GetObjectValue(fileHeader["nCheckFlag"]));
			if (Convert.ToInt64(RuntimeHelpers.GetObjectValue(fileHeader["hiDataOffset"])) == 0L)
			{
				PrintP("DataOffset", RuntimeHelpers.GetObjectValue(fileHeader["loDataOffset"]));
			}
			else
			{
				PrintP("DataOffset", Convert.ToInt64(RuntimeHelpers.GetObjectValue(fileHeader["hiDataOffset"])) + Convert.ToInt64(RuntimeHelpers.GetObjectValue(fileHeader["loDataOffset"])));
			}
			PrintP("CanOmitFlag", RuntimeHelpers.GetObjectValue(fileHeader["dwCanOmitFlag"]));
		}
	}

	public static void ParseFiles(BinaryReader reader, List<Dictionary<string, object>> fileHeaders, bool debug)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>(FILE_HEADER);
		GCHandle gCHandle = GCHandle.Alloc(reader.ReadBytes(Marshal.SizeOf(typeof(FileHeaderStruct))), GCHandleType.Pinned);
		FileHeaderStruct fileHeaderStruct = (FileHeaderStruct)Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), typeof(FileHeaderStruct));
		gCHandle.Free();
		ushort num = 0;
		if (fileHeaderStruct.nFileFlag > 0)
		{
			num = 1;
		}
		ushort num2 = 0;
		if (fileHeaderStruct.nCheckFlag > 0)
		{
			num2 = 1;
		}
		uint num3 = 0u;
		uint num4 = 0u;
		if ((long)fileHeaderStruct.hiDataOffset > 0L)
		{
			num3 = 0u;
			num4 = fileHeaderStruct.hiDataOffset;
		}
		dictionary["length"] = fileHeaderStruct.length;
		dictionary["partitionName"] = GetString(fileHeaderStruct.partitionName);
		dictionary["fileName"] = GetString(fileHeaderStruct.fileName);
		dictionary["szFileName"] = GetString(fileHeaderStruct.szFileName);
		dictionary["hiPartitionSize"] = fileHeaderStruct.hiPartitionSize;
		dictionary["entahSize1"] = fileHeaderStruct.entahSize1;
		dictionary["entahSize2"] = fileHeaderStruct.entahSize2;
		dictionary["hiDataOffset"] = num4;
		dictionary["loPartitionSize"] = fileHeaderStruct.loPartitionSize;
		dictionary["nFileFlag"] = num;
		dictionary["nCheckFlag"] = num2;
		dictionary["loDataOffset"] = num3;
		dictionary["dwCanOmitFlag"] = fileHeaderStruct.dwCanOmitFlag;
		dictionary["dwAddrNum"] = fileHeaderStruct.dwAddrNum;
		dictionary["dwAddr"] = fileHeaderStruct.dwAddr;
		dictionary["dwReserved"] = fileHeaderStruct.dwReserved;
		Convert.ToInt32(RuntimeHelpers.GetObjectValue(dictionary["length"]));
		Marshal.SizeOf(typeof(FileHeaderStruct));
		if (debug)
		{
			PrintFileHeader(dictionary);
		}
		fileHeaders.Add(dictionary);
	}

	public static void UnpackPacFile(string pacfile, string outputDir, bool debug)
	{
		_Closure_0024__16_002D1 arg = default( _Closure_0024__16_002D1);
		arg._0024VB_0024Local_outputDir = outputDir;
		checked
		{
			using BinaryReader binaryReader = new BinaryReader(File.Open(pacfile, FileMode.Open));
			Dictionary<string, object> dictionary = ParsePacHeader(binaryReader, pacfile, debug);
			partitionCount = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dictionary["partitionCount"]));
			int num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dictionary["partitionsListStart"]));
			binaryReader.BaseStream.Seek(num, SeekOrigin.Begin);
			List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
			int num2 = partitionCount - 1;
			for (int i = 0; i <= num2; i++)
			{
				ParseFiles(binaryReader, list, debug);
			}
			_Closure_0024__16_002D0 closure_0024__16_002D = default(_Closure_0024__16_002D0);
			foreach (Dictionary<string, object> item in list)
			{
				closure_0024__16_002D = new _Closure_0024__16_002D0(closure_0024__16_002D);
				closure_0024__16_002D._0024VB_0024NonLocal__0024VB_0024Closure_2 = arg;
				closure_0024__16_002D._0024VB_0024Local_partitionName = (string)item["partitionName"];
				closure_0024__16_002D._0024VB_0024Local_fileName = (string)item["fileName"];
				closure_0024__16_002D._0024VB_0024Local_loDataOffset = (uint)item["loDataOffset"];
				closure_0024__16_002D._0024VB_0024Local_hiDataOffset = (uint)item["hiDataOffset"];
				closure_0024__16_002D._0024VB_0024Local_loPartitionSize = (uint)item["loPartitionSize"];
				closure_0024__16_002D._0024VB_0024Local_hiPartitionSize = (uint)item["hiPartitionSize"];
				if (Operators.CompareString(SPDR.String_13, "debug", TextCompare: false) == 0 && decimal.Compare(new decimal(closure_0024__16_002D._0024VB_0024Local_hiDataOffset + closure_0024__16_002D._0024VB_0024Local_loDataOffset), 0m) > 0 && !closure_0024__16_002D._0024VB_0024Local_fileName.Contains(".xml") && !closure_0024__16_002D._0024VB_0024Local_partitionName.Contains("FDL"))
				{
					if (closure_0024__16_002D._0024VB_0024Local_fileName.ToLower().Contains("nv") || closure_0024__16_002D._0024VB_0024Local_partitionName.ToLower().Contains("nv"))
					{
						SPDR.SharedUI.DataView.Invoke(new Action(closure_0024__16_002D._Lambda_0024__0));
					}
					else
					{
						SPDR.SharedUI.DataView.Invoke(new Action(closure_0024__16_002D._Lambda_0024__1));
					}
				}
			}
			ExtractFiles(binaryReader, list, arg._0024VB_0024Local_outputDir);
			currentCount = 0;
		}
	}

	public static void ExtractFiles(BinaryReader reader, List<Dictionary<string, object>> fileHeaders, string outputDir)
	{
		checked
		{
			UiManager.ProcessBar1n(currentCount, partitionCount - 1);
			foreach (Dictionary<string, object> fileHeader in fileHeaders)
			{
				string text = (string)fileHeader["fileName"];
				string text2 = (string)fileHeader["partitionName"];
				ulong num = (uint)fileHeader["loDataOffset"];
				ulong num2 = (uint)fileHeader["hiDataOffset"];
				ulong num3 = (uint)fileHeader["loPartitionSize"];
				ulong num4 = (uint)fileHeader["hiPartitionSize"];
				if (!string.IsNullOrEmpty(text))
				{
					ulong num5 = num2 + num;
					ulong num6 = num4 + num3;
					bool flag = true;
					if (num6 < uni.StrToSize("1M"))
					{
						flag = false;
					}
					if (flag)
					{
						int num7 = 1;
						while (true)
						{
							if (uni.StrToSize(num7 + "K") == num6)
							{
								num6 = uni.StrToSize(Convert.ToString(num7 - 1) + "K");
								break;
							}
							if (uni.StrToSize(num7 + "K") > num6)
							{
								num6 = uni.StrToSize(Convert.ToString(num7 - 1) + "K");
								break;
							}
							num7++;
						}
					}
					reader.BaseStream.Seek((long)num5, SeekOrigin.Begin);
					byte[] bytes = reader.ReadBytes((int)num6);
					string path = Path.Combine(outputDir, text);
					if (File.Exists(path))
					{
						File.Delete(path);
					}
					File.WriteAllBytes(path, bytes);
					if (text.Contains("xml"))
					{
						WorkerDownload.UniFileXML = outputDir + "\\" + text;
						ScanXMLFile(Encoding.UTF8.GetString(bytes));
					}
					if (Operators.CompareString(text2.ToLower(), "fdl", TextCompare: false) == 0)
					{
						uni.fdl1_location = outputDir + "\\" + text;
						SPDR.TxtFDL1 = text;
					}
					if (Operators.CompareString(text2.ToLower(), "fdl2", TextCompare: false) == 0)
					{
						uni.fdl2_location = outputDir + "\\" + text;
						SPDR.TxtFDL2 = text;
					}
				}
				currentCount++;
				UiManager.ProcessBar1n(currentCount, partitionCount - 1);
			}
		}
	}

	public static void ScanXMLFile(string XMLData)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(XMLData);
		XmlNode xmlNode = xmlDocument.SelectSingleNode("/BMAConfig/SchemeList/Scheme");
		_ = xmlNode.Attributes["name"].Value;
		XmlNodeList xmlNodeList = xmlNode.SelectNodes("File");
		_Closure_0024__18_002D0 closure_0024__18_002D = default(_Closure_0024__18_002D0);
		foreach (XmlNode item in xmlNodeList)
		{
			closure_0024__18_002D = new _Closure_0024__18_002D0(closure_0024__18_002D);
			closure_0024__18_002D._0024VB_0024Local_id = item.SelectSingleNode("ID").InnerText;
			string innerText = item.SelectSingleNode("IDAlias").InnerText;
			string innerText2 = item.SelectSingleNode("Type").InnerText;
			XmlNode xmlNode3 = item.SelectSingleNode("Block");
			closure_0024__18_002D._0024VB_0024Local_blockId = string.Empty;
			if (xmlNode3.Attributes["id"] != null)
			{
				closure_0024__18_002D._0024VB_0024Local_blockId = xmlNode3.Attributes["id"].Value;
			}
			string innerText3 = xmlNode3.SelectSingleNode("Base").InnerText;
			string innerText4 = xmlNode3.SelectSingleNode("Size").InnerText;
			string innerText5 = item.SelectSingleNode("Flag").InnerText;
			string innerText6 = item.SelectSingleNode("CheckFlag").InnerText;
			string innerText7 = item.SelectSingleNode("Description").InnerText;
			Console.WriteLine($"ID: {closure_0024__18_002D._0024VB_0024Local_id}");
			Console.WriteLine($"IDAlias: {innerText}");
			Console.WriteLine($"Type: {innerText2}");
			Console.WriteLine($"Block ID: {closure_0024__18_002D._0024VB_0024Local_blockId}");
			Console.WriteLine($"Base Address: {innerText3}");
			Console.WriteLine($"Size: {innerText4}");
			Console.WriteLine($"Flag: {innerText5}");
			Console.WriteLine($"CheckFlag: {innerText6}");
			Console.WriteLine($"Description: {innerText7}");
			Console.WriteLine();
			SPDR.SharedUI.DataView.Invoke(new Action(closure_0024__18_002D._Lambda_0024__0));
			if (Operators.CompareString(innerText, "FDL1", TextCompare: false) == 0)
			{
				uni.fdl1_addr = innerText3;
				SPDR.TxtFDL1Address = innerText3;
			}
			else if (Operators.CompareString(innerText, "FDL2", TextCompare: false) == 0)
			{
				uni.fdl2_addr = innerText3;
				SPDR.TxtFDL2Address = innerText3;
			}
		}
		XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(XMLData));
		_Closure_0024__18_002D1 closure_0024__18_002D2 = default(_Closure_0024__18_002D1);
		while (xmlTextReader.Read())
		{
			if (xmlTextReader.NodeType == XmlNodeType.Element && Operators.CompareString(xmlTextReader.Name, "Partition", TextCompare: false) == 0)
			{
				closure_0024__18_002D2 = new _Closure_0024__18_002D1(closure_0024__18_002D2);
				closure_0024__18_002D2._0024VB_0024Local_Partition = xmlTextReader.GetAttribute("id");
				closure_0024__18_002D2._0024VB_0024Local_Size = xmlTextReader.GetAttribute("size");
				SPDR.SharedUI.DataView.Invoke(new Action(closure_0024__18_002D2._Lambda_0024__1));
				Console.WriteLine("Partition Name :" + closure_0024__18_002D2._0024VB_0024Local_Partition + " Size : " + closure_0024__18_002D2._0024VB_0024Local_Size);
			}
		}
		SPDR.SharedUI.DataView.Invoke((Action)checked([SpecialName] () =>
		{
			foreach (DataGridViewRow item2 in (IEnumerable)SPDR.SharedUI.DataView.Rows)
			{
				if (string.IsNullOrEmpty(Convert.ToString(RuntimeHelpers.GetObjectValue(item2.Cells[SPDR.SharedUI.DataView.Columns[5].Index].Value))))
				{
					int i;
					for (i = 1; uni.StrToSize(Conversions.ToString(i) + "M") <= Convert.ToUInt64(RuntimeHelpers.GetObjectValue(item2.Cells[SPDR.SharedUI.DataView.Columns[4].Index].Value)); i++)
					{
					}
					item2.Cells[SPDR.SharedUI.DataView.Columns[5].Index].Value = Conversions.ToString(i - 1) + "MB";
				}
			}
		}));
	}

	public static string GetPartitionNames(string Partition)
	{
		return Partition.ToLower();
	}

	public static void StartExtraction(string[] args)
	{
		if (args.Length >= 2)
		{
			pacfile = args[0];
			outputDir = args[1];
			debug = false;
			if (args.Length >= 3 && Operators.CompareString(args[2], "-debug", TextCompare: false) == 0)
			{
				debug = true;
			}
			UnpackPacFile(pacfile, outputDir, debug);
		}
	}
}
