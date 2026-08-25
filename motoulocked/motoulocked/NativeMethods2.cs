using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.motoulocked;

[StandardModule]
internal sealed class NativeMethods2
{
	[ComImport]
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	[Guid("DC1C5A9C-E88A-4DDE-A5A1-60F82A20AEF7")]
	internal class FileOpenDialogRCW
	{
	}

	[ComImport]
	[Guid("42F85136-DB7E-439C-85F1-E4075D135FC8")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	internal interface IFileDialog
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint Show([Optional][In] IntPtr hwndOwner);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint SetFileTypes([In] uint cFileTypes, [In][MarshalAs(UnmanagedType.LPArray)] IntPtr rgFilterSpec);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint SetFileTypeIndex([In] uint iFileType);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint GetFileTypeIndex(ref uint piFileType);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint Advise([In][MarshalAs(UnmanagedType.Interface)] IntPtr pfde, ref uint pdwCookie);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint Unadvise([In] uint dwCookie);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint SetOptions([In] uint fos);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint GetOptions(ref uint fos);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetDefaultFolder([In][MarshalAs(UnmanagedType.Interface)] IShellItem psi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint SetFolder([In][MarshalAs(UnmanagedType.Interface)] IShellItem psi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint GetFolder([MarshalAs(UnmanagedType.Interface)] ref IShellItem ppsi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint GetCurrentSelection([MarshalAs(UnmanagedType.Interface)] ref IShellItem ppsi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint SetFileName([In][MarshalAs(UnmanagedType.LPWStr)] string pszName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint GetFileName([MarshalAs(UnmanagedType.LPWStr)] ref string pszName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint SetTitle([In][MarshalAs(UnmanagedType.LPWStr)] string pszTitle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint SetOkButtonLabel([In][MarshalAs(UnmanagedType.LPWStr)] string pszText);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint SetFileNameLabel([In][MarshalAs(UnmanagedType.LPWStr)] string pszLabel);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint GetResult([MarshalAs(UnmanagedType.Interface)] ref IShellItem ppsi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint AddPlace([In][MarshalAs(UnmanagedType.Interface)] IShellItem psi, uint fdap);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint SetDefaultExtension([In][MarshalAs(UnmanagedType.LPWStr)] string pszDefaultExtension);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint Close([MarshalAs(UnmanagedType.Error)] uint hr);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint SetClientGuid([In] ref Guid guid);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint ClearClientData();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint SetFilter([In][MarshalAs(UnmanagedType.Interface)] IntPtr pFilter);
	}

	[ComImport]
	[Guid("43826D1E-E718-42EE-BC55-A1E261C37BFE")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	internal interface IShellItem
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint BindToHandler(IntPtr pbc, ref Guid bhid, ref Guid riid, [MarshalAs(UnmanagedType.Interface)] ref IntPtr ppv);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint GetParent([MarshalAs(UnmanagedType.Interface)] ref IShellItem ppsi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint GetDisplayName([In] uint sigdnName, [MarshalAs(UnmanagedType.LPWStr)] ref string ppszName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint GetAttributes([In] uint sfgaoMask, ref uint psfgaoAttribs);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint Compare([MarshalAs(UnmanagedType.Interface)] IShellItem psi, uint hint, ref int piOrder);
	}

	public const uint FOS_PICKFOLDERS = 32u;

	public const uint FOS_FORCEFILESYSTEM = 64u;

	public const uint FOS_NOVALIDATE = 256u;

	public const uint FOS_NOTESTFILECREATE = 65536u;

	public const uint FOS_DONTADDTORECENT = 33554432u;

	public const uint S_OK = 0u;

	public const uint SIGDN_FILESYSPATH = 2147844096u;

	[DllImport("shell32.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
	public static extern int SHCreateItemFromParsingName([MarshalAs(UnmanagedType.LPWStr)] string pszPath, IntPtr pbc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.Interface)] ref IShellItem ppv);
}
