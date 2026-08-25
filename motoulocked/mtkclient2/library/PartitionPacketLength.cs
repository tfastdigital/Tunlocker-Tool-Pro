using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace motoulocked.mtkclient2.library;

internal class PartitionPacketLength : IEquatable<PartitionPacketLength>
{
	protected  Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(PartitionPacketLength);
		}
	}

	public int WriteLen { get; set; }

	public int ReadLen { get; set; }

	public PartitionPacketLength(int WriteLen, int ReadLen)
	{
		this.WriteLen = WriteLen;
		this.ReadLen = ReadLen;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("PartitionPacketLength");
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
		builder.Append("WriteLen = ");
		builder.Append(WriteLen.ToString());
		builder.Append(", ReadLen = ");
		builder.Append(ReadLen.ToString());
		return true;
	}

	public static bool operator !=(PartitionPacketLength left, PartitionPacketLength right)
	{
		return !(left == right);
	}

	public static bool operator ==(PartitionPacketLength left, PartitionPacketLength right)
	{
		if ((object)left != right)
		{
			return left?.Equals(right) ?? false;
		}
		return true;
	}

	public override int GetHashCode()
	{
		return checked((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(WriteLen)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(ReadLen));
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as PartitionPacketLength);
	}

	public  bool Equals(PartitionPacketLength other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && (object)EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(WriteLen, other.WriteLen))
			{
				return EqualityComparer<int>.Default.Equals(ReadLen, other.ReadLen);
			}
			return false;
		}
		return true;
	}


	public  PartitionPacketLength _get()
	{
		return new PartitionPacketLength(this);
	}

	protected PartitionPacketLength(PartitionPacketLength original)
	{
		WriteLen = original.WriteLen;
		ReadLen = original.ReadLen;
	}

	public void Deconstruct(out int WriteLen, out int ReadLen)
	{
		WriteLen = this.WriteLen;
		ReadLen = this.ReadLen;
	}
}
