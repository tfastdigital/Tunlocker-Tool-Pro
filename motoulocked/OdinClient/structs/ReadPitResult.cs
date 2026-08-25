using System.Collections.Generic;
using motoulocked.OdinClient.Pit;

namespace motoulocked.OdinClient.structs;

public struct ReadPitResult
{
	public bool Result;

	public byte[] data;

	public string error;

	public List<TPIT_Entry> Pit;
}
