using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using motoulocked.mtkclient2.MTK.Client;
using motoulocked.mtkclient2.MTK.Client.Scatter;

namespace motoulocked.mtkclient2.library;

internal class MtkDaxDeviceStorageInfoService
{
	internal class MtkEmmcInfo : IEquatable<MtkEmmcInfo>
	{
		protected  Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(MtkEmmcInfo);
			}
		}

		public int Type { get; set; }

		public int BlockSize { get; set; }

		public long Boot1Size { get; set; }

		public long Boot2Size { get; set; }

		public long RpmbSize { get; set; }

		public long Gp1Size { get; set; }

		public long Gp2Size { get; set; }

		public long Gp3Size { get; set; }

		public long Gp4Size { get; set; }

		public long UserSize { get; set; }

		public byte[] Cid { get; set; }

		public long FirmwareVersion { get; set; }

		public byte[] Unknown { get; set; }

		public MtkEmmcInfo()
		{
			Cid = new byte[0];
			Unknown = new byte[0];
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("MtkEmmcInfo");
			stringBuilder.Append(" { ");
			if (PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		protected  bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Type = ");
			builder.Append(Type.ToString());
			builder.Append(", BlockSize = ");
			builder.Append(BlockSize.ToString());
			builder.Append(", Boot1Size = ");
			builder.Append(Boot1Size.ToString());
			builder.Append(", Boot2Size = ");
			builder.Append(Boot2Size.ToString());
			builder.Append(", RpmbSize = ");
			builder.Append(RpmbSize.ToString());
			builder.Append(", Gp1Size = ");
			builder.Append(Gp1Size.ToString());
			builder.Append(", Gp2Size = ");
			builder.Append(Gp2Size.ToString());
			builder.Append(", Gp3Size = ");
			builder.Append(Gp3Size.ToString());
			builder.Append(", Gp4Size = ");
			builder.Append(Gp4Size.ToString());
			builder.Append(", UserSize = ");
			builder.Append(UserSize.ToString());
			builder.Append(", Cid = ");
			builder.Append(Cid);
			builder.Append(", FirmwareVersion = ");
			builder.Append(FirmwareVersion.ToString());
			builder.Append(", Unknown = ");
			builder.Append(Unknown);
			return true;
		}

		public static bool operator !=(MtkEmmcInfo left, MtkEmmcInfo right)
		{
			return !(left == right);
		}

		public static bool operator ==(MtkEmmcInfo left, MtkEmmcInfo right)
		{
			if ((object)left != right)
			{
				return left?.Equals(right) ?? false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return checked(((((((((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Type)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(BlockSize)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(Boot1Size)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(Boot2Size)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(RpmbSize)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(Gp1Size)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(Gp2Size)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(Gp3Size)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(Gp4Size)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(UserSize)) * -1521134295 + EqualityComparer<byte[]>.Default.GetHashCode(Cid)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(FirmwareVersion)) * -1521134295 + EqualityComparer<byte[]>.Default.GetHashCode(Unknown));
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as MtkEmmcInfo);
		}

		public  bool Equals(MtkEmmcInfo other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && (object)EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(Type, other.Type) && EqualityComparer<int>.Default.Equals(BlockSize, other.BlockSize) && EqualityComparer<long>.Default.Equals(Boot1Size, other.Boot1Size) && EqualityComparer<long>.Default.Equals(Boot2Size, other.Boot2Size) && EqualityComparer<long>.Default.Equals(RpmbSize, other.RpmbSize) && EqualityComparer<long>.Default.Equals(Gp1Size, other.Gp1Size) && EqualityComparer<long>.Default.Equals(Gp2Size, other.Gp2Size) && EqualityComparer<long>.Default.Equals(Gp3Size, other.Gp3Size) && EqualityComparer<long>.Default.Equals(Gp4Size, other.Gp4Size) && EqualityComparer<long>.Default.Equals(UserSize, other.UserSize) && EqualityComparer<byte[]>.Default.Equals(Cid, other.Cid) && EqualityComparer<long>.Default.Equals(FirmwareVersion, other.FirmwareVersion))
				{
					return EqualityComparer<byte[]>.Default.Equals(Unknown, other.Unknown);
				}
				return false;
			}
			return true;
		}

		bool IEquatable<MtkEmmcInfo>.Equals(MtkEmmcInfo other)
		{
			//ILSpy generated this explicit interface implementation from .override directive in Equals
			return this.Equals(other);
		}


		public  MtkEmmcInfo _get()
		{
			return new MtkEmmcInfo(this);
		}

		protected MtkEmmcInfo(MtkEmmcInfo original)
		{
			Type = original.Type;
			BlockSize = original.BlockSize;
			Boot1Size = original.Boot1Size;
			Boot2Size = original.Boot2Size;
			RpmbSize = original.RpmbSize;
			Gp1Size = original.Gp1Size;
			Gp2Size = original.Gp2Size;
			Gp3Size = original.Gp3Size;
			Gp4Size = original.Gp4Size;
			UserSize = original.UserSize;
			Cid = original.Cid;
			FirmwareVersion = original.FirmwareVersion;
			Unknown = original.Unknown;
		}
	}

	internal class MtkNandInfo : IEquatable<MtkNandInfo>
	{
		protected  Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(MtkNandInfo);
			}
		}

		public int Type { get; set; }

		public int PageSize { get; set; }

		public int BlockSize { get; set; }

		public int SpareSize { get; set; }

		public long TotalSize { get; set; }

		public long AvailableSize { get; set; }

		public byte BmtExist { get; set; }

		public string Id { get; set; }

		public MtkNandInfo()
		{
			Id = "";
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("MtkNandInfo");
			stringBuilder.Append(" { ");
			if (PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		protected  bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Type = ");
			builder.Append(Type.ToString());
			builder.Append(", PageSize = ");
			builder.Append(PageSize.ToString());
			builder.Append(", BlockSize = ");
			builder.Append(BlockSize.ToString());
			builder.Append(", SpareSize = ");
			builder.Append(SpareSize.ToString());
			builder.Append(", TotalSize = ");
			builder.Append(TotalSize.ToString());
			builder.Append(", AvailableSize = ");
			builder.Append(AvailableSize.ToString());
			builder.Append(", BmtExist = ");
			builder.Append(BmtExist.ToString());
			builder.Append(", Id = ");
			builder.Append((object)Id);
			return true;
		}

		public static bool operator !=(MtkNandInfo left, MtkNandInfo right)
		{
			return !(left == right);
		}

		public static bool operator ==(MtkNandInfo left, MtkNandInfo right)
		{
			if ((object)left != right)
			{
				return left?.Equals(right) ?? false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return checked((((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Type)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(PageSize)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(BlockSize)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(SpareSize)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(TotalSize)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(AvailableSize)) * -1521134295 + EqualityComparer<byte>.Default.GetHashCode(BmtExist)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id));
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as MtkNandInfo);
		}

		public  bool Equals(MtkNandInfo other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && (object)EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(Type, other.Type) && EqualityComparer<int>.Default.Equals(PageSize, other.PageSize) && EqualityComparer<int>.Default.Equals(BlockSize, other.BlockSize) && EqualityComparer<int>.Default.Equals(SpareSize, other.SpareSize) && EqualityComparer<long>.Default.Equals(TotalSize, other.TotalSize) && EqualityComparer<long>.Default.Equals(AvailableSize, other.AvailableSize) && EqualityComparer<byte>.Default.Equals(BmtExist, other.BmtExist))
				{
					return EqualityComparer<string>.Default.Equals(Id, other.Id);
				}
				return false;
			}
			return true;
		}

		bool IEquatable<MtkNandInfo>.Equals(MtkNandInfo other)
		{
			//ILSpy generated this explicit interface implementation from .override directive in Equals
			return this.Equals(other);
		}



		public  MtkNandInfo _get()
		{
			return new MtkNandInfo(this);
		}

		protected MtkNandInfo(MtkNandInfo original)
		{
			Type = original.Type;
			PageSize = original.PageSize;
			BlockSize = original.BlockSize;
			SpareSize = original.SpareSize;
			TotalSize = original.TotalSize;
			AvailableSize = original.AvailableSize;
			BmtExist = original.BmtExist;
			Id = original.Id;
		}
	}

	internal class MtkNorInfo 
	{
		protected  Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(MtkNorInfo);
			}
		}

		public int Type { get; set; }

		public int PageSize { get; set; }

		public long AvailableSize { get; set; }

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("MtkNorInfo");
			stringBuilder.Append(" { ");
			if (PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		protected  bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Type = ");
			builder.Append(Type.ToString());
			builder.Append(", PageSize = ");
			builder.Append(PageSize.ToString());
			builder.Append(", AvailableSize = ");
			builder.Append(AvailableSize.ToString());
			return true;
		}

		public static bool operator !=(MtkNorInfo left, MtkNorInfo right)
		{
			return !(left == right);
		}

		public static bool operator ==(MtkNorInfo left, MtkNorInfo right)
		{
			if ((object)left != right)
			{
				return left?.Equals(right) ?? false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return checked(((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Type)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(PageSize)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(AvailableSize));
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as MtkNorInfo);
		}

		public  bool Equals(MtkNorInfo other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && (object)EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(Type, other.Type) && EqualityComparer<int>.Default.Equals(PageSize, other.PageSize))
				{
					return EqualityComparer<long>.Default.Equals(AvailableSize, other.AvailableSize);
				}
				return false;
			}
			return true;
		}



      

        public  MtkNorInfo _get()
		{
			return new MtkNorInfo(this);
		}

		protected MtkNorInfo(MtkNorInfo original)
		{
			Type = original.Type;
			PageSize = original.PageSize;
			AvailableSize = original.AvailableSize;
		}

		public MtkNorInfo()
		{
		}
	}

	internal class MtkUfsInfo 
	{
		protected  Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(MtkUfsInfo);
			}
		}

		public int Type { get; set; }

		public int BlockSize { get; set; }

		public long Lu0Size { get; set; }

		public long Lu1Size { get; set; }

		public long Lu2Size { get; set; }

		public byte[] Cid { get; set; }

		public int FirmwareVersion { get; set; }

		public MtkUfsInfo()
		{
			Cid = new byte[0];
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("MtkUfsInfo");
			stringBuilder.Append(" { ");
			if (PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		protected  bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Type = ");
			builder.Append(Type.ToString());
			builder.Append(", BlockSize = ");
			builder.Append(BlockSize.ToString());
			builder.Append(", Lu0Size = ");
			builder.Append(Lu0Size.ToString());
			builder.Append(", Lu1Size = ");
			builder.Append(Lu1Size.ToString());
			builder.Append(", Lu2Size = ");
			builder.Append(Lu2Size.ToString());
			builder.Append(", Cid = ");
			builder.Append(Cid);
			builder.Append(", FirmwareVersion = ");
			builder.Append(FirmwareVersion.ToString());
			return true;
		}

		public static bool operator !=(MtkUfsInfo left, MtkUfsInfo right)
		{
			return !(left == right);
		}

		public static bool operator ==(MtkUfsInfo left, MtkUfsInfo right)
		{
			if ((object)left != right)
			{
				return left?.Equals(right) ?? false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return checked(((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Type)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(BlockSize)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(Lu0Size)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(Lu1Size)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(Lu2Size)) * -1521134295 + EqualityComparer<byte[]>.Default.GetHashCode(Cid)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(FirmwareVersion));
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as MtkUfsInfo);
		}

		public  bool Equals(MtkUfsInfo other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && (object)EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(Type, other.Type) && EqualityComparer<int>.Default.Equals(BlockSize, other.BlockSize) && EqualityComparer<long>.Default.Equals(Lu0Size, other.Lu0Size) && EqualityComparer<long>.Default.Equals(Lu1Size, other.Lu1Size) && EqualityComparer<long>.Default.Equals(Lu2Size, other.Lu2Size) && EqualityComparer<byte[]>.Default.Equals(Cid, other.Cid))
				{
					return EqualityComparer<int>.Default.Equals(FirmwareVersion, other.FirmwareVersion);
				}
				return false;
			}
			return true;
		}



		public  MtkUfsInfo _get()
		{
			return new MtkUfsInfo(this);
		}

		protected MtkUfsInfo(MtkUfsInfo original)
		{
			Type = original.Type;
			BlockSize = original.BlockSize;
			Lu0Size = original.Lu0Size;
			Lu1Size = original.Lu1Size;
			Lu2Size = original.Lu2Size;
			Cid = original.Cid;
			FirmwareVersion = original.FirmwareVersion;
		}
	}

	public static async Task<MtkDaxFlashInfo> GetStorageInfoAsync(IMtkDevice device, CancellationToken cancellationToken)
	{
		MtkEmmcInfo mtkEmmcInfo = await GetEmmcInfoAsync(device, cancellationToken);
		MtkNandInfo mtkNandInfo = await GetNandInfoAsync(device, cancellationToken);
		MtkNorInfo mtkNorInfo = await GetNorInfoAsync(device, cancellationToken);
		MtkUfsInfo mtkUfsInfo = await GetUfsInfoAsync(device, cancellationToken);
		MtkDaxFlashInfo mtkDaxFlashInfo = new MtkDaxFlashInfo
		{
			PageSize = 512
		};
		if ((object)mtkEmmcInfo != null && mtkEmmcInfo.Type != 0)
		{
			Mediatek.Storage = "EMMC";
			MtkDaxFlashInfo mtkDaxFlashInfo2 = mtkDaxFlashInfo._get();
			mtkDaxFlashInfo2.Type = MtkDaxFlashInfoType.EMMC;
			mtkDaxFlashInfo2.FlashSizes = new long[1] { mtkEmmcInfo.UserSize };
			mtkDaxFlashInfo2.RpmbSize = mtkEmmcInfo.RpmbSize;
			mtkDaxFlashInfo2.Boot1Size = mtkEmmcInfo.Boot1Size;
			Mediatek.BootSize = mtkEmmcInfo.Boot1Size;
			mtkDaxFlashInfo2.Boot2Size = mtkEmmcInfo.Boot2Size;
			Mediatek.mied = BitConverter.ToString(mtkEmmcInfo.Cid).Replace("-", "").Substring(0, 17);
			Form1.SharedUI.ProgressBar1.Text = "Analyze Device...";
			mtkDaxFlashInfo = mtkDaxFlashInfo2;
		}
		else if ((object)mtkNandInfo != null && mtkNandInfo.Type != 0)
		{
			Mediatek.Storage = "NAND";
			MtkDaxFlashInfo mtkDaxFlashInfo3 = mtkDaxFlashInfo._get();
			mtkDaxFlashInfo3.Type = MtkDaxFlashInfoType.NAND;
			mtkDaxFlashInfo3.FlashSizes = new long[1] { mtkNandInfo.TotalSize };
			mtkDaxFlashInfo3.RpmbSize = 0L;
			mtkDaxFlashInfo3.Boot1Size = 4194304L;
			mtkDaxFlashInfo3.Boot2Size = 4194304L;
			mtkDaxFlashInfo = mtkDaxFlashInfo3;
		}
		else if ((object)mtkNorInfo != null && mtkNorInfo.Type != 0)
		{
			Mediatek.Storage = "NOR";
			MtkDaxFlashInfo mtkDaxFlashInfo4 = mtkDaxFlashInfo._get();
			mtkDaxFlashInfo4.Type = MtkDaxFlashInfoType.NOR;
			mtkDaxFlashInfo4.FlashSizes = new long[1] { mtkNorInfo.AvailableSize };
			mtkDaxFlashInfo4.RpmbSize = 0L;
			mtkDaxFlashInfo4.Boot1Size = 4194304L;
			mtkDaxFlashInfo4.Boot2Size = 4194304L;
			mtkDaxFlashInfo = mtkDaxFlashInfo4;
		}
		else
		{
			_ = mtkUfsInfo?.Type;
			Mediatek.Storage = "UFS";
			MtkDaxFlashInfo mtkDaxFlashInfo5 = mtkDaxFlashInfo._get();
			mtkDaxFlashInfo5.Type = MtkDaxFlashInfoType.UFS;
			mtkDaxFlashInfo5.FlashSizes = new long[3] { mtkUfsInfo.Lu0Size, mtkUfsInfo.Lu1Size, mtkUfsInfo.Lu2Size };
			mtkDaxFlashInfo5.RpmbSize = mtkUfsInfo.Lu1Size;
			mtkDaxFlashInfo5.Boot1Size = mtkUfsInfo.Lu1Size;
			Mediatek.BootSize = mtkUfsInfo.Lu1Size;
			mtkDaxFlashInfo5.Boot2Size = mtkUfsInfo.Lu2Size;
			mtkDaxFlashInfo5.PageSize = mtkUfsInfo.BlockSize;
			Form1.SharedUI.ProgressBar1.Text = "Analyze Device...";
			Mediatek.mied = BitConverter.ToString(mtkEmmcInfo.Cid).Replace("-", "").Substring(0, 17);
			mtkDaxFlashInfo = mtkDaxFlashInfo5;
		}
		return mtkDaxFlashInfo;
	}

	public static async Task<MtkDaxFlashInfo> GetStorageInfoAsync2(IMtkDevice device, CancellationToken cancellationToken)
	{
		MtkEmmcInfo mtkEmmcInfo = await GetEmmcInfoAsync(device, cancellationToken);
		MtkNandInfo mtkNandInfo = await GetNandInfoAsync(device, cancellationToken);
		MtkNorInfo mtkNorInfo = await GetNorInfoAsync(device, cancellationToken);
		MtkUfsInfo mtkUfsInfo = await GetUfsInfoAsync(device, cancellationToken);
		MtkDaxFlashInfo mtkDaxFlashInfo = new MtkDaxFlashInfo
		{
			PageSize = 512
		};
		if ((object)mtkEmmcInfo != null && mtkEmmcInfo.Type != 0)
		{
			gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			gui.Richlog("- Memory Type : ", Color.Black);
			gui.Richlog("EMMC", Color.Green, isBold: false, NextLine: true);
			Mediatek.Storage = "EMMC";
			MtkDaxFlashInfo mtkDaxFlashInfo2 = mtkDaxFlashInfo._get();
			mtkDaxFlashInfo2.Type = MtkDaxFlashInfoType.EMMC;
			mtkDaxFlashInfo2.FlashSizes = new long[1] { mtkEmmcInfo.UserSize };
			mtkDaxFlashInfo2.RpmbSize = mtkEmmcInfo.RpmbSize;
			mtkDaxFlashInfo2.Boot1Size = mtkEmmcInfo.Boot1Size;
			mtkDaxFlashInfo2.Boot2Size = mtkEmmcInfo.Boot2Size;
			Mediatek.BootSize = mtkEmmcInfo.Boot1Size;
			gui.Richlog("- BOOT1 Size : ", Color.Black);
			gui.Richlog(utils.GetFileSize(mtkEmmcInfo.Boot1Size), Color.Green, isBold: false, NextLine: true);
			gui.Richlog("- BOOT2 Size : ", Color.Black);
			gui.Richlog(utils.GetFileSize(mtkEmmcInfo.Boot2Size), Color.Green, isBold: false, NextLine: true);
			gui.Richlog("- RPMB Size : ", Color.Black);
			gui.Richlog(utils.GetFileSize(mtkEmmcInfo.RpmbSize), Color.Green, isBold: false, NextLine: true);
			gui.Richlog("- User Size : ", Color.Black);
			gui.Richlog(utils.GetFileSize(mtkEmmcInfo.UserSize), Color.Green, isBold: false, NextLine: true);
			gui.Richlog("- CID : ", Color.Black);
			gui.Richlog(BitConverter.ToString(mtkEmmcInfo.Cid).Replace("-", ""), Color.Green, isBold: false, NextLine: true);
			Mediatek.mied = BitConverter.ToString(mtkEmmcInfo.Cid).Replace("-", "").Substring(0, 17);
			Form1.SharedUI.ProgressBar1.Text = "Analyze Device...";
			mtkDaxFlashInfo = mtkDaxFlashInfo2;
		}
		else if ((object)mtkNandInfo != null && mtkNandInfo.Type != 0)
		{
			Mediatek.Storage = "NAND";
			gui.Richlog("NAND", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			MtkDaxFlashInfo mtkDaxFlashInfo3 = mtkDaxFlashInfo._get();
			mtkDaxFlashInfo3.Type = MtkDaxFlashInfoType.NAND;
			mtkDaxFlashInfo3.FlashSizes = new long[1] { mtkNandInfo.TotalSize };
			gui.Richlog("- Storage Size : ", Color.Black);
			gui.Richlog(utils.GetFileSize(mtkNandInfo.TotalSize), Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			mtkDaxFlashInfo3.RpmbSize = 0L;
			gui.Richlog("- RPMB Size : ", Color.Black);
			gui.Richlog(utils.GetFileSize(0L), Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			mtkDaxFlashInfo3.Boot1Size = 4194304L;
			gui.Richlog("- Boot 1 Size : ", Color.Black);
			gui.Richlog(utils.GetFileSize(4194304L), Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			mtkDaxFlashInfo3.Boot2Size = 4194304L;
			gui.Richlog("- Boot 2 Size : ", Color.Black);
			gui.Richlog(utils.GetFileSize(4194304L), Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			mtkDaxFlashInfo = mtkDaxFlashInfo3;
		}
		else if ((object)mtkNorInfo != null && mtkNorInfo.Type != 0)
		{
			Mediatek.Storage = "NOR";
			gui.Richlog("NOR", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			MtkDaxFlashInfo mtkDaxFlashInfo4 = mtkDaxFlashInfo._get();
			mtkDaxFlashInfo4.Type = MtkDaxFlashInfoType.NOR;
			mtkDaxFlashInfo4.FlashSizes = new long[1] { mtkNorInfo.AvailableSize };
			gui.Richlog("- Storage Size : ", Color.Black);
			gui.Richlog(utils.GetFileSize(mtkNorInfo.AvailableSize), Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			mtkDaxFlashInfo4.RpmbSize = 0L;
			gui.Richlog("- RPMB Size : ", Color.Black);
			gui.Richlog(utils.GetFileSize(0L), Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			mtkDaxFlashInfo4.Boot1Size = 4194304L;
			gui.Richlog("- Boot 1 Size : ", Color.Black);
			gui.Richlog(utils.GetFileSize(4194304L), Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			mtkDaxFlashInfo4.Boot2Size = 4194304L;
			gui.Richlog("- Boot 2 Size : ", Color.Black);
			gui.Richlog(utils.GetFileSize(4194304L), Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			mtkDaxFlashInfo = mtkDaxFlashInfo4;
		}
		else
		{
			_ = mtkUfsInfo?.Type;
			gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			gui.Richlog("- Memory Type : ", Color.Black);
			gui.Richlog("UFS", Color.Green, isBold: false, NextLine: true);
			Mediatek.Storage = "UFS";
			MtkDaxFlashInfo mtkDaxFlashInfo5 = mtkDaxFlashInfo._get();
			mtkDaxFlashInfo5.Type = MtkDaxFlashInfoType.UFS;
			mtkDaxFlashInfo5.FlashSizes = new long[3] { mtkUfsInfo.Lu0Size, mtkUfsInfo.Lu1Size, mtkUfsInfo.Lu2Size };
			mtkDaxFlashInfo5.RpmbSize = mtkUfsInfo.Lu1Size;
			mtkDaxFlashInfo5.Boot1Size = mtkUfsInfo.Lu1Size;
			Mediatek.BootSize = mtkUfsInfo.Lu1Size;
			mtkDaxFlashInfo5.Boot2Size = mtkUfsInfo.Lu2Size;
			mtkDaxFlashInfo5.PageSize = mtkUfsInfo.BlockSize;
			gui.Richlog("- LUN0 Size : ", Color.Black);
			gui.Richlog(utils.GetFileSize(mtkUfsInfo.Lu1Size), Color.Green, isBold: false, NextLine: true);
			gui.Richlog("- LUN1 Size : ", Color.Black);
			gui.Richlog(utils.GetFileSize(mtkUfsInfo.Lu0Size), Color.Green, isBold: false, NextLine: true);
			gui.Richlog("- RPMB Size : ", Color.Black);
			gui.Richlog(utils.GetFileSize(mtkUfsInfo.Lu1Size), Color.Green, isBold: false, NextLine: true);
			gui.Richlog("- User Size : ", Color.Black);
			gui.Richlog(utils.GetFileSize(mtkUfsInfo.Lu2Size), Color.Green, isBold: false, NextLine: true);
			gui.Richlog("- CID : ", Color.Black);
			gui.Richlog(BitConverter.ToString(mtkUfsInfo.Cid).Replace("-", ""), Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			Form1.SharedUI.ProgressBar1.Text = "Analyze Device...";
			Mediatek.mied = BitConverter.ToString(mtkEmmcInfo.Cid).Replace("-", "").Substring(0, 17);
			mtkDaxFlashInfo = mtkDaxFlashInfo5;
		}
		return mtkDaxFlashInfo;
	}

	private static async Task<MtkEmmcInfo> GetEmmcInfoAsync(IMtkDevice device, CancellationToken cancellationToken)
	{
		byte[] array = await MtkDaxDeviceControlService.SendDevCtrlAsync(device, 262145u, cancellationToken);
		if (array.Length != 0)
		{
			byte[] array2 = new byte[16];
			Array.Copy(array, 72, array2, 0, 16);
			byte[] array3 = new byte[checked(array.Length - 97 + 1)];
			Array.Copy(array, 96, array3, 0, array3.Length);
			return new MtkEmmcInfo
			{
				Type = BitConverter.ToInt32(array, 0),
				BlockSize = BitConverter.ToInt32(array, 4),
				Boot1Size = BitConverter.ToInt64(array, 8),
				Boot2Size = BitConverter.ToInt64(array, 16),
				RpmbSize = BitConverter.ToInt64(array, 24),
				Gp1Size = BitConverter.ToInt64(array, 32),
				Gp2Size = BitConverter.ToInt64(array, 40),
				Gp3Size = BitConverter.ToInt64(array, 48),
				Gp4Size = BitConverter.ToInt64(array, 56),
				UserSize = BitConverter.ToInt64(array, 64),
				Cid = array2,
				FirmwareVersion = BitConverter.ToInt64(array, 88),
				Unknown = array3
			};
		}
		return null;
	}

	private static async Task<MtkNandInfo> GetNandInfoAsync(IMtkDevice device, CancellationToken cancellationToken)
	{
		byte[] array = await MtkDaxDeviceControlService.SendDevCtrlAsync(device, 262146u, cancellationToken);
		if (array.Length != 0)
		{
			MtkNandInfo mtkNandInfo = new MtkNandInfo();
			mtkNandInfo.Type = BitConverter.ToInt32(array, 0);
			mtkNandInfo.PageSize = BitConverter.ToInt32(array, 4);
			mtkNandInfo.BlockSize = BitConverter.ToInt32(array, 8);
			mtkNandInfo.SpareSize = BitConverter.ToInt32(array, 12);
			mtkNandInfo.TotalSize = BitConverter.ToInt64(array, 16);
			mtkNandInfo.AvailableSize = BitConverter.ToInt64(array, 24);
			mtkNandInfo.BmtExist = array[32];
			mtkNandInfo.Id = Encoding.UTF8.GetString(array, 33, 12).TrimEnd(default(char));
			return mtkNandInfo;
		}
		return null;
	}

	private static async Task<MtkNorInfo> GetNorInfoAsync(IMtkDevice device, CancellationToken cancellationToken)
	{
		byte[] array = await MtkDaxDeviceControlService.SendDevCtrlAsync(device, 262147u, cancellationToken);
		if (array.Length != 0)
		{
			return new MtkNorInfo
			{
				Type = BitConverter.ToInt32(array, 0),
				PageSize = BitConverter.ToInt32(array, 4),
				AvailableSize = BitConverter.ToInt64(array, 8)
			};
		}
		return null;
	}

	private static async Task<MtkUfsInfo> GetUfsInfoAsync(IMtkDevice device, CancellationToken cancellationToken)
	{
		byte[] array = await MtkDaxDeviceControlService.SendDevCtrlAsync(device, 262148u, cancellationToken);
		if (array.Length != 0)
		{
			byte[] array2 = new byte[16];
			Array.Copy(array, 32, array2, 0, 16);
			return new MtkUfsInfo
			{
				Type = BitConverter.ToInt32(array, 0),
				BlockSize = BitConverter.ToInt32(array, 4),
				Lu0Size = BitConverter.ToInt64(array, 8),
				Lu1Size = BitConverter.ToInt64(array, 16),
				Lu2Size = BitConverter.ToInt64(array, 24),
				Cid = array2,
				FirmwareVersion = BitConverter.ToInt32(array, 48)
			};
		}
		return null;
	}
}
