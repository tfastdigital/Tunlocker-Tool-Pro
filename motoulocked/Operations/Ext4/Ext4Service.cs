using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace motoulocked.Operations.Ext4;

internal class Ext4Service : IExt4Service
{
	[STAThread]
	public Task DeleteFileAsync(byte[] partitionBuff, int blockSize, string targetPath)
	{
		int num;
		if ((num = Native.init_blockdev(out var dev)) == 0)
		{
			GCHandle gCHandle = GCHandle.Alloc(partitionBuff, GCHandleType.Pinned);
			IntPtr buffer = gCHandle.AddrOfPinnedObject();
			try
			{
				int num2;
				if ((num2 = Native.blockdev_mem(dev, buffer, partitionBuff.Length, blockSize)) != 0)
				{
					throw new Exception("Error setting block device buffer: " + num2);
				}
				int num3;
				if ((num3 = Native.mount(dev)) != 0)
				{
					throw new Exception("Error mounting partition: " + num3);
				}
				if (!Native.is_exist(dev, targetPath))
				{
					throw new FileNotFoundException("Target file does not exist in the partition", targetPath);
				}
				int num4;
				if ((num4 = Native.delete_file(dev, targetPath)) != 0)
				{
					throw new Exception("Error deleting file: " + num4);
				}
			}
			finally
			{
				Native.unmount(dev);
				Native.free_blockdev(dev);
				gCHandle.Free();
			}
			return Task.CompletedTask;
		}
		throw new Exception("Error initializing block device: " + num);
	}

	Task IExt4Service.DeleteFileAsync(byte[] partitionBuff, int blockSize, string targetPath)
	{
		//ILSpy generated this explicit interface implementation from .override directive in DeleteFileAsync
		return this.DeleteFileAsync(partitionBuff, blockSize, targetPath);
	}

	public Task<long> GetFileSizeAsync(byte[] partitionBuff, int blockSize, string targetPath)
	{
		int num;
		if ((num = Native.init_blockdev(out var dev)) != 0)
		{
			throw new Exception("Error initializing block device: " + num);
		}
		GCHandle gCHandle = GCHandle.Alloc(partitionBuff, GCHandleType.Pinned);
		IntPtr buffer = gCHandle.AddrOfPinnedObject();
		try
		{
			int num2;
			if ((num2 = Native.blockdev_mem(dev, buffer, partitionBuff.Length, blockSize)) != 0)
			{
				throw new Exception("Error setting block device buffer: " + num2);
			}
			int num3;
			if ((num3 = Native.mount(dev)) != 0)
			{
				throw new Exception("Error mounting partition: " + num3);
			}
			if (!Native.is_exist(dev, targetPath))
			{
				throw new FileNotFoundException("Target file does not exist in the partition", targetPath);
			}
			int num4;
			if ((num4 = Native.file_size(dev, targetPath, out var size)) != 0)
			{
				throw new Exception("Error getting file size: " + num4);
			}
			return Task.FromResult(size);
		}
		finally
		{
			Native.unmount(dev);
			Native.free_blockdev(dev);
			gCHandle.Free();
		}
	}

	Task<long> IExt4Service.GetFileSizeAsync(byte[] partitionBuff, int blockSize, string targetPath)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetFileSizeAsync
		return this.GetFileSizeAsync(partitionBuff, blockSize, targetPath);
	}

	public Task<byte[]> ReadFileAsync(byte[] partitionBuff, int blockSize, string targetPath)
	{
		int num;
		if ((num = Native.init_blockdev(out var dev)) != 0)
		{
			throw new Exception("Error initializing block device: " + num);
		}
		GCHandle gCHandle = GCHandle.Alloc(partitionBuff, GCHandleType.Pinned);
		IntPtr buffer = gCHandle.AddrOfPinnedObject();
		try
		{
			int num2;
			if ((num2 = Native.blockdev_mem(dev, buffer, partitionBuff.Length, blockSize)) != 0)
			{
				throw new Exception("Error setting block device buffer: " + num2);
			}
			int num3;
			if ((num3 = Native.mount(dev)) != 0)
			{
				throw new Exception("Error mounting partition: " + num3);
			}
			if (!Native.is_exist(dev, targetPath))
			{
				throw new FileNotFoundException("Target file does not exist in the partition", targetPath);
			}
			int num4;
			if ((num4 = Native.file_size(dev, targetPath, out var size)) != 0)
			{
				throw new Exception("Error getting file size: " + num4);
			}
			byte[] array = new byte[checked((int)size - 1 + 1)];
			int num5;
			if ((num5 = Native.read_file(dev, targetPath, array, 0L, array.Length, out var totalRead)) != 0)
			{
				throw new Exception("Error reading file: " + num5);
			}
			if (totalRead != array.Length)
			{
				throw new Exception("Only able to read: " + totalRead);
			}
			return Task.FromResult(array);
		}
		finally
		{
			Native.unmount(dev);
			Native.free_blockdev(dev);
			gCHandle.Free();
		}
	}

	Task<byte[]> IExt4Service.ReadFileAsync(byte[] partitionBuff, int blockSize, string targetPath)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ReadFileAsync
		return this.ReadFileAsync(partitionBuff, blockSize, targetPath);
	}

	public Task WriteFileAsync(byte[] partitionBuff, int blockSize, string targetPath, byte[] data)
	{
		int num;
		if ((num = Native.init_blockdev(out var dev)) == 0)
		{
			GCHandle gCHandle = GCHandle.Alloc(partitionBuff, GCHandleType.Pinned);
			IntPtr buffer = gCHandle.AddrOfPinnedObject();
			try
			{
				int num2;
				if ((num2 = Native.blockdev_mem(dev, buffer, partitionBuff.Length, blockSize)) != 0)
				{
					throw new Exception("Error setting block device buffer: " + num2);
				}
				int num3;
				if ((num3 = Native.mount(dev)) != 0)
				{
					throw new Exception("Error mounting partition: " + num3);
				}
				int num4;
				if ((num4 = Native.write_file(dev, targetPath, data, 0L, data.Length)) != 0)
				{
					throw new Exception("Error reading file: " + num4);
				}
				return Task.CompletedTask;
			}
			finally
			{
				Native.unmount(dev);
				Native.free_blockdev(dev);
				gCHandle.Free();
			}
		}
		throw new Exception("Error initializing block device: " + num);
	}

	Task IExt4Service.WriteFileAsync(byte[] partitionBuff, int blockSize, string targetPath, byte[] data)
	{
		//ILSpy generated this explicit interface implementation from .override directive in WriteFileAsync
		return this.WriteFileAsync(partitionBuff, blockSize, targetPath, data);
	}
}
