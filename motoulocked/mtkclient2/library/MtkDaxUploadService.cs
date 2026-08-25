using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.motoulocked;
using motoulocked.mtkclient2.devicehandler;
using motoulocked.mtkclient2.library.xflash;
using motoulocked.mtkclient2.MTK.Client.Scatter;
using motoulocked.mtkclient2.Tasks;

namespace motoulocked.mtkclient2.library;

internal class MtkDaxUploadService
{
	public static async Task<MtkDaxUploadResult> UploadAsync1(MtkSerialDevice device, MtkChipConfig chipConfig, byte[] emi, CancellationToken cancellationToken)
	{
		SerialCOM.MSL = "DISREAD";
		Form1.SharedUI.ProgressBar4.Text = "";
		Form1.SharedUI.ProgressBar4.Value = 0;
		gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		gui.Richlog("- Initialize Device : ", Color.Black);
		Form1.SharedUI.ProgressBar1.Text = "Initialize Device...";
		string path = Application.StartupPath + "\\mtk\\common\\da_2228";
		MtkDaEntry mtkDaEntry;
		byte[] da;
		byte[] da2;
		using (Stream stream = File.OpenRead(path))
		{
			stream.Seek(0L, SeekOrigin.Begin);
			MtkDaEntry[] source = await MtkDaService.GetEntriesAsync(stream);
			stream.Seek(0L, SeekOrigin.Begin);
			mtkDaEntry = source.Where([SpecialName] (MtkDaEntry x) => chipConfig.DaCode == x.HardwareCode).FirstOrDefault();
			da = await MtkDaService.GetStage1Async(stream, mtkDaEntry);
			stream.Seek(0L, SeekOrigin.Begin);
			da2 = await MtkDaService.GetStage2Async(stream, mtkDaEntry);
		}
		if ((object)mtkDaEntry != null)
		{
			MtkDaxUploadCalculationResult mtkDaxUploadCalculationResult = MtkDaxUploadCalculatorService.Calculate(da, da2, mtkDaEntry.Regions[2].StartAddress, mtkDaEntry.Regions[2].SignatureLength);
			await MtkDaWriteService.WriteAsync(device, mtkDaEntry.Regions[1].StartAddress, mtkDaEntry.Regions[1].SignatureLength, mtkDaxUploadCalculationResult.Da1, validateUploadStatus: true, cancellationToken);
			await MtkDaWriteService.JumpAsync(device, mtkDaEntry.Regions[1].StartAddress, cancellationToken);
			await MtkDaxUploadSyncService.SyncAsync(device, cancellationToken);
			await MtkDaxDeviceControlSetupService.GetExpireDateAsync(device, cancellationToken);
			await MtkDaxDeviceControlSetupService.SetResetKeyAsync(device, 104u, cancellationToken);
			await MtkDaxDeviceControlSetupService.SetChecksumLevelAsync(device, 0u, cancellationToken);
			string left = await MtkDaxDeviceControlSetupService.GetConnectionAgentAsync(device, cancellationToken);
			bool flag = default(bool);
			MtkDaxUploadResult result = default(MtkDaxUploadResult);
			try
			{
				if (Operators.CompareString(left, "brom", TextCompare: false) == 0)
				{
					await MtkDaxUploadEmiService.UploadEmiAsync(device, emi, cancellationToken);
				}
				else
				{
					Operators.CompareString(left, "preloader", TextCompare: false);
				}
				await MtkDaxUploadBootService.BootToAsync(device, mtkDaEntry.Regions[2].StartAddress, mtkDaxUploadCalculationResult.Da2, cancellationToken);
				flag = false;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				MtkTask.CHECK = "no";
				if (flag)
				{
					device?.Dispose();
				}
				ProjectData.ClearProjectError();
				return result;
			}
			try
			{
				MtkDaxFlashInfo mtkDaxFlashInfo = await MtkDaxDeviceStorageInfoService.GetStorageInfoAsync(device, cancellationToken);
				if (Form1.SharedUI.CkAutoSwitchHighSpeedUSB.Checked)
				{
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Memory Type : ", Color.Black);
					gui.Richlog(Mediatek.Storage, Color.LightGreen, isBold: false, NextLine: true);
					gui.Richlog("- Switch To Usb High-Speed : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Switching...";
				}
				await MtkDaxUploadBootService.BootToAsync(device, 1744830464L, mtkDaxUploadCalculationResult.Extension, cancellationToken);
				await MtkDaxDeviceControlSetupService.SendCustomAckAsync(device, cancellationToken);
				PartitionPacketLength partitionPacketLength = await MtkDaxPartitionPacketLengthService.GetAsync(device, cancellationToken);
				MtkDaxFlashInfo mtkDaxFlashInfo2 = mtkDaxFlashInfo._get();
				mtkDaxFlashInfo2.WriteBufferSize = partitionPacketLength.WriteLen;
				mtkDaxFlashInfo2.ReadBufferSize = partitionPacketLength.ReadLen;
				mtkDaxFlashInfo = mtkDaxFlashInfo2;
				if (Form1.SharedUI.CkAutoSwitchHighSpeedUSB.Checked)
				{
					await MtkDaxUploadSetupService.SwitchUsbSpeedAsync(device, cancellationToken);
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Wait For Mtk Device : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Search...";
				}
				device.Dispose();
				if (Operators.CompareString(MtkTask.Check_Preloader, "OK", TextCompare: false) != 0)
				{
					await Task.Delay(TimeSpan.FromSeconds(2.0));
				}
				else
				{
					await Task.Delay(TimeSpan.FromSeconds(3.0));
				}
				device = (MtkSerialDevice)(IMtkSerialDevice)(await MtkDeviceWaiterService.WaitSerialAsync4(doHandshake: false, cancellationToken)).Device;
				flag = true;
				result = new MtkDaxUploadResult(device, mtkDaxFlashInfo);
				return result;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				if (flag)
				{
					device?.Dispose();
				}
				ProjectData.ClearProjectError();
				return result;
			}
		}
		return null;
	}

	public static async Task<MtkDaxUploadResult> UploadAsync3(MtkSerialDevice device, MtkChipConfig chipConfig, byte[] emi, CancellationToken cancellationToken)
	{
		SerialCOM.MSL = "DISREAD";
		Form1.SharedUI.ProgressBar4.Text = "";
		Form1.SharedUI.ProgressBar4.Value = 0;
		gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		gui.Richlog("- Initialize Device : ", Color.Black);
		Form1.SharedUI.ProgressBar1.Text = "Initialize Device...";
		string path = Application.StartupPath + "\\mtk\\common\\da_2228";
		MtkDaEntry mtkDaEntry;
		byte[] da;
		byte[] da2;
		using (Stream stream = File.OpenRead(path))
		{
			stream.Seek(0L, SeekOrigin.Begin);
			MtkDaEntry[] source = await MtkDaService.GetEntriesAsync(stream);
			stream.Seek(0L, SeekOrigin.Begin);
			mtkDaEntry = source.Where([SpecialName] (MtkDaEntry x) => chipConfig.DaCode == x.HardwareCode).FirstOrDefault();
			da = await MtkDaService.GetStage1Async(stream, mtkDaEntry);
			stream.Seek(0L, SeekOrigin.Begin);
			da2 = await MtkDaService.GetStage2Async(stream, mtkDaEntry);
		}
		if ((object)mtkDaEntry != null)
		{
			MtkDaxUploadCalculationResult mtkDaxUploadCalculationResult = MtkDaxUploadCalculatorService.Calculate(da, da2, mtkDaEntry.Regions[2].StartAddress, mtkDaEntry.Regions[2].SignatureLength);
			await MtkDaWriteService.WriteAsync(device, mtkDaEntry.Regions[1].StartAddress, mtkDaEntry.Regions[1].SignatureLength, mtkDaxUploadCalculationResult.Da1, validateUploadStatus: true, cancellationToken);
			await MtkDaWriteService.JumpAsync(device, mtkDaEntry.Regions[1].StartAddress, cancellationToken);
			await MtkDaxUploadSyncService.SyncAsync(device, cancellationToken);
			await MtkDaxDeviceControlSetupService.GetExpireDateAsync(device, cancellationToken);
			await MtkDaxDeviceControlSetupService.SetResetKeyAsync(device, 104u, cancellationToken);
			await MtkDaxDeviceControlSetupService.SetChecksumLevelAsync(device, 0u, cancellationToken);
			string left = await MtkDaxDeviceControlSetupService.GetConnectionAgentAsync(device, cancellationToken);
			if (Operators.CompareString(left, "brom", TextCompare: false) == 0)
			{
				await MtkDaxUploadEmiService.UploadEmiAsync(device, emi, cancellationToken);
			}
			else
			{
				Operators.CompareString(left, "preloader", TextCompare: false);
			}
			await MtkDaxUploadBootService.BootToAsync(device, mtkDaEntry.Regions[2].StartAddress, mtkDaxUploadCalculationResult.Da2, cancellationToken);
			bool flag = false;
			MtkDaxUploadResult result = default(MtkDaxUploadResult);
			try
			{
				MtkDaxFlashInfo mtkDaxFlashInfo = await MtkDaxDeviceStorageInfoService.GetStorageInfoAsync(device, cancellationToken);
				if (Form1.SharedUI.CkAutoSwitchHighSpeedUSB.Checked)
				{
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Memory Type : ", Color.Black);
					gui.Richlog(Mediatek.Storage, Color.LightGreen, isBold: false, NextLine: true);
					gui.Richlog("- Switch To Usb High-Speed : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Switching...";
				}
				await MtkDaxUploadBootService.BootToAsync(device, 1744830464L, mtkDaxUploadCalculationResult.Extension, cancellationToken);
				await MtkDaxDeviceControlSetupService.SendCustomAckAsync(device, cancellationToken);
				PartitionPacketLength partitionPacketLength = await MtkDaxPartitionPacketLengthService.GetAsync(device, cancellationToken);
				MtkDaxFlashInfo mtkDaxFlashInfo2 = mtkDaxFlashInfo._get();
				mtkDaxFlashInfo2.WriteBufferSize = partitionPacketLength.WriteLen;
				mtkDaxFlashInfo2.ReadBufferSize = partitionPacketLength.ReadLen;
				mtkDaxFlashInfo = mtkDaxFlashInfo2;
				if (Form1.SharedUI.CkAutoSwitchHighSpeedUSB.Checked)
				{
					await MtkDaxUploadSetupService.SwitchUsbSpeedAsync(device, cancellationToken);
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Wait For Mtk Device : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Search..";
				}
				device.Dispose();
				Form1.SharedUI.ProgressBar1.Text = "Search...";
				await Task.Delay(TimeSpan.FromSeconds(7.0));
				device = (MtkSerialDevice)(IMtkSerialDevice)(await MtkDeviceWaiterService.WaitSerialAsync4(doHandshake: false, cancellationToken)).Device;
				flag = true;
				result = new MtkDaxUploadResult(device, mtkDaxFlashInfo);
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (flag)
				{
					device?.Dispose();
				}
				ProjectData.ClearProjectError();
				return result;
			}
		}
		return null;
	}

	public static async Task<MtkDaxUploadResult> UploadAsync4(MtkSerialDevice device, MtkChipConfig chipConfig, byte[] emi, CancellationToken cancellationToken)
	{
		SerialCOM.MSL = "DISREAD";
		Form1.SharedUI.ProgressBar4.Text = "";
		Form1.SharedUI.ProgressBar4.Value = 0;
		gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		gui.Richlog("- Load Download Agent : ", Color.Black);
		Form1.SharedUI.ProgressBar1.Text = "Loading...";
		string path = Application.StartupPath + "\\mtk\\common\\da_2228";
		MtkDaEntry mtkDaEntry;
		byte[] da;
		byte[] da2;
		using (Stream stream = File.OpenRead(path))
		{
			stream.Seek(0L, SeekOrigin.Begin);
			MtkDaEntry[] source = await MtkDaService.GetEntriesAsync(stream);
			stream.Seek(0L, SeekOrigin.Begin);
			mtkDaEntry = source.Where([SpecialName] (MtkDaEntry x) => chipConfig.DaCode == x.HardwareCode).FirstOrDefault();
			da = await MtkDaService.GetStage1Async(stream, mtkDaEntry);
			stream.Seek(0L, SeekOrigin.Begin);
			da2 = await MtkDaService.GetStage2Async(stream, mtkDaEntry);
		}
		if ((object)mtkDaEntry != null)
		{
			MtkDaxUploadCalculationResult mtkDaxUploadCalculationResult = MtkDaxUploadCalculatorService.Calculate(da, da2, mtkDaEntry.Regions[2].StartAddress, mtkDaEntry.Regions[2].SignatureLength);
			await MtkDaWriteService.WriteAsync(device, mtkDaEntry.Regions[1].StartAddress, mtkDaEntry.Regions[1].SignatureLength, mtkDaxUploadCalculationResult.Da1, validateUploadStatus: true, cancellationToken);
			gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			gui.Richlog("- Jump to booloader : ", Color.Black);
			Form1.SharedUI.ProgressBar1.Text = "Jumping...";
			await MtkDaWriteService.JumpAsync(device, mtkDaEntry.Regions[1].StartAddress, cancellationToken);
			gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			gui.Richlog("- Wait sync signa : ", Color.White);
			Form1.SharedUI.ProgressBar1.Text = "Waiting...";
			await MtkDaxUploadSyncService.SyncAsync(device, cancellationToken);
			gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			gui.Richlog("- Send SYNC signal : ", Color.Black);
			Form1.SharedUI.ProgressBar1.Text = "Sending...";
			await MtkDaxDeviceControlSetupService.GetExpireDateAsync(device, cancellationToken);
			gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			gui.Richlog("- Setup device environment : ", Color.White);
			Form1.SharedUI.ProgressBar1.Text = "Setup...";
			await MtkDaxDeviceControlSetupService.SetResetKeyAsync(device, 104u, cancellationToken);
			gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			gui.Richlog("- Initiate hardware components : ", Color.White);
			Form1.SharedUI.ProgressBar1.Text = "Initiate...";
			await MtkDaxDeviceControlSetupService.SetChecksumLevelAsync(device, 0u, cancellationToken);
			gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			gui.Richlog("- Read device connection agent : ", Color.White);
			Form1.SharedUI.ProgressBar1.Text = "Reading...";
			string text = await MtkDaxDeviceControlSetupService.GetConnectionAgentAsync(device, cancellationToken);
			gui.Richlog(text.ToUpper(), Color.Green, isBold: false, NextLine: true);
			gui.Richlog("- Identify storage type : ", Color.White);
			Form1.SharedUI.ProgressBar1.Text = "Identify...";
			if (Operators.CompareString(text, "brom", TextCompare: false) == 0)
			{
				await MtkDaxUploadEmiService.UploadEmiAsync(device, emi, cancellationToken);
			}
			else
			{
				Operators.CompareString(text, "preloader", TextCompare: false);
			}
			gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			gui.Richlog("- Load emi config from database : ", Color.White);
			Form1.SharedUI.ProgressBar1.Text = "Loading...";
			await MtkDaxUploadBootService.BootToAsync(device, mtkDaEntry.Regions[2].StartAddress, mtkDaxUploadCalculationResult.Da2, cancellationToken);
			bool flag = false;
			try
			{
				MtkDaxFlashInfo mtkDaxFlashInfo = await MtkDaxDeviceStorageInfoService.GetStorageInfoAsync2(device, cancellationToken);
				if (Form1.SharedUI.CkAutoSwitchHighSpeedUSB.Checked)
				{
					gui.Richlog("- Switch To Usb High-Speed : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Switching..";
				}
				else
				{
					gui.Richlog("- Analyze Device Data : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Analyzeing..";
				}
				await MtkDaxUploadBootService.BootToAsync(device, 1744830464L, mtkDaxUploadCalculationResult.Extension, cancellationToken);
				await MtkDaxDeviceControlSetupService.SendCustomAckAsync(device, cancellationToken);
				PartitionPacketLength partitionPacketLength = await MtkDaxPartitionPacketLengthService.GetAsync(device, cancellationToken);
				MtkDaxFlashInfo mtkDaxFlashInfo2 = mtkDaxFlashInfo._get();
				mtkDaxFlashInfo2.WriteBufferSize = partitionPacketLength.WriteLen;
				mtkDaxFlashInfo2.ReadBufferSize = partitionPacketLength.ReadLen;
				mtkDaxFlashInfo = mtkDaxFlashInfo2;
				if (Form1.SharedUI.CkAutoSwitchHighSpeedUSB.Checked)
				{
					await MtkDaxUploadSetupService.SwitchUsbSpeedAsync(device, cancellationToken);
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Wait For Mtk Device : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Search..";
				}
				device.Dispose();
				await Task.Delay(TimeSpan.FromSeconds(5.0));
				device = (MtkSerialDevice)(IMtkSerialDevice)(await MtkDeviceWaiterService.WaitSerialAsync(doHandshake: false, cancellationToken)).Device;
				flag = true;
				Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Invoke((Action)([SpecialName] () =>
				{
					Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Checked = true;
				}));
				return new MtkDaxUploadResult(device, mtkDaxFlashInfo);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (flag)
				{
					device?.Dispose();
				}
				ProjectData.ClearProjectError();
			}
		}
		return null;
	}
}
