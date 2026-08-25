using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.Operations.Ext4;

[StandardModule]
internal sealed class Native
{
	internal struct Ext4BlockDevice
	{
		public IntPtr Pointer;
	}

	[DllImport("ext4_lib.dll", CharSet = CharSet.Ansi, EntryPoint = "get_file_size", ExactSpelling = true, SetLastError = true)]
	private static extern int get_file_size_32(Ext4BlockDevice dev, [MarshalAs(UnmanagedType.VBByRefStr)] ref string targetPath, out long size);

	[DllImport("ext4_lib.dll", CharSet = CharSet.Ansi, EntryPoint = "get_file_size", ExactSpelling = true, SetLastError = true)]
	private static extern int file_size_64(Ext4BlockDevice dev, [MarshalAs(UnmanagedType.VBByRefStr)] ref string targetPath, out long size);

	[DllImport("ext4_lib.dll", CharSet = CharSet.Ansi, EntryPoint = "init_blockdev", ExactSpelling = true, SetLastError = true)]
	private static extern int init_blockdev_1(out Ext4BlockDevice dev);

	[DllImport("ext4_lib.dll", CharSet = CharSet.Ansi, EntryPoint = "init_blockdev", ExactSpelling = true, SetLastError = true)]
	private static extern int init_blockdev_2(out Ext4BlockDevice dev);

	[DllImport("ext4_lib.dll", CharSet = CharSet.Ansi, EntryPoint = "free_blockdev", ExactSpelling = true, SetLastError = true)]
	private static extern void free_blockdev_1(Ext4BlockDevice dev);

	[DllImport("ext4_lib.dll", CharSet = CharSet.Ansi, EntryPoint = "free_blockdev", ExactSpelling = true, SetLastError = true)]
	private static extern void free_blockdev_2(Ext4BlockDevice dev);

	[DllImport("ext4_lib.dll", CharSet = CharSet.Ansi, EntryPoint = "set_blockdev_mem", ExactSpelling = true, SetLastError = true)]
	private static extern int set_blockdev_mem_64(Ext4BlockDevice dev, IntPtr buffer, int len, int value);

	[DllImport("ext4_lib.dll", CharSet = CharSet.Ansi, EntryPoint = "set_blockdev_mem", ExactSpelling = true, SetLastError = true)]
	private static extern int set_blockdev_mem_32(Ext4BlockDevice dev, IntPtr buffer, int len, int value);

	[DllImport("ext4_lib.dll", CharSet = CharSet.Ansi, EntryPoint = "mount", ExactSpelling = true, SetLastError = true)]
	private static extern int mount_1(Ext4BlockDevice dev);

	[DllImport("ext4_lib.dll", CharSet = CharSet.Ansi, EntryPoint = "mount", ExactSpelling = true, SetLastError = true)]
	private static extern int mount_2(Ext4BlockDevice dev);

	[DllImport("ext4_lib.dll", CharSet = CharSet.Ansi, EntryPoint = "unmount", ExactSpelling = true, SetLastError = true)]
	private static extern int unmount_1(Ext4BlockDevice dev);

	[DllImport("ext4_lib.dll", CharSet = CharSet.Ansi, EntryPoint = "unmount", ExactSpelling = true, SetLastError = true)]
	private static extern int unmount_2(Ext4BlockDevice dev);

	[DllImport("ext4_lib.dll", CharSet = CharSet.Ansi, EntryPoint = "is_exist", ExactSpelling = true, SetLastError = true)]
	private static extern bool is_exist_1(Ext4BlockDevice dev, [MarshalAs(UnmanagedType.VBByRefStr)] ref string path);

	[DllImport("ext4_lib.dll", CharSet = CharSet.Ansi, EntryPoint = "is_exist", ExactSpelling = true, SetLastError = true)]
	private static extern bool is_exist_2(Ext4BlockDevice dev, [MarshalAs(UnmanagedType.VBByRefStr)] ref string path);

	[DllImport("ext4_lib.dll", CharSet = CharSet.Ansi, EntryPoint = "delete_file", ExactSpelling = true, SetLastError = true)]
	private static extern int delete_file_1(Ext4BlockDevice dev, [MarshalAs(UnmanagedType.VBByRefStr)] ref string path);

	[DllImport("ext4_lib.dll", CharSet = CharSet.Ansi, EntryPoint = "delete_file", ExactSpelling = true, SetLastError = true)]
	private static extern int delete_file_2(Ext4BlockDevice dev, [MarshalAs(UnmanagedType.VBByRefStr)] ref string path);

	[DllImport("ext4_lib.dll", CharSet = CharSet.Ansi, EntryPoint = "read_file", ExactSpelling = true, SetLastError = true)]
	private static extern int read_file_1(Ext4BlockDevice dev, [MarshalAs(UnmanagedType.VBByRefStr)] ref string path, [Out] byte[] buffer, long offset, int len, out int totalRead);

	[DllImport("ext4_lib.dll", CharSet = CharSet.Ansi, EntryPoint = "read_file", ExactSpelling = true, SetLastError = true)]
	private static extern int read_file_2(Ext4BlockDevice dev, [MarshalAs(UnmanagedType.VBByRefStr)] ref string path, [Out] byte[] buffer, long offset, int len, out int totalRead);

	[DllImport("ext4_lib.dll", CharSet = CharSet.Ansi, EntryPoint = "write_file", ExactSpelling = true, SetLastError = true)]
	private static extern int write_file_1(Ext4BlockDevice dev, [MarshalAs(UnmanagedType.VBByRefStr)] ref string path, byte[] buffer, long offset, int len);

	[DllImport("ext4_lib.dll", CharSet = CharSet.Ansi, EntryPoint = "write_file", ExactSpelling = true, SetLastError = true)]
	private static extern int write_file_2(Ext4BlockDevice dev, [MarshalAs(UnmanagedType.VBByRefStr)] ref string path, byte[] buffer, long offset, int len);

	public static int blockdev_mem(Ext4BlockDevice dev, IntPtr buffer, int len, int value)
	{
		if (Environment.Is64BitProcess)
		{
			return set_blockdev_mem_64(dev, buffer, len, value);
		}
		return set_blockdev_mem_32(dev, buffer, len, value);
	}

	public static int file_size(Ext4BlockDevice dev, string targetPath, out long size)
	{
		if (!Environment.Is64BitProcess)
		{
			return get_file_size_32(dev, ref targetPath, out size);
		}
		return file_size_64(dev, ref targetPath, out size);
	}

	public static int init_blockdev(out Ext4BlockDevice dev)
	{
		if (!Environment.Is64BitProcess)
		{
			return init_blockdev_1(out dev);
		}
		return init_blockdev_2(out dev);
	}

	public static void free_blockdev(Ext4BlockDevice dev)
	{
		if (!Environment.Is64BitProcess)
		{
			free_blockdev_1(dev);
		}
		else
		{
			free_blockdev_2(dev);
		}
	}

	public static int mount(Ext4BlockDevice dev)
	{
		if (!Environment.Is64BitProcess)
		{
			return mount_1(dev);
		}
		return mount_2(dev);
	}

	public static int unmount(Ext4BlockDevice dev)
	{
		if (!Environment.Is64BitProcess)
		{
			return unmount_1(dev);
		}
		return unmount_2(dev);
	}

	public static bool is_exist(Ext4BlockDevice dev, string path)
	{
		if (Environment.Is64BitProcess)
		{
			return is_exist_2(dev, ref path);
		}
		return is_exist_1(dev, ref path);
	}

	public static int delete_file(Ext4BlockDevice dev, string path)
	{
		if (!Environment.Is64BitProcess)
		{
			return delete_file_1(dev, ref path);
		}
		return delete_file_2(dev, ref path);
	}

	public static int read_file(Ext4BlockDevice dev, string path, [Out] byte[] buffer, long offset, int len, out int totalRead)
	{
		if (!Environment.Is64BitProcess)
		{
			return read_file_1(dev, ref path, buffer, offset, len, out totalRead);
		}
		return read_file_2(dev, ref path, buffer, offset, len, out totalRead);
	}

	public static int write_file(Ext4BlockDevice dev, string path, byte[] buffer, long offset, int len)
	{
		if (!Environment.Is64BitProcess)
		{
			return write_file_1(dev, ref path, buffer, offset, len);
		}
		return write_file_2(dev, ref path, buffer, offset, len);
	}
}
