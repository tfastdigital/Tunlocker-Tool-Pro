using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Properties;

namespace motoulocked.My;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class MyApplication : WindowsFormsApplicationBase
{
	[CompilerGenerated]
	[AccessedThroughProperty("domain")]
	private AppDomain _domain;

	private  AppDomain domain
	{
		[CompilerGenerated]
		get
		{
			return _domain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			ResolveEventHandler value2 = domainchekc;
			AppDomain appDomain = _domain;
			if (appDomain != null)
			{
				appDomain.AssemblyResolve -= value2;
			}
			_domain = value;
			appDomain = _domain;
			if (appDomain != null)
			{
				appDomain.AssemblyResolve += value2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	[STAThread]
	[DebuggerHidden]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static void Main(string[] Args)
	{
		Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
		MyProject.Application.Run(Args);
	}

	private Assembly domainchekc(object sender, ResolveEventArgs e)
	{
		if (e.Name.Contains("Guna.UI2"))
		{
			return Assembly.Load(global::Properties.Resources.Guna2);
		}
		if (e.Name.Contains("Newtonsoft.Json"))
		{
			return Assembly.Load(global::Properties.Resources.Newtonsoft_Json);
		}
		Assembly result = default(Assembly);
		return result;
	}

	[DebuggerStepThrough]
	public MyApplication()
		: base(AuthenticationMode.Windows)
	{
		domain = AppDomain.CurrentDomain;
		base.IsSingleInstance = true;
		base.EnableVisualStyles = true;
		base.SaveMySettingsOnExit = false;
		base.ShutdownStyle = ShutdownMode.AfterAllFormsClose;
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		base.MainForm = MyProject.Forms.Form1;
	}
}
