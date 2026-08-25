using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace motoulocked.mtkclient2.library;

internal class MtkDaxUploadResult : IEquatable<MtkDaxUploadResult>
{
	protected  Type EqualityContract => typeof(MtkDaxUploadResult);

	public IMtkDevice Device { get; set; }

	public MtkDaxFlashInfo FlashInfo { get; set; }

	public MtkDaxUploadResult(IMtkDevice Device, MtkDaxFlashInfo FlashInfo)
	{
		this.Device = Device;
		this.FlashInfo = FlashInfo;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("MtkDaxUploadResult");
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
		builder.Append("Device = ");
		builder.Append(Device);
		builder.Append(", FlashInfo = ");
		builder.Append(FlashInfo);
		return true;
	}

	public static bool operator !=(MtkDaxUploadResult left, MtkDaxUploadResult right)
	{
		return !(left == right);
	}

	public static bool operator ==(MtkDaxUploadResult left, MtkDaxUploadResult right)
	{
		if ((object)left != right)
		{
			return left?.Equals(right) ?? false;
		}
		return true;
	}

	public override int GetHashCode()
	{
		return checked((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<IMtkDevice>.Default.GetHashCode(Device)) * -1521134295 + EqualityComparer<MtkDaxFlashInfo>.Default.GetHashCode(FlashInfo));
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as MtkDaxUploadResult);
	}

	public  bool Equals(MtkDaxUploadResult other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && (object)EqualityContract == other.EqualityContract && EqualityComparer<IMtkDevice>.Default.Equals(Device, other.Device))
			{
				return EqualityComparer<MtkDaxFlashInfo>.Default.Equals(FlashInfo, other.FlashInfo);
			}
			return false;
		}
		return true;
	}


	public  MtkDaxUploadResult _get()
	{
		return new MtkDaxUploadResult(this);
	}

	protected MtkDaxUploadResult(MtkDaxUploadResult original)
	{
		Device = original.Device;
		FlashInfo = original.FlashInfo;
	}

	public void Deconstruct(out IMtkDevice Device, out MtkDaxFlashInfo FlashInfo)
	{
		Device = this.Device;
		FlashInfo = this.FlashInfo;
	}
}
