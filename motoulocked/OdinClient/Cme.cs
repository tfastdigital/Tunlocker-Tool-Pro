using motoulocked.OdinClient.Pit;

namespace motoulocked.OdinClient;

public class Cme
{
	public TPIT_Entry frp_entry { get; set; }

	public TPIT_Entry pit_entry { get; set; }

	public byte[] ori_pit { get; set; }
}
