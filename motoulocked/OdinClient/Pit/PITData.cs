using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.OdinClient.Pit;

public class PITData
{
	public enum TFileIdentifier
	{
		kFileIdentifier = 305436790,
		kHeaderDataSize = 28
	}

	public TPIT_Entry[] xPIT_Entry;

	public TPIT_Entry[] PIT_EntryOrdered;

	private long entryCount;

	private long unknown1;

	private long unknown2;

	private long unknown3;

	private long unknown4;

	private long unknown5;

	private long unknown6;

	private long unknown7;

	private int unknown8;

	public long UnpackInteger(byte[] data, long offset, bool ISWORDS_BIGENDIAN)
	{
		checked
		{
			if (ISWORDS_BIGENDIAN)
			{
				return (long)Math.Round(Conversion.Val(unchecked((byte)(data[checked((int)offset)] << 0)))) | ((long)Math.Round(Conversion.Val(data[(int)(offset + 1)])) << 16) | ((long)Math.Round(Conversion.Val(data[(int)(offset + 2)])) << 8) | (long)Math.Round(Conversion.Val(data[(int)(offset + 3)]));
			}
			return (long)Math.Round(Conversion.Val(data[(int)offset])) | ((long)Math.Round(Conversion.Val(data[(int)(offset + 1)])) << 8) | ((long)Math.Round(Conversion.Val(data[(int)(offset + 2)])) << 16) | ((long)Math.Round(Conversion.Val(data[(int)(offset + 3)])) << 24);
		}
	}

	public long UnpackShort(byte[] data, long offset, bool ISWORDS_BIGENDIAN)
	{
		checked
		{
			if (ISWORDS_BIGENDIAN)
			{
				return (long)Math.Round(Conversion.Val(unchecked((byte)(data[checked((int)offset)] << 0)))) | (long)Math.Round(Conversion.Val(data[(int)(offset + 1)]));
			}
			return (long)Math.Round(Conversion.Val(data[(int)offset])) | ((long)Math.Round(Conversion.Val(data[(int)(offset + 1)])) << 8);
		}
	}

	public string GetPartationname(byte[] data, int offset)
	{
		string text = "";
		int num = 0;
		checked
		{
			do
			{
				text = ((Conversion.Val(data[offset + num]) != 0.0) ? (text + Conversions.ToString(Strings.Chr(data[offset + num]))) : (text ?? ""));
				num++;
			}
			while (num <= 31);
			return text;
		}
	}

	public bool UNPACK_PIT(byte[] sData)
	{
		string text = "";
		UnpackInteger(sData, 0L, ISWORDS_BIGENDIAN: false);
		entryCount = UnpackInteger(sData, 4L, ISWORDS_BIGENDIAN: false);
		checked
		{
			Array.Resize(ref xPIT_Entry, (int)entryCount);
			long num = 8L;
			do
			{
				text += Conversions.ToString(Strings.Chr(sData[(int)num]));
				num++;
			}
			while (num <= 25);
			unknown1 = UnpackInteger(sData, 8L, ISWORDS_BIGENDIAN: false);
			unknown2 = UnpackInteger(sData, 12L, ISWORDS_BIGENDIAN: false);
			unknown3 = UnpackShort(sData, 16L, ISWORDS_BIGENDIAN: false);
			unknown4 = UnpackShort(sData, 18L, ISWORDS_BIGENDIAN: false);
			unknown5 = UnpackShort(sData, 20L, ISWORDS_BIGENDIAN: false);
			unknown6 = UnpackShort(sData, 22L, ISWORDS_BIGENDIAN: false);
			unknown7 = UnpackShort(sData, 24L, ISWORDS_BIGENDIAN: false);
			unknown8 = (int)UnpackShort(sData, 26L, ISWORDS_BIGENDIAN: false);
			long num2 = entryCount - 1;
			for (num = 0L; num <= num2; num++)
			{
				long num3 = (long)Math.Round(Conversion.Val(TFileIdentifier.kHeaderDataSize) + (double)num * Conversion.Val(TPitEntry.kDataSize));
				TPIT_Entry tPIT_Entry = new TPIT_Entry();
				tPIT_Entry.MbinaryType = UnpackInteger(sData, num3, ISWORDS_BIGENDIAN: false);
				tPIT_Entry.MdeviceType = UnpackInteger(sData, num3 + 4, ISWORDS_BIGENDIAN: false);
				tPIT_Entry.Midentifier = UnpackInteger(sData, num3 + 8, ISWORDS_BIGENDIAN: false);
				tPIT_Entry.Mattributes = UnpackInteger(sData, num3 + 12, ISWORDS_BIGENDIAN: false);
				tPIT_Entry.MupdateAttributes = UnpackInteger(sData, num3 + 16, ISWORDS_BIGENDIAN: false);
				tPIT_Entry.MblockSizeOrOffset = UnpackInteger(sData, num3 + 20, ISWORDS_BIGENDIAN: false);
				tPIT_Entry.MblockCount = UnpackInteger(sData, num3 + 24, ISWORDS_BIGENDIAN: false);
				tPIT_Entry.MfileOffset = UnpackInteger(sData, num3 + 28, ISWORDS_BIGENDIAN: false);
				tPIT_Entry.MfileSize = UnpackInteger(sData, num3 + 32, ISWORDS_BIGENDIAN: false);
				tPIT_Entry.MpartitionName = GetPartationname(sData, (int)(num3 + 36));
				tPIT_Entry.MflashFilename = GetPartationname(sData, (int)(num3 + 36 + 32));
				tPIT_Entry.MfotaFilename = GetPartationname(sData, (int)(num3 + 36 + 64));
				xPIT_Entry[(int)num] = tPIT_Entry;
			}
			int num4 = 0;
			Array.Resize(ref PIT_EntryOrdered, (int)entryCount);
			int num5 = 0;
			do
			{
				long num6 = entryCount - 1;
				for (num = 0L; num <= num6; num++)
				{
					if (xPIT_Entry[(int)num].Midentifier == num5)
					{
						PIT_EntryOrdered[num4] = xPIT_Entry[(int)num];
						num4++;
						text = PaddLog(xPIT_Entry[(int)num].MpartitionName, 16);
						text += PaddLog(IntThex(xPIT_Entry[(int)num].MbinaryType), 16);
						text += PaddLog(IntThex(xPIT_Entry[(int)num].MdeviceType), 16);
						text += PaddLog(IntThex(xPIT_Entry[(int)num].Midentifier), 16);
						text += PaddLog(IntThex(xPIT_Entry[(int)num].Mattributes), 16);
						text += PaddLog(IntThex(xPIT_Entry[(int)num].MupdateAttributes), 16);
						text += PaddLog(IntThex(xPIT_Entry[(int)num].MblockSizeOrOffset), 16);
						text += PaddLog(IntThex(xPIT_Entry[(int)num].MblockCount), 16);
						text += PaddLog(IntThex(xPIT_Entry[(int)num].MfileOffset), 16);
						text += PaddLog(IntThex(xPIT_Entry[(int)num].MfileSize), 16);
						text += PaddLog(xPIT_Entry[(int)num].MflashFilename, 16);
					}
				}
				num5++;
			}
			while (num5 <= 255);
			return true;
		}
	}

	public string PaddLog(string s, int Lngth)
	{
		string text = "";
		for (int i = 1; i <= Lngth; i = checked(i + 1))
		{
			text = ((i <= s.Length) ? (text + Strings.Mid(s, i, 1)) : (text + " "));
		}
		return text;
	}

	public string IntThex(long v)
	{
		return Strings.Right("00000000" + Conversion.Hex(v), 8);
	}

	public PITData()
	{
		entryCount = 0L;
		unknown1 = 0L;
		unknown2 = 0L;
		unknown3 = 0L;
		unknown4 = 0L;
		unknown5 = 0L;
		unknown6 = 0L;
		unknown7 = 0L;
		unknown8 = 0;
	}
}
