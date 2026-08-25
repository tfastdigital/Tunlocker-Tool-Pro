namespace motoulocked.OdinClient.Pit;

public class TPIT_Entry
{
	private long binaryType;

	private long deviceType;

	private long identifier;

	private long attributes;

	private long updateAttributes;

	private long blockSizeOrOffset;

	private long blockCount;

	private long fileOffset;

	private long fileSize;

	private string partitionName;

	private string flashFilename;

	private string fotaFilename;

	public long MbinaryType
	{
		get
		{
			return binaryType;
		}
		set
		{
			binaryType = value;
		}
	}

	public long MdeviceType
	{
		get
		{
			return deviceType;
		}
		set
		{
			deviceType = value;
		}
	}

	public long Midentifier
	{
		get
		{
			return identifier;
		}
		set
		{
			identifier = value;
		}
	}

	public long Mattributes
	{
		get
		{
			return attributes;
		}
		set
		{
			attributes = value;
		}
	}

	public long MupdateAttributes
	{
		get
		{
			return updateAttributes;
		}
		set
		{
			updateAttributes = value;
		}
	}

	public long MblockSizeOrOffset
	{
		get
		{
			return blockSizeOrOffset;
		}
		set
		{
			blockSizeOrOffset = value;
		}
	}

	public long MblockCount
	{
		get
		{
			return blockCount;
		}
		set
		{
			blockCount = value;
		}
	}

	public long MfileOffset
	{
		get
		{
			return fileOffset;
		}
		set
		{
			fileOffset = value;
		}
	}

	public long MfileSize
	{
		get
		{
			return fileSize;
		}
		set
		{
			fileSize = value;
		}
	}

	public string MpartitionName
	{
		get
		{
			return partitionName;
		}
		set
		{
			partitionName = value;
		}
	}

	public string MflashFilename
	{
		get
		{
			return flashFilename;
		}
		set
		{
			flashFilename = value;
		}
	}

	public string MfotaFilename
	{
		get
		{
			return fotaFilename;
		}
		set
		{
			fotaFilename = value;
		}
	}
}
