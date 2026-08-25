using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.mtkclient2.library;

internal class MtkSparse
{
	public struct MTK_CHUNK_HEADER
	{
		public short wChunkType;

		public short wReserved;

		public int dwChunkSize;

		public int dwTotalSize;
	}

	public struct MTK_SPARSE_HEADER
	{
		public int dwMagic;

		public short wVerMajor;

		public short wVerMinor;

		public short wSparseHeaderSize;

		public short wChunkHeaderSize;

		public int dwBlockSize;

		public int dwTotalBlocks;

		public int dwTotalChunks;

		public int dwImageChecksum;
	}

	private static MTK_CHUNK_HEADER chunkheader;

	private static MTK_SPARSE_HEADER sparseheader;

	public static int sectsize = 512;

	private const long MTK_SPARSE_MAGIC = 64108298042L;

	private const long MTK_SPARSE_RAW_CHUNK = 969409L;

	private const long MTK_SPARSE_FILL_CHUNK = 969410L;

	private const long MTK_SPARSE_DONT_CARE = 969411L;

	private static int totalchunk { get; set; }

	public static bool CekSparse(string files)
	{
		Stream stream = File.OpenRead(files);
		stream.Seek(0L, SeekOrigin.Begin);
		byte[] array = new byte[1025];
		using BinaryReader binaryReader = new BinaryReader(stream);
		binaryReader.Read(array, 0, 28);
		sparseheader = parsingheader(array);
		if (Convert.ToInt64(sparseheader.dwMagic) == 64108298042L)
		{
			totalchunk = sparseheader.dwTotalChunks;
			stream.Close();
			binaryReader.Close();
			return true;
		}
		stream.Close();
		binaryReader.Close();
		return false;
	}

	public static MTK_SPARSE_HEADER parsingheader(byte[] bytes)
	{
		MTK_SPARSE_HEADER mTK_SPARSE_HEADER = default(MTK_SPARSE_HEADER);
		GCHandle gCHandle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
		try
		{
			return (MTK_SPARSE_HEADER)Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), typeof(MTK_SPARSE_HEADER));
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void dosparse2unsparse(string filesparse, string savefile)
	{
		byte[] array = new byte[16385];
		if (!File.Exists(filesparse))
		{
			return;
		}
		FileStream fileStream = new FileStream(filesparse, FileMode.Open, FileAccess.Read);
		FileStream fileStream2 = new FileStream(savefile, FileMode.Append, FileAccess.Write);
		fileStream.Read(array, 0, array.Length);
		fileStream.Seek(0L, SeekOrigin.Begin);
		short num = 0;
		double num2 = 0.0;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		int num6 = 0;
		long num7 = 0L;
		long num8 = 0L;
		checked
		{
			if (totalchunk > 0)
			{
				int num9 = 0;
				using BinaryReader binaryReader = new BinaryReader(fileStream);
				byte[] array2 = new byte[1025];
				chunkheader = default(MTK_CHUNK_HEADER);
				while (true)
				{
					try
					{
						if (num9 == 0)
						{
							binaryReader.BaseStream.Seek(28L, SeekOrigin.Begin);
							binaryReader.Read(array2, 0, 12);
							chunkheader.wChunkType = BitConverter.ToInt16(array2.Skip(0).Take(2).ToArray(), 0);
							chunkheader.dwChunkSize = BitConverter.ToInt32(array2.Skip(4).Take(4).ToArray(), 0);
							chunkheader.dwTotalSize = BitConverter.ToInt32(array2.Skip(8).Take(4).ToArray(), 0);
							num = chunkheader.wChunkType;
							num2 = Conversion.Val("&HE" + Convert.ToString(num, 16).ToUpper());
							_ = chunkheader;
							num3 = unchecked((long)chunkheader.dwChunkSize) * unchecked((long)sparseheader.dwBlockSize);
							num4 += chunkheader.dwTotalSize;
							num5 = 0L;
						}
						else
						{
							binaryReader.BaseStream.Seek(num4 + 28, SeekOrigin.Begin);
							binaryReader.Read(array2, 0, 12);
							chunkheader.wChunkType = BitConverter.ToInt16(array2.Skip(0).Take(12).ToArray(), 0);
							chunkheader.dwChunkSize = BitConverter.ToInt32(array2.Skip(4).Take(4).ToArray(), 0);
							chunkheader.dwTotalSize = BitConverter.ToInt32(array2.Skip(8).Take(4).ToArray(), 0);
							num = chunkheader.wChunkType;
							num2 = Conversion.Val("&HE" + Convert.ToString(num, 16).ToUpper());
							_ = chunkheader;
							num4 += chunkheader.dwTotalSize;
							num3 = unchecked((long)chunkheader.dwChunkSize) * unchecked((long)sparseheader.dwBlockSize);
							num5 += Convert.ToInt64((double)num3 / (double)sectsize);
						}
						if (num2 == 969409.0)
						{
							num6++;
							int num10 = 524288;
							long num11 = Convert.ToInt64((double)num3 / (double)sectsize);
							long num12 = 0L;
							if (num3 <= num10)
							{
								num10 = (int)num3;
							}
							int num13 = 0;
							num7 += num11;
							while (true)
							{
								if (num3 - num12 < num10)
								{
									num10 = (int)(num3 - num12);
								}
								if (num12 == num3)
								{
									break;
								}
								byte[] array3 = new byte[num10 - 1 + 1];
								binaryReader.Read(array3, 0, num10);
								fileStream2.Write(array3, 0, array3.Length);
								num8 += array3.Length;
								num12 += array3.Length;
								num13 += array3.Length;
							}
						}
						else if (num2 == 969410.0)
						{
							num6++;
							int num14 = 524288;
							long num15 = Convert.ToInt64((double)num3 / (double)sectsize);
							long num16 = 0L;
							if (num3 <= num14)
							{
								num14 = (int)num3;
							}
							int num17 = 0;
							num7 += num15;
							while (true)
							{
								if (num3 - num16 < num14)
								{
									num14 = (int)(num3 - num16);
								}
								if (num16 == num3)
								{
									break;
								}
								byte[] array4 = new byte[num14 - 1 + 1];
								binaryReader.Read(array4, 0, num14);
								fileStream2.Write(array4, 0, array4.Length);
								num8 += array4.Length;
								num16 += array4.Length;
								num17 += array4.Length;
							}
						}
						else if (num2 == 969411.0)
						{
							num6++;
							int num18 = 524288;
							long num19 = Convert.ToInt64((double)num3 / (double)sectsize);
							long num20 = 0L;
							if (num3 <= num18)
							{
								num18 = (int)num3;
							}
							int num21 = 0;
							num7 += num19;
							while (true)
							{
								if (num3 - num20 < num18)
								{
									num18 = (int)(num3 - num20);
								}
								if (num20 == num3)
								{
									break;
								}
								byte[] array5 = new byte[num18 - 1 + 1];
								binaryReader.Read(array5, 0, num18);
								fileStream2.Write(array5, 0, array5.Length);
								num8 += array5.Length;
								num20 += array5.Length;
								num21 += array5.Length;
							}
						}
						num9++;
						if (num9 == totalchunk)
						{
							Form1.ProcessBar(num9, totalchunk);
							fileStream.Close();
							binaryReader.Close();
							break;
						}
						Form1.ProcessBar(num9, totalchunk);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						fileStream.Close();
						ProjectData.ClearProjectError();
						break;
					}
				}
			}
			fileStream.Close();
			fileStream2.Close();
		}
	}
}
