using System;
using System.IO;
using System.Windows.Forms;

namespace motoulocked.motoulocked;

public class FolderPicker : IDisposable
{
	private string m_InitialFolder;

	private string m_DefaultFolder;

	private string m_Folder;

	public string InitialFolder
	{
		get
		{
			return m_InitialFolder;
		}
		set
		{
			m_InitialFolder = value;
		}
	}

	public string DefaultFolder
	{
		get
		{
			return m_DefaultFolder;
		}
		set
		{
			m_DefaultFolder = value;
		}
	}

	public string Folder
	{
		get
		{
			return m_Folder;
		}
		private set
		{
			m_Folder = value;
		}
	}

	public DialogResult ShowDialog(IWin32Window owner)
	{
		if (Environment.OSVersion.Version.Major >= 6)
		{
			return ShowVistaDialog(owner);
		}
		return ShowLegacyDialog(owner);
	}

	private DialogResult ShowVistaDialog(IWin32Window owner)
	{
		NativeMethods2.IFileDialog fileDialog = (NativeMethods2.IFileDialog)new NativeMethods2.FileOpenDialogRCW();
		uint fos = default(uint);
		fileDialog.GetOptions(ref fos);
		fos = fos | 0x20u | 0x40u | 0x100u | 0x10000u | 0x2000000u;
		fileDialog.SetOptions(fos);
		if (!string.IsNullOrEmpty(InitialFolder))
		{
			NativeMethods2.IShellItem ppv = null;
			if (NativeMethods2.SHCreateItemFromParsingName(riid: new Guid("43826D1E-E718-42EE-BC55-A1E261C37BFE"), pszPath: InitialFolder, pbc: IntPtr.Zero, ppv: ref ppv) == 0)
			{
				fileDialog.SetFolder(ppv);
			}
		}
		if (!string.IsNullOrEmpty(DefaultFolder))
		{
			NativeMethods2.IShellItem ppv2 = null;
			if (NativeMethods2.SHCreateItemFromParsingName(riid: new Guid("43826D1E-E718-42EE-BC55-A1E261C37BFE"), pszPath: DefaultFolder, pbc: IntPtr.Zero, ppv: ref ppv2) == 0)
			{
				fileDialog.SetDefaultFolder(ppv2);
			}
		}
		if (fileDialog.Show(owner.Handle) == 0)
		{
			NativeMethods2.IShellItem ppsi = null;
			if (fileDialog.GetResult(ref ppsi) == 0)
			{
				string ppszName = null;
				if (ppsi.GetDisplayName(2147844096u, ref ppszName) == 0 && !string.IsNullOrEmpty(ppszName))
				{
					UiManager.Selected_Folder = ppszName;
					return DialogResult.OK;
				}
			}
		}
		return DialogResult.Cancel;
	}

	private DialogResult ShowLegacyDialog(IWin32Window owner)
	{
		using SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.CheckFileExists = false;
		saveFileDialog.CheckPathExists = true;
		saveFileDialog.CreatePrompt = false;
		saveFileDialog.Filter = "|" + Guid.Empty.ToString();
		saveFileDialog.FileName = "any";
		if (!string.IsNullOrEmpty(InitialFolder))
		{
			saveFileDialog.InitialDirectory = InitialFolder;
		}
		saveFileDialog.OverwritePrompt = false;
		saveFileDialog.Title = "Select Folder";
		saveFileDialog.ValidateNames = false;
		if (saveFileDialog.ShowDialog(owner) == DialogResult.OK)
		{
			Folder = Path.GetDirectoryName(saveFileDialog.FileName);
			return DialogResult.OK;
		}
		return DialogResult.Cancel;
	}

	public void Dispose()
	{
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Dispose
		this.Dispose();
	}
}
