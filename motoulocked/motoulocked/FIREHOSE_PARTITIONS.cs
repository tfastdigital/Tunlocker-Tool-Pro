using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.motoulocked;

[StandardModule]
internal sealed class FIREHOSE_PARTITIONS
{
	public static bool isFHCmd { get; set; } = false;


	public static long Bulat(double number)
	{
		return checked((long)Math.Round(0.0 - Math.Floor(0.0 - number)));
	}

	public static bool CekSparse(byte[] DataFiles)
	{
		if (DataFiles.Length == 0)
		{
			return false;
		}
		Stream stream = new MemoryStream(DataFiles);
		byte[] array = new byte[1025];
		using BinaryReader binaryReader = new BinaryReader(stream);
		binaryReader.Read(array, 0, 28);
		FIREHOSE.sparseheader = FIREHOSE.parsingheader(array);
		int dwMagic = FIREHOSE.sparseheader.dwMagic;
		if (checked((long)Math.Round(Conversion.Val("&HE" + Conversion.Hex(dwMagic)))) == 64108298042L)
		{
			FIREHOSE.totalchunk = FIREHOSE.sparseheader.dwTotalChunks;
			stream.Close();
			binaryReader.Close();
			return true;
		}
		stream.Close();
		binaryReader.Close();
		return false;
	}

	public static bool WritePartition(string sector_size, string num_partition_sector, string physical_partition_number, string start_sector, ref string label, string filename, bool silent = false)
	{
		UiManager.hide_writen_transfer(hidden: false);
		FIREHOSE_MANAGER.RefreshDisk();
		string msg = "";
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		byte[] array = new byte[16385];
		Stream stream = new MemoryStream(array);
		if (FIREHOSE_OPERATIONS.MenuEx == FIREHOSE_OPERATIONS.MenuEksekusi.manual)
		{
			if (!File.Exists(filename))
			{
				return false;
			}
			FileInfo fileInfo = new FileInfo(filename);
			num4 = fileInfo.Length;
			UiManager.label_totalsize(fileInfo.Length);
			stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
			stream.Seek(0L, SeekOrigin.Begin);
			stream.Read(array, 0, array.Length);
			msg = Path.GetFileName(filename);
		}
		else if (FIREHOSE_OPERATIONS.MenuEx == FIREHOSE_OPERATIONS.MenuEksekusi.oneclick)
		{
			stream = new MemoryStream(FIREHOSE_MANAGER.FilesOneClick);
			stream.Seek(0L, SeekOrigin.Begin);
			stream.Read(array, 0, array.Length);
			msg = "Data";
			num4 = FIREHOSE_MANAGER.FilesOneClick.Length;
			UiManager.label_totalsize(FIREHOSE_MANAGER.FilesOneClick.Length);
		}
		stream.Seek(0L, SeekOrigin.Begin);
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		checked
		{
			int num12;
			if (CekSparse(array))
			{
				if (!silent)
				{
					UiManager.Richlogs("- Writing Partition [", Color.Black, isBold: false);
					UiManager.Richlogs(msg, Color.Lime);
					UiManager.Richlogs("] -> [", Color.Black, isBold: false);
					UiManager.Richlogs(label, Color.Lime);
					UiManager.Richlogs("] #Sparse : ", Color.Black, isBold: false);
				}
				int num6 = 0;
				long num7 = 0L;
				long num8 = 0L;
				if (FIREHOSE.totalchunk <= 0)
				{
					stream.Close();
					return false;
				}
				int num9 = 0;
				using BinaryReader binaryReader = new BinaryReader(stream);
				byte[] array2 = new byte[1025];
				FIREHOSE.chunkheader = default(FIREHOSE.CHUNK_HEADER);
				while (true)
				{
					double num10;
					long num11;
					if (num9 == 0)
					{
						binaryReader.BaseStream.Seek(28L, SeekOrigin.Begin);
						binaryReader.Read(array2, 0, 12);
						FIREHOSE.chunkheader.wChunkType = BitConverter.ToInt16(array2.Skip(0).Take(2).ToArray(), 0);
						FIREHOSE.chunkheader.dwChunkSize = BitConverter.ToInt32(array2.Skip(4).Take(4).ToArray(), 0);
						FIREHOSE.chunkheader.dwTotalSize = BitConverter.ToInt32(array2.Skip(8).Take(4).ToArray(), 0);
						short wChunkType = FIREHOSE.chunkheader.wChunkType;
						num10 = Conversion.Val("&HE" + Convert.ToString(wChunkType, 16).ToUpper());
						num11 = unchecked((long)FIREHOSE.chunkheader.dwChunkSize) * unchecked((long)FIREHOSE.sparseheader.dwBlockSize);
						num += FIREHOSE.chunkheader.dwTotalSize;
						num2 = 0L;
					}
					else
					{
						binaryReader.BaseStream.Seek(num + 28, SeekOrigin.Begin);
						binaryReader.Read(array2, 0, 12);
						FIREHOSE.chunkheader.wChunkType = BitConverter.ToInt16(array2.Skip(0).Take(12).ToArray(), 0);
						FIREHOSE.chunkheader.dwChunkSize = BitConverter.ToInt32(array2.Skip(4).Take(4).ToArray(), 0);
						FIREHOSE.chunkheader.dwTotalSize = BitConverter.ToInt32(array2.Skip(8).Take(4).ToArray(), 0);
						short wChunkType2 = FIREHOSE.chunkheader.wChunkType;
						num10 = Conversion.Val("&HE" + Convert.ToString(wChunkType2, 16).ToUpper());
						num += FIREHOSE.chunkheader.dwTotalSize;
						num11 = unchecked((long)FIREHOSE.chunkheader.dwChunkSize) * unchecked((long)FIREHOSE.sparseheader.dwBlockSize);
						num2 = (long)Math.Round((double)num2 + (double)num11 / Convert.ToDouble(sector_size));
					}
					if (num10 == 969409.0)
					{
						num6++;
						num12 = 524288;
						long num13 = (long)Math.Round((double)num11 / Convert.ToDouble(sector_size));
						long num14 = 0L;
						if (num11 <= 524288)
						{
							num12 = (int)num11;
						}
						int num15 = 0;
						string xml = FIREHOSE.pkt_Program(sector_size, Convert.ToString(num13), physical_partition_number, Convert.ToString(Convert.ToDouble(start_sector) + (double)num7));
						num7 += num13;
						FIREHOSE_PACKET.SendXml(xml);
						if (!FIREHOSE_RESPONSE.IsAck(silent: true))
						{
							stopwatch.Stop();
							FIREHOSE_MANAGER.RefreshDisk();
							return false;
						}
						while (true)
						{
							if (num11 - num14 < num12)
							{
								num12 = (int)(num11 - num14);
							}
							if (num14 == num11 && FIREHOSE_RESPONSE.IsAck(silent: true))
							{
								break;
							}
							byte[] array3 = new byte[num12 - 1 + 1];
							binaryReader.Read(array3, 0, num12);
							DiskWriter.DiskWrite(array3);
							num8 += array3.Length;
							num14 += array3.Length;
							num15 += array3.Length;
							num5 += array3.Length;
							UiManager.label_writensize(num5);
							TimeSpan elapsed = stopwatch.Elapsed;
							UiManager.label_transferrate((double)array3.Length / elapsed.TotalSeconds);
							UiManager.ProcessBar1(num14, num11);
						}
						stopwatch.Stop();
					}
					else if (num10 == 969410.0)
					{
						long num16 = (long)Math.Round((double)num11 / Convert.ToDouble(sector_size));
						num7 += num16;
					}
					else if (num10 == 969411.0)
					{
						long num17 = (long)Math.Round((double)num11 / Convert.ToDouble(sector_size));
						num7 += num17;
					}
					num9++;
					if (num9 == FIREHOSE.totalchunk)
					{
						break;
					}
					UiManager.ProcessBar2(num9, FIREHOSE.totalchunk);
				}
				UiManager.ProcessBar2(num9, FIREHOSE.totalchunk);
				stream.Close();
				binaryReader.Close();
				return true;
			}
			if (!silent)
			{
				UiManager.Richlogs("- Writing Partition [", Color.Black, isBold: false);
				UiManager.Richlogs(msg, Color.Lime);
				UiManager.Richlogs("] -> [", Color.Black, isBold: false);
				UiManager.Richlogs(label, Color.Lime);
				UiManager.Richlogs("] : ", Color.Black, isBold: false);
			}
			stream.Seek(0L, SeekOrigin.Begin);
			num12 = 8192;
			if (num4 >= 16777216)
			{
				num12 = int.Parse(FIREHOSE_MANAGER.MaxPayloadSizeToTargetInBytes);
			}
			long num18 = Bulat((double)num4 / Convert.ToDouble(sector_size));
			double num19 = (double)num18 * Convert.ToDouble(sector_size);
			if ((double)num4 < Convert.ToDouble(sector_size))
			{
				num18 = 1L;
				num19 = Convert.ToDouble(sector_size);
				num12 = Convert.ToInt32(sector_size);
			}
			FIREHOSE_PACKET.SendXml(FIREHOSE.pkt_Program(sector_size, Convert.ToString(num18), physical_partition_number, start_sector));
			if (FIREHOSE_RESPONSE.IsAck(silent: true))
			{
				using (BinaryReader binaryReader2 = new BinaryReader(stream))
				{
					while (num19 != (double)num3)
					{
						if (num19 - (double)num3 < (double)num12)
						{
							num12 = (int)Math.Round(num19 - (double)num3);
							byte[] array4 = new byte[num12 - 1 + 1];
							binaryReader2.Read(array4, 0, num12);
							DiskWriter.DiskWrite(array4);
							num3 += array4.Length;
							UiManager.label_writensize(num3);
							UiManager.label_transferrate((double)num3 / stopwatch.Elapsed.TotalSeconds);
							UiManager.ProcessBar1(num3, (long)Math.Round(num19));
						}
						else
						{
							byte[] array5 = new byte[num12 - 1 + 1];
							binaryReader2.Read(array5, 0, num12);
							DiskWriter.DiskWrite(array5);
							num3 += array5.Length;
							UiManager.label_writensize(num3);
							UiManager.label_transferrate((double)num3 / stopwatch.Elapsed.TotalSeconds);
							UiManager.ProcessBar1(num3, (long)Math.Round(num19));
						}
					}
					stopwatch.Stop();
					if (FIREHOSE_RESPONSE.IsAck(silent: true))
					{
						binaryReader2.Close();
						return true;
					}
					binaryReader2.Close();
					return false;
				}
			}
			return false;
		}
	}

	public static bool Write_misc(string sector_size, string num_partition_sector, string physical_partition_number, string start_sector, ref string label, string filename, bool silent = false)
	{
		UiManager.hide_writen_transfer(hidden: false);
		FIREHOSE_MANAGER.RefreshDisk();
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		byte[] array = new byte[16385];
		Stream stream = new MemoryStream(array);
		if (FIREHOSE_OPERATIONS.MenuEx == FIREHOSE_OPERATIONS.MenuEksekusi.manual)
		{
			if (!File.Exists(filename))
			{
				return false;
			}
			FileInfo fileInfo = new FileInfo(filename);
			num4 = fileInfo.Length;
			UiManager.label_totalsize(fileInfo.Length);
			stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
			stream.Seek(0L, SeekOrigin.Begin);
			stream.Read(array, 0, array.Length);
			Path.GetFileName(filename);
		}
		else if (FIREHOSE_OPERATIONS.MenuEx == FIREHOSE_OPERATIONS.MenuEksekusi.oneclick)
		{
			stream = new MemoryStream(FIREHOSE_MANAGER.FilesOneClick);
			stream.Seek(0L, SeekOrigin.Begin);
			stream.Read(array, 0, array.Length);
			num4 = FIREHOSE_MANAGER.FilesOneClick.Length;
			UiManager.label_totalsize(FIREHOSE_MANAGER.FilesOneClick.Length);
		}
		stream.Seek(0L, SeekOrigin.Begin);
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		checked
		{
			int num12;
			if (CekSparse(array))
			{
				if (!silent)
				{
					UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
					if (EDL.SharedEDL.Guna2ComboBox1.SelectedIndex == 0)
					{
						UiManager.Richlogs("- Factory Reset By EXT4 : ", Color.Black, isBold: false);
					}
					else
					{
						UiManager.Richlogs("- Factory Reset By Misc : ", Color.Black, isBold: false);
					}
					Form1.SharedUI.ProgressBar1.Text = "Reseting...";
				}
				int num6 = 0;
				long num7 = 0L;
				long num8 = 0L;
				if (FIREHOSE.totalchunk <= 0)
				{
					stream.Close();
					return false;
				}
				int num9 = 0;
				using BinaryReader binaryReader = new BinaryReader(stream);
				byte[] array2 = new byte[1025];
				FIREHOSE.chunkheader = default(FIREHOSE.CHUNK_HEADER);
				while (true)
				{
					double num10;
					long num11;
					if (num9 == 0)
					{
						binaryReader.BaseStream.Seek(28L, SeekOrigin.Begin);
						binaryReader.Read(array2, 0, 12);
						FIREHOSE.chunkheader.wChunkType = BitConverter.ToInt16(array2.Skip(0).Take(2).ToArray(), 0);
						FIREHOSE.chunkheader.dwChunkSize = BitConverter.ToInt32(array2.Skip(4).Take(4).ToArray(), 0);
						FIREHOSE.chunkheader.dwTotalSize = BitConverter.ToInt32(array2.Skip(8).Take(4).ToArray(), 0);
						short wChunkType = FIREHOSE.chunkheader.wChunkType;
						num10 = Conversion.Val("&HE" + Convert.ToString(wChunkType, 16).ToUpper());
						num11 = unchecked((long)FIREHOSE.chunkheader.dwChunkSize) * unchecked((long)FIREHOSE.sparseheader.dwBlockSize);
						num += FIREHOSE.chunkheader.dwTotalSize;
						num2 = 0L;
					}
					else
					{
						binaryReader.BaseStream.Seek(num + 28, SeekOrigin.Begin);
						binaryReader.Read(array2, 0, 12);
						FIREHOSE.chunkheader.wChunkType = BitConverter.ToInt16(array2.Skip(0).Take(12).ToArray(), 0);
						FIREHOSE.chunkheader.dwChunkSize = BitConverter.ToInt32(array2.Skip(4).Take(4).ToArray(), 0);
						FIREHOSE.chunkheader.dwTotalSize = BitConverter.ToInt32(array2.Skip(8).Take(4).ToArray(), 0);
						short wChunkType2 = FIREHOSE.chunkheader.wChunkType;
						num10 = Conversion.Val("&HE" + Convert.ToString(wChunkType2, 16).ToUpper());
						num += FIREHOSE.chunkheader.dwTotalSize;
						num11 = unchecked((long)FIREHOSE.chunkheader.dwChunkSize) * unchecked((long)FIREHOSE.sparseheader.dwBlockSize);
						num2 = (long)Math.Round((double)num2 + (double)num11 / Convert.ToDouble(sector_size));
					}
					if (num10 == 969409.0)
					{
						num6++;
						num12 = 524288;
						long num13 = (long)Math.Round((double)num11 / Convert.ToDouble(sector_size));
						long num14 = 0L;
						if (num11 <= 524288)
						{
							num12 = (int)num11;
						}
						int num15 = 0;
						string xml = FIREHOSE.pkt_Program(sector_size, Convert.ToString(num13), physical_partition_number, Convert.ToString(Convert.ToDouble(start_sector) + (double)num7));
						num7 += num13;
						FIREHOSE_PACKET.SendXml(xml);
						if (!FIREHOSE_RESPONSE.IsAck(silent: true))
						{
							stopwatch.Stop();
							FIREHOSE_MANAGER.RefreshDisk();
							return false;
						}
						while (true)
						{
							if (num11 - num14 < num12)
							{
								num12 = (int)(num11 - num14);
							}
							if (num14 == num11 && FIREHOSE_RESPONSE.IsAck(silent: true))
							{
								break;
							}
							byte[] array3 = new byte[num12 - 1 + 1];
							binaryReader.Read(array3, 0, num12);
							DiskWriter.DiskWrite(array3);
							num8 += array3.Length;
							num14 += array3.Length;
							num15 += array3.Length;
							num5 += array3.Length;
							UiManager.label_writensize(num5);
							TimeSpan elapsed = stopwatch.Elapsed;
							UiManager.label_transferrate((double)array3.Length / elapsed.TotalSeconds);
							UiManager.ProcessBar1(num14, num11);
						}
						stopwatch.Stop();
					}
					else if (num10 == 969410.0)
					{
						long num16 = (long)Math.Round((double)num11 / Convert.ToDouble(sector_size));
						num7 += num16;
					}
					else if (num10 == 969411.0)
					{
						long num17 = (long)Math.Round((double)num11 / Convert.ToDouble(sector_size));
						num7 += num17;
					}
					num9++;
					if (num9 == FIREHOSE.totalchunk)
					{
						break;
					}
					UiManager.ProcessBar2(num9, FIREHOSE.totalchunk);
				}
				UiManager.ProcessBar2(num9, FIREHOSE.totalchunk);
				stream.Close();
				binaryReader.Close();
				return true;
			}
			if (!silent)
			{
				UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
				if (EDL.SharedEDL.Guna2ComboBox1.SelectedIndex == 0)
				{
					UiManager.Richlogs("- Factory Reset By EXT4 : ", Color.Black, isBold: false);
				}
				else
				{
					UiManager.Richlogs("- Factory Reset By Misc : ", Color.Black, isBold: false);
				}
				Form1.SharedUI.ProgressBar1.Text = "Reseting...";
			}
			stream.Seek(0L, SeekOrigin.Begin);
			num12 = 8192;
			if (num4 >= 16777216)
			{
				num12 = int.Parse(FIREHOSE_MANAGER.MaxPayloadSizeToTargetInBytes);
			}
			long num18 = Bulat((double)num4 / Convert.ToDouble(sector_size));
			double num19 = (double)num18 * Convert.ToDouble(sector_size);
			if ((double)num4 < Convert.ToDouble(sector_size))
			{
				num18 = 1L;
				num19 = Convert.ToDouble(sector_size);
				num12 = Convert.ToInt32(sector_size);
			}
			FIREHOSE_PACKET.SendXml(FIREHOSE.pkt_Program(sector_size, Convert.ToString(num18), physical_partition_number, start_sector));
			if (FIREHOSE_RESPONSE.IsAck(silent: true))
			{
				using (BinaryReader binaryReader2 = new BinaryReader(stream))
				{
					while (num19 != (double)num3)
					{
						if (num19 - (double)num3 < (double)num12)
						{
							num12 = (int)Math.Round(num19 - (double)num3);
							byte[] array4 = new byte[num12 - 1 + 1];
							binaryReader2.Read(array4, 0, num12);
							DiskWriter.DiskWrite(array4);
							num3 += array4.Length;
							UiManager.label_writensize(num3);
							UiManager.label_transferrate((double)num3 / stopwatch.Elapsed.TotalSeconds);
							UiManager.ProcessBar1(num3, (long)Math.Round(num19));
						}
						else
						{
							byte[] array5 = new byte[num12 - 1 + 1];
							binaryReader2.Read(array5, 0, num12);
							DiskWriter.DiskWrite(array5);
							num3 += array5.Length;
							UiManager.label_writensize(num3);
							UiManager.label_transferrate((double)num3 / stopwatch.Elapsed.TotalSeconds);
							UiManager.ProcessBar1(num3, (long)Math.Round(num19));
						}
					}
					stopwatch.Stop();
					if (FIREHOSE_RESPONSE.IsAck(silent: true))
					{
						binaryReader2.Close();
						return true;
					}
					binaryReader2.Close();
					return false;
				}
			}
			return false;
		}
	}

	public static bool Write_mi_data(string sector_size, string num_partition_sector, string physical_partition_number, string start_sector, ref string label, string filename, bool silent = false)
	{
		UiManager.hide_writen_transfer(hidden: false);
		FIREHOSE_MANAGER.RefreshDisk();
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		byte[] array = new byte[16385];
		Stream stream = new MemoryStream(array);
		if (FIREHOSE_OPERATIONS.MenuEx == FIREHOSE_OPERATIONS.MenuEksekusi.manual)
		{
			if (!File.Exists(filename))
			{
				return false;
			}
			FileInfo fileInfo = new FileInfo(filename);
			num4 = fileInfo.Length;
			UiManager.label_totalsize(fileInfo.Length);
			stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
			stream.Seek(0L, SeekOrigin.Begin);
			stream.Read(array, 0, array.Length);
			Path.GetFileName(filename);
		}
		else if (FIREHOSE_OPERATIONS.MenuEx == FIREHOSE_OPERATIONS.MenuEksekusi.oneclick)
		{
			stream = new MemoryStream(FIREHOSE_MANAGER.FilesOneClick);
			stream.Seek(0L, SeekOrigin.Begin);
			stream.Read(array, 0, array.Length);
			num4 = FIREHOSE_MANAGER.FilesOneClick.Length;
			UiManager.label_totalsize(FIREHOSE_MANAGER.FilesOneClick.Length);
		}
		stream.Seek(0L, SeekOrigin.Begin);
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		checked
		{
			int num12;
			if (CekSparse(array))
			{
				if (!silent)
				{
					UiManager.Richlogs("- Writing Mi Account Data : ", Color.Black, isBold: false);
				}
				int num6 = 0;
				long num7 = 0L;
				long num8 = 0L;
				if (FIREHOSE.totalchunk <= 0)
				{
					stream.Close();
					return false;
				}
				int num9 = 0;
				using BinaryReader binaryReader = new BinaryReader(stream);
				byte[] array2 = new byte[1025];
				FIREHOSE.chunkheader = default(FIREHOSE.CHUNK_HEADER);
				while (true)
				{
					double num10;
					long num11;
					if (num9 == 0)
					{
						binaryReader.BaseStream.Seek(28L, SeekOrigin.Begin);
						binaryReader.Read(array2, 0, 12);
						FIREHOSE.chunkheader.wChunkType = BitConverter.ToInt16(array2.Skip(0).Take(2).ToArray(), 0);
						FIREHOSE.chunkheader.dwChunkSize = BitConverter.ToInt32(array2.Skip(4).Take(4).ToArray(), 0);
						FIREHOSE.chunkheader.dwTotalSize = BitConverter.ToInt32(array2.Skip(8).Take(4).ToArray(), 0);
						short wChunkType = FIREHOSE.chunkheader.wChunkType;
						num10 = Conversion.Val("&HE" + Convert.ToString(wChunkType, 16).ToUpper());
						num11 = unchecked((long)FIREHOSE.chunkheader.dwChunkSize) * unchecked((long)FIREHOSE.sparseheader.dwBlockSize);
						num += FIREHOSE.chunkheader.dwTotalSize;
						num2 = 0L;
					}
					else
					{
						binaryReader.BaseStream.Seek(num + 28, SeekOrigin.Begin);
						binaryReader.Read(array2, 0, 12);
						FIREHOSE.chunkheader.wChunkType = BitConverter.ToInt16(array2.Skip(0).Take(12).ToArray(), 0);
						FIREHOSE.chunkheader.dwChunkSize = BitConverter.ToInt32(array2.Skip(4).Take(4).ToArray(), 0);
						FIREHOSE.chunkheader.dwTotalSize = BitConverter.ToInt32(array2.Skip(8).Take(4).ToArray(), 0);
						short wChunkType2 = FIREHOSE.chunkheader.wChunkType;
						num10 = Conversion.Val("&HE" + Convert.ToString(wChunkType2, 16).ToUpper());
						num += FIREHOSE.chunkheader.dwTotalSize;
						num11 = unchecked((long)FIREHOSE.chunkheader.dwChunkSize) * unchecked((long)FIREHOSE.sparseheader.dwBlockSize);
						num2 = (long)Math.Round((double)num2 + (double)num11 / Convert.ToDouble(sector_size));
					}
					if (num10 == 969409.0)
					{
						num6++;
						num12 = 524288;
						long num13 = (long)Math.Round((double)num11 / Convert.ToDouble(sector_size));
						long num14 = 0L;
						if (num11 <= 524288)
						{
							num12 = (int)num11;
						}
						int num15 = 0;
						string xml = FIREHOSE.pkt_Program(sector_size, Convert.ToString(num13), physical_partition_number, Convert.ToString(Convert.ToDouble(start_sector) + (double)num7));
						num7 += num13;
						FIREHOSE_PACKET.SendXml(xml);
						if (!FIREHOSE_RESPONSE.IsAck(silent: true))
						{
							stopwatch.Stop();
							FIREHOSE_MANAGER.RefreshDisk();
							return false;
						}
						while (true)
						{
							if (num11 - num14 < num12)
							{
								num12 = (int)(num11 - num14);
							}
							if (num14 == num11 && FIREHOSE_RESPONSE.IsAck(silent: true))
							{
								break;
							}
							byte[] array3 = new byte[num12 - 1 + 1];
							binaryReader.Read(array3, 0, num12);
							DiskWriter.DiskWrite(array3);
							num8 += array3.Length;
							num14 += array3.Length;
							num15 += array3.Length;
							num5 += array3.Length;
							UiManager.label_writensize(num5);
							TimeSpan elapsed = stopwatch.Elapsed;
							UiManager.label_transferrate((double)array3.Length / elapsed.TotalSeconds);
							UiManager.ProcessBar1(num14, num11);
						}
						stopwatch.Stop();
					}
					else if (num10 == 969410.0)
					{
						long num16 = (long)Math.Round((double)num11 / Convert.ToDouble(sector_size));
						num7 += num16;
					}
					else if (num10 == 969411.0)
					{
						long num17 = (long)Math.Round((double)num11 / Convert.ToDouble(sector_size));
						num7 += num17;
					}
					num9++;
					if (num9 == FIREHOSE.totalchunk)
					{
						break;
					}
					UiManager.ProcessBar2(num9, FIREHOSE.totalchunk);
				}
				UiManager.ProcessBar2(num9, FIREHOSE.totalchunk);
				stream.Close();
				binaryReader.Close();
				return true;
			}
			if (!silent)
			{
				UiManager.Richlogs("- Writing Mi Account Data : ", Color.Black, isBold: false);
			}
			stream.Seek(0L, SeekOrigin.Begin);
			num12 = 8192;
			if (num4 >= 16777216)
			{
				num12 = int.Parse(FIREHOSE_MANAGER.MaxPayloadSizeToTargetInBytes);
			}
			long num18 = Bulat((double)num4 / Convert.ToDouble(sector_size));
			double num19 = (double)num18 * Convert.ToDouble(sector_size);
			if ((double)num4 < Convert.ToDouble(sector_size))
			{
				num18 = 1L;
				num19 = Convert.ToDouble(sector_size);
				num12 = Convert.ToInt32(sector_size);
			}
			FIREHOSE_PACKET.SendXml(FIREHOSE.pkt_Program(sector_size, Convert.ToString(num18), physical_partition_number, start_sector));
			if (FIREHOSE_RESPONSE.IsAck(silent: true))
			{
				using (BinaryReader binaryReader2 = new BinaryReader(stream))
				{
					while (num19 != (double)num3)
					{
						if (num19 - (double)num3 < (double)num12)
						{
							num12 = (int)Math.Round(num19 - (double)num3);
							byte[] array4 = new byte[num12 - 1 + 1];
							binaryReader2.Read(array4, 0, num12);
							DiskWriter.DiskWrite(array4);
							num3 += array4.Length;
							UiManager.label_writensize(num3);
							UiManager.label_transferrate((double)num3 / stopwatch.Elapsed.TotalSeconds);
							UiManager.ProcessBar1(num3, (long)Math.Round(num19));
						}
						else
						{
							byte[] array5 = new byte[num12 - 1 + 1];
							binaryReader2.Read(array5, 0, num12);
							DiskWriter.DiskWrite(array5);
							num3 += array5.Length;
							UiManager.label_writensize(num3);
							UiManager.label_transferrate((double)num3 / stopwatch.Elapsed.TotalSeconds);
							UiManager.ProcessBar1(num3, (long)Math.Round(num19));
						}
					}
					stopwatch.Stop();
					if (FIREHOSE_RESPONSE.IsAck(silent: true))
					{
						binaryReader2.Close();
						return true;
					}
					binaryReader2.Close();
					return false;
				}
			}
			return false;
		}
	}

	public static bool Write_kg_data(string sector_size, string num_partition_sector, string physical_partition_number, string start_sector, ref string label, string filename, bool silent = false)
	{
		UiManager.hide_writen_transfer(hidden: false);
		FIREHOSE_MANAGER.RefreshDisk();
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		byte[] array = new byte[16385];
		Stream stream = new MemoryStream(array);
		if (FIREHOSE_OPERATIONS.MenuEx == FIREHOSE_OPERATIONS.MenuEksekusi.manual)
		{
			if (!File.Exists(filename))
			{
				return false;
			}
			FileInfo fileInfo = new FileInfo(filename);
			num4 = fileInfo.Length;
			UiManager.label_totalsize(fileInfo.Length);
			stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
			stream.Seek(0L, SeekOrigin.Begin);
			stream.Read(array, 0, array.Length);
			Path.GetFileName(filename);
		}
		else if (FIREHOSE_OPERATIONS.MenuEx == FIREHOSE_OPERATIONS.MenuEksekusi.oneclick)
		{
			stream = new MemoryStream(FIREHOSE_MANAGER.FilesOneClick);
			stream.Seek(0L, SeekOrigin.Begin);
			stream.Read(array, 0, array.Length);
			num4 = FIREHOSE_MANAGER.FilesOneClick.Length;
			UiManager.label_totalsize(FIREHOSE_MANAGER.FilesOneClick.Length);
		}
		stream.Seek(0L, SeekOrigin.Begin);
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		checked
		{
			int num12;
			if (CekSparse(array))
			{
				if (!silent)
				{
					UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
					UiManager.Richlogs("- Remove KG/Knox Data Lock : ", Color.Black, isBold: false);
					Form1.SharedUI.ProgressBar1.Text = "Removing...";
				}
				int num6 = 0;
				long num7 = 0L;
				long num8 = 0L;
				if (FIREHOSE.totalchunk <= 0)
				{
					stream.Close();
					return false;
				}
				int num9 = 0;
				using BinaryReader binaryReader = new BinaryReader(stream);
				byte[] array2 = new byte[1025];
				FIREHOSE.chunkheader = default(FIREHOSE.CHUNK_HEADER);
				while (true)
				{
					double num10;
					long num11;
					if (num9 == 0)
					{
						binaryReader.BaseStream.Seek(28L, SeekOrigin.Begin);
						binaryReader.Read(array2, 0, 12);
						FIREHOSE.chunkheader.wChunkType = BitConverter.ToInt16(array2.Skip(0).Take(2).ToArray(), 0);
						FIREHOSE.chunkheader.dwChunkSize = BitConverter.ToInt32(array2.Skip(4).Take(4).ToArray(), 0);
						FIREHOSE.chunkheader.dwTotalSize = BitConverter.ToInt32(array2.Skip(8).Take(4).ToArray(), 0);
						short wChunkType = FIREHOSE.chunkheader.wChunkType;
						num10 = Conversion.Val("&HE" + Convert.ToString(wChunkType, 16).ToUpper());
						num11 = unchecked((long)FIREHOSE.chunkheader.dwChunkSize) * unchecked((long)FIREHOSE.sparseheader.dwBlockSize);
						num += FIREHOSE.chunkheader.dwTotalSize;
						num2 = 0L;
					}
					else
					{
						binaryReader.BaseStream.Seek(num + 28, SeekOrigin.Begin);
						binaryReader.Read(array2, 0, 12);
						FIREHOSE.chunkheader.wChunkType = BitConverter.ToInt16(array2.Skip(0).Take(12).ToArray(), 0);
						FIREHOSE.chunkheader.dwChunkSize = BitConverter.ToInt32(array2.Skip(4).Take(4).ToArray(), 0);
						FIREHOSE.chunkheader.dwTotalSize = BitConverter.ToInt32(array2.Skip(8).Take(4).ToArray(), 0);
						short wChunkType2 = FIREHOSE.chunkheader.wChunkType;
						num10 = Conversion.Val("&HE" + Convert.ToString(wChunkType2, 16).ToUpper());
						num += FIREHOSE.chunkheader.dwTotalSize;
						num11 = unchecked((long)FIREHOSE.chunkheader.dwChunkSize) * unchecked((long)FIREHOSE.sparseheader.dwBlockSize);
						num2 = (long)Math.Round((double)num2 + (double)num11 / Convert.ToDouble(sector_size));
					}
					if (num10 == 969409.0)
					{
						num6++;
						num12 = 524288;
						long num13 = (long)Math.Round((double)num11 / Convert.ToDouble(sector_size));
						long num14 = 0L;
						if (num11 <= 524288)
						{
							num12 = (int)num11;
						}
						int num15 = 0;
						string xml = FIREHOSE.pkt_Program(sector_size, Convert.ToString(num13), physical_partition_number, Convert.ToString(Convert.ToDouble(start_sector) + (double)num7));
						num7 += num13;
						FIREHOSE_PACKET.SendXml(xml);
						if (!FIREHOSE_RESPONSE.IsAck(silent: true))
						{
							stopwatch.Stop();
							FIREHOSE_MANAGER.RefreshDisk();
							return false;
						}
						while (true)
						{
							if (num11 - num14 < num12)
							{
								num12 = (int)(num11 - num14);
							}
							if (num14 == num11 && FIREHOSE_RESPONSE.IsAck(silent: true))
							{
								break;
							}
							byte[] array3 = new byte[num12 - 1 + 1];
							binaryReader.Read(array3, 0, num12);
							DiskWriter.DiskWrite(array3);
							num8 += array3.Length;
							num14 += array3.Length;
							num15 += array3.Length;
							num5 += array3.Length;
							UiManager.label_writensize(num5);
							TimeSpan elapsed = stopwatch.Elapsed;
							UiManager.label_transferrate((double)array3.Length / elapsed.TotalSeconds);
							UiManager.ProcessBar1(num14, num11);
						}
						stopwatch.Stop();
					}
					else if (num10 == 969410.0)
					{
						long num16 = (long)Math.Round((double)num11 / Convert.ToDouble(sector_size));
						num7 += num16;
					}
					else if (num10 == 969411.0)
					{
						long num17 = (long)Math.Round((double)num11 / Convert.ToDouble(sector_size));
						num7 += num17;
					}
					num9++;
					if (num9 == FIREHOSE.totalchunk)
					{
						break;
					}
					UiManager.ProcessBar2(num9, FIREHOSE.totalchunk);
				}
				UiManager.ProcessBar2(num9, FIREHOSE.totalchunk);
				stream.Close();
				binaryReader.Close();
				return true;
			}
			if (!silent)
			{
				UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
				UiManager.Richlogs("- Remove KG/Knox Data Lock : ", Color.Black, isBold: false);
				Form1.SharedUI.ProgressBar1.Text = "Removing...";
			}
			stream.Seek(0L, SeekOrigin.Begin);
			num12 = 8192;
			if (num4 >= 16777216)
			{
				num12 = int.Parse(FIREHOSE_MANAGER.MaxPayloadSizeToTargetInBytes);
			}
			long num18 = Bulat((double)num4 / Convert.ToDouble(sector_size));
			double num19 = (double)num18 * Convert.ToDouble(sector_size);
			if ((double)num4 < Convert.ToDouble(sector_size))
			{
				num18 = 1L;
				num19 = Convert.ToDouble(sector_size);
				num12 = Convert.ToInt32(sector_size);
			}
			FIREHOSE_PACKET.SendXml(FIREHOSE.pkt_Program(sector_size, Convert.ToString(num18), physical_partition_number, start_sector));
			if (FIREHOSE_RESPONSE.IsAck(silent: true))
			{
				using (BinaryReader binaryReader2 = new BinaryReader(stream))
				{
					while (num19 != (double)num3)
					{
						if (num19 - (double)num3 < (double)num12)
						{
							num12 = (int)Math.Round(num19 - (double)num3);
							byte[] array4 = new byte[num12 - 1 + 1];
							binaryReader2.Read(array4, 0, num12);
							DiskWriter.DiskWrite(array4);
							num3 += array4.Length;
							UiManager.label_writensize(num3);
							UiManager.label_transferrate((double)num3 / stopwatch.Elapsed.TotalSeconds);
							UiManager.ProcessBar1(num3, (long)Math.Round(num19));
						}
						else
						{
							byte[] array5 = new byte[num12 - 1 + 1];
							binaryReader2.Read(array5, 0, num12);
							DiskWriter.DiskWrite(array5);
							num3 += array5.Length;
							UiManager.label_writensize(num3);
							UiManager.label_transferrate((double)num3 / stopwatch.Elapsed.TotalSeconds);
							UiManager.ProcessBar1(num3, (long)Math.Round(num19));
						}
					}
					stopwatch.Stop();
					if (FIREHOSE_RESPONSE.IsAck(silent: true))
					{
						binaryReader2.Close();
						return true;
					}
					binaryReader2.Close();
					return false;
				}
			}
			return false;
		}
	}

	public static string ReadPartitionWarning(string num_partition_sector, string label)
	{
		Console.WriteLine(num_partition_sector);
		return "Read " + label + " skipped! ";
	}

	public static bool ReadPartition(string start_sector, string num_partition_sector, string sector_size, string physical_partition_number, ref string label)
	{
		if (long.Parse(num_partition_sector) < 1)
		{
			UiManager.Richlogs(ReadPartitionWarning(num_partition_sector, label), Color.DarkOrange, isBold: false);
			FIREHOSE_MANAGER.RefreshDisk();
			return true;
		}
		UiManager.hide_writen_transfer(hidden: false);
		FIREHOSE_MANAGER.RefreshDisk();
		int num = 0;
		checked
		{
			long num2 = long.Parse(num_partition_sector) * long.Parse(sector_size);
			long num3 = 0L;
			long num4 = 0L;
			UiManager.label_totalsize(num2);
			string xml = FIREHOSE.pkt_read(sector_size, num_partition_sector, physical_partition_number, start_sector);
			if (File.Exists(FIREHOSE_MANAGER.foldersave + "\\" + Get_Partition_Filenames(label)))
			{
				File.Delete(FIREHOSE_MANAGER.foldersave + "\\" + Get_Partition_Filenames(label));
			}
			FileStream fileStream = new FileStream(FIREHOSE_MANAGER.foldersave + "\\" + Get_Partition_Filenames(label), FileMode.Append, FileAccess.Write);
			using (fileStream)
			{
				byte[] array = new byte[2097153];
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				FIREHOSE_PACKET.SendXml(xml);
				byte[] array2 = FIREHOSE_PACKET.ReadByte();
				if (array2.Length != 0)
				{
					num3 += array2.Length;
					num4 -= array2.Length;
					if (num3 >= num2)
					{
						fileStream.Write(array2, 0, (int)num2);
						UiManager.ProcessBar1(num2, num2);
						fileStream.Flush();
						fileStream.Close();
						FIREHOSE_MANAGER.RefreshDisk();
						return true;
					}
					fileStream.Write(array2, 0, array2.Length);
					UiManager.ProcessBar1(num3, num2);
				}
				while (true)
				{
					array = DiskWriter.DiskRead();
					num3 += array.Length;
					UiManager.label_writensize(num3);
					UiManager.label_transferrate((double)num3 / stopwatch.Elapsed.TotalSeconds);
					if (num3 > num2)
					{
						break;
					}
					fileStream.Write(array, 0, array.Length);
					UiManager.ProcessBar1(num3, num2);
					num++;
				}
				long num5 = num3 - num2;
				long num6 = array.Length - num5;
				byte[] array3 = array.Take((int)num6).ToArray();
				fileStream.Write(array3, 0, array3.Length);
				UiManager.ProcessBar1(num3 - num5, num2);
				fileStream.Flush();
				fileStream.Close();
				stopwatch.Stop();
			}
			FIREHOSE_MANAGER.RefreshDisk();
			return true;
		}
	}

	public static bool ReadPartition(string start_sector, string num_partition_sector, string sector_size, string physical_partition_number, ref string label, string foldersave)
	{
		if (long.Parse(num_partition_sector) < 1)
		{
			UiManager.Richlogs(ReadPartitionWarning(num_partition_sector, label), Color.DarkOrange, isBold: false);
			FIREHOSE_MANAGER.RefreshDisk();
			return true;
		}
		UiManager.hide_writen_transfer(hidden: false);
		FIREHOSE_MANAGER.RefreshDisk();
		int num = 0;
		checked
		{
			long num2 = long.Parse(num_partition_sector) * long.Parse(sector_size);
			long num3 = 0L;
			long num4 = 0L;
			UiManager.label_totalsize(num2);
			string xml = FIREHOSE.pkt_read(sector_size, num_partition_sector, physical_partition_number, start_sector);
			if (File.Exists(foldersave))
			{
				File.Delete(foldersave);
			}
			FileStream fileStream = new FileStream(foldersave, FileMode.Append, FileAccess.Write);
			using (fileStream)
			{
				byte[] array = new byte[2097153];
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				FIREHOSE_PACKET.SendXml(xml);
				byte[] array2 = FIREHOSE_PACKET.ReadByte();
				if (array2.Length != 0)
				{
					num3 += array2.Length;
					num4 -= array2.Length;
					if (num3 >= num2)
					{
						fileStream.Write(array2, 0, (int)num2);
						UiManager.ProcessBar1(num2, num2);
						fileStream.Flush();
						fileStream.Close();
						FIREHOSE_MANAGER.RefreshDisk();
						return true;
					}
					fileStream.Write(array2, 0, array2.Length);
					UiManager.ProcessBar1(num3, num2);
				}
				while (true)
				{
					array = DiskWriter.DiskRead();
					num3 += array.Length;
					UiManager.label_writensize(num3);
					UiManager.label_transferrate((double)num3 / stopwatch.Elapsed.TotalSeconds);
					if (num3 > num2)
					{
						break;
					}
					fileStream.Write(array, 0, array.Length);
					UiManager.ProcessBar1(num3, num2);
					num++;
				}
				long num5 = num3 - num2;
				long num6 = array.Length - num5;
				byte[] array3 = array.Take((int)num6).ToArray();
				fileStream.Write(array3, 0, array3.Length);
				UiManager.ProcessBar1(num3 - num5, num2);
				fileStream.Flush();
				fileStream.Close();
				stopwatch.Stop();
			}
			FIREHOSE_MANAGER.RefreshDisk();
			return true;
		}
	}

	public static bool ErasePartition(string sector_size, string num_partition_sector, string physical_partition_number, string start_sector, ref string label)
	{
		checked
		{
			UiManager.label_totalsize(long.Parse(num_partition_sector) * long.Parse(sector_size));
			int num = 1048576;
			int num2 = 16384;
			long num3;
			if (Convert.ToDouble(num_partition_sector) == 0.0)
			{
				num3 = (long)Math.Round((double)num / Convert.ToDouble(sector_size));
			}
			else
			{
				num3 = ((Convert.ToDouble(num_partition_sector) * Convert.ToDouble(sector_size) >= 1048576.0) ? ((long)Math.Round((double)num / Convert.ToDouble(sector_size))) : long.Parse(num_partition_sector));
				num3 = long.Parse(num_partition_sector);
			}
			double num4 = (double)num3 * Convert.ToDouble(sector_size);
			long num5 = 0L;
			long num6 = 0L;
			FIREHOSE_PACKET.SendXml(FIREHOSE.pkt_Program(sector_size, num3.ToString(), physical_partition_number, start_sector));
			if (!FIREHOSE_RESPONSE.IsAck(silent: true))
			{
				if (ErasePartitionPacket(sector_size, num_partition_sector, physical_partition_number, start_sector, ref label))
				{
					return true;
				}
				return false;
			}
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			while ((double)num5 != num4)
			{
				if (num4 - (double)num5 < (double)num2)
				{
					num2 = (int)Math.Round(num4 - (double)num5);
				}
				byte[] array = new byte[num2 - 1 + 1];
				DiskWriter.DiskWrite(array);
				num5 += array.Length;
				num6 += array.Length;
				UiManager.label_writensize(num6);
				UiManager.label_transferrate((double)num6 / stopwatch.Elapsed.TotalSeconds);
				UiManager.ProcessBar1(num6, num3 * long.Parse(sector_size));
			}
			stopwatch.Stop();
			if (!FIREHOSE_RESPONSE.IsAck(silent: true))
			{
				if (ErasePartitionPacket(sector_size, num_partition_sector, physical_partition_number, start_sector, ref label))
				{
					return true;
				}
				return false;
			}
			return true;
		}
	}

	public static bool ErasePartitionPacket(string sector_size, string num_partition_sector, string physical_partition_number, string start_sector, ref string label)
	{
		Console.WriteLine("\n" + $"Erasing {label} by-packet" + "\n");
		FIREHOSE_PACKET.SendXml(FIREHOSE.pkt_erase(sector_size, num_partition_sector, physical_partition_number, start_sector));
		if (!FIREHOSE_RESPONSE.IsAck(silent: true))
		{
			return EraseByPatch(sector_size, num_partition_sector, physical_partition_number, start_sector, ref label);
		}
		return true;
	}

	public static bool EraseByPatch(string sector_size, string num_partition_sector, string physical_partition_number, string start_sector, ref string label)
	{
		if (long.Parse(num_partition_sector) > 0)
		{
			Console.WriteLine(" ");
			Console.WriteLine("Patch Erase " + label + " start...");
			Console.WriteLine(" ");
			long num = 0L;
			if (Operators.CompareString(FIREHOSE_MANAGER.TypeMemory, "ufs", TextCompare: false) == 0 && long.Parse(num_partition_sector) >= 128)
			{
				num = 50L;
			}
			else if (Operators.CompareString(FIREHOSE_MANAGER.TypeMemory, "emmc", TextCompare: false) == 0)
			{
				num = long.Parse(num_partition_sector) / 2;
			}
			string text = "";
			checked
			{
				long num2 = num - 1;
				for (long num3 = 0L; num3 <= num2; num3++)
				{
					text += FIREHOSE.pkt_patch_string(sector_size, num3.ToString(), "DISK", physical_partition_number, "1", start_sector, "00", "zero");
				}
				if (!FIREHOSE_OPERATIONS.Process_Patch(text, ref label))
				{
					return false;
				}
				return true;
			}
		}
		return false;
	}

	public static string Get_Partition_Filenames(string label)
	{
		switch (label)
		{
		case "aboot":
			return "emmc_appsboot.mbn";
		case "abootbak":
			return "emmc_appsbootbak.mbn";
		case "apdp":
			return "dpAP.mbn";
		case "BackupGPT":
			return "gpt_backup0.bin";
		case "boot":
			return "boot.img";
		case "cache":
			return "cache.img";
		case "cmnlib":
			return "cmnlib.mbn";
		case "cmnlibbak":
			return "cmnlibbak.mbn";
		case "cmnlib64":
			return "cmnlib64.mbn";
		case "cmnlib64bak":
			return "cmnlib64bak.mbn";
		case "devcfg":
			return "devcfg.mbn";
		case "devcfgbak":
			return "devcfgbak.mbn";
		case "DRIVER":
			return "DRIVER.ISO";
		case "dsp":
			return "adspso.bin";
		case "dtbo":
			return "dtbo.img";
		case "keymaster":
			if (SAHARA_MANAGER.cpu64)
			{
				return "keymaster64.mbn";
			}
			break;
		}
		if (Operators.CompareString(label, "keymasterbak", TextCompare: false) == 0 && SAHARA_MANAGER.cpu64)
		{
			return "keymasterbak64.mbn";
		}
		if (Operators.CompareString(label, "keymaster", TextCompare: false) == 0 && !SAHARA_MANAGER.cpu64)
		{
			return "keymaster.mbn";
		}
		if (Operators.CompareString(label, "keymasterbak", TextCompare: false) == 0 && !SAHARA_MANAGER.cpu64)
		{
			return "keymasterbak.mbn";
		}
		return label switch
		{
			"lksecapp" => "lksecapp.mbn", 
			"lksecappbak" => "lksecappbak.mbn", 
			"LOGO" => "logo.bin", 
			"mdtp" => "mdtp.img", 
			"misc" => "misc.img", 
			"modem" => "NON - HLOS.bin", 
			"oppodycnvbk" => "dynamic_nvbk.bin", 
			"opporeserve1" => "emmc_fw.bin", 
			"opporeserve2" => "opporeserve2.img", 
			"oppostanvbk" => "static_nvbk.bin", 
			"persist" => "persist.img", 
			"PrimaryGPT" => "gpt_main0.bin", 
			"recovery" => "recovery.img", 
			"rpm" => "rpm.mbn", 
			"rpmbak" => "rpmbak.mbn", 
			"sbl1" => "sbl1.mbn", 
			"sbl1bak" => "sbl1bak.mbn", 
			"sec" => "sec.dat", 
			"system" => "system.img", 
			"tz" => "tz.mbn", 
			"tzbak" => "tzbak.mbn", 
			"userdata" => "userdata.img", 
			"vbmeta" => "vbmeta.img", 
			"vendor" => "vendor.img", 
			_ => label + ".bin", 
		};
	}
}
