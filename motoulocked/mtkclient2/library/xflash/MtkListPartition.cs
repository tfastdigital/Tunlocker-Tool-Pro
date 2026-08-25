namespace motoulocked.mtkclient2.library.xflash;

internal class MtkListPartition
{
	public string name { get; set; }

	public long address { get; set; }

	public long size { get; set; }

	public MtkListPartition[] Partitions { get; set; }

	public MtkListPartition()
	{
		Partitions = new MtkListPartition[0];
	}

	public  MtkListPartition _get()
	{
		return new MtkListPartition(this);
	}

	protected MtkListPartition(MtkListPartition original)
	{
		name = original.name;
		address = original.address;
		size = original.size;
	}
}
