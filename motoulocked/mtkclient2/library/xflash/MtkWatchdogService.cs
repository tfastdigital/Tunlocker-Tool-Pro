using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using motoulocked.mtkclient2.Tasks;

namespace motoulocked.mtkclient2.library.xflash;

internal class MtkWatchdogService
{
	public static async Task DisableAsync(IMtkDevice device, MtkChipConfig chipConfig, CancellationToken cancellationToken)
	{
		if (chipConfig.WdgAddress.HasValue)
		{
			uint value = MtkWatchdogValueCalculatorService.CalculateDisable(chipConfig.WdgAddress.Value, chipConfig.HardwareCode);
			gui.Richlog("- Disable Security Brom : ", Color.Black);
			Form1.SharedUI.ProgressBar1.Text = "Disable Sec...";
			await MtkReadWrite32Service.WriteAsync(device, chipConfig.WdgAddress.Value, value, bigEndian: true, cancellationToken);
			if ((ulong)chipConfig.HardwareCode == 26002)
			{
				await MtkReadWrite32Service.WriteAsync(device, 268436736u, 570425344u, bigEndian: true, cancellationToken);
			}
			else if ((ulong)chipConfig.HardwareCode == 25973 || (ulong)chipConfig.HardwareCode == 25975)
			{
				await MtkReadWrite32Service.WriteAsync(device, 8704u, 3221225472u, bigEndian: true, cancellationToken);
			}
		}
		else
		{
			MtkTask.CHECK = "no";
		}
	}
}
