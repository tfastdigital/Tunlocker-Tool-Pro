using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.My;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class MyForms
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dialog1 m_Dialog1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dialog2 m_Dialog2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dialog3 m_Dialog3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dialog4 m_Dialog4;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dialog5 m_Dialog5;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public EDL m_EDL;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public flash m_flash;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Form1 m_Form1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Get_Messgas m_Get_Messgas;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public kirin m_kirin;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public LoadXML m_LoadXML;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public log_Updeta m_log_Updeta;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public No_Internet m_No_Internet;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Protocol_MTK_By_Devronix m_Protocol_MTK_By_Devronix;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Select_Prtitoin m_Select_Prtitoin;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Services_Network m_Services_Network;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public SPDR m_SPDR;

		public Dialog1 Dialog1
		{
			get
			{
				m_Dialog1 = Create__Instance__(m_Dialog1);
				return m_Dialog1;
			}
			set
			{
				if (value != m_Dialog1)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Dialog1);
				}
			}
		}

		public Dialog2 Dialog2
		{
			get
			{
				m_Dialog2 = Create__Instance__(m_Dialog2);
				return m_Dialog2;
			}
			set
			{
				if (value != m_Dialog2)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Dialog2);
				}
			}
		}

		public Dialog3 Dialog3
		{
			get
			{
				m_Dialog3 = Create__Instance__(m_Dialog3);
				return m_Dialog3;
			}
			set
			{
				if (value != m_Dialog3)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Dialog3);
				}
			}
		}

		public Dialog4 Dialog4
		{
			get
			{
				m_Dialog4 = Create__Instance__(m_Dialog4);
				return m_Dialog4;
			}
			set
			{
				if (value != m_Dialog4)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Dialog4);
				}
			}
		}

		public Dialog5 Dialog5
		{
			get
			{
				m_Dialog5 = Create__Instance__(m_Dialog5);
				return m_Dialog5;
			}
			set
			{
				if (value != m_Dialog5)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Dialog5);
				}
			}
		}

		public EDL EDL
		{
			get
			{
				m_EDL = Create__Instance__(m_EDL);
				return m_EDL;
			}
			set
			{
				if (value != m_EDL)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_EDL);
				}
			}
		}

		public flash flash
		{
			get
			{
				m_flash = Create__Instance__(m_flash);
				return m_flash;
			}
			set
			{
				if (value != m_flash)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_flash);
				}
			}
		}

		public Form1 Form1
		{
			get
			{
				m_Form1 = Create__Instance__(m_Form1);
				return m_Form1;
			}
			set
			{
				if (value != m_Form1)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form1);
				}
			}
		}

		public Get_Messgas Get_Messgas
		{
			get
			{
				m_Get_Messgas = Create__Instance__(m_Get_Messgas);
				return m_Get_Messgas;
			}
			set
			{
				if (value != m_Get_Messgas)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Get_Messgas);
				}
			}
		}

		public kirin kirin
		{
			get
			{
				m_kirin = Create__Instance__(m_kirin);
				return m_kirin;
			}
			set
			{
				if (value != m_kirin)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_kirin);
				}
			}
		}

		public LoadXML LoadXML
		{
			get
			{
				m_LoadXML = Create__Instance__(m_LoadXML);
				return m_LoadXML;
			}
			set
			{
				if (value != m_LoadXML)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_LoadXML);
				}
			}
		}

		public log_Updeta log_Updeta
		{
			get
			{
				m_log_Updeta = Create__Instance__(m_log_Updeta);
				return m_log_Updeta;
			}
			set
			{
				if (value != m_log_Updeta)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_log_Updeta);
				}
			}
		}

		public No_Internet No_Internet
		{
			get
			{
				m_No_Internet = Create__Instance__(m_No_Internet);
				return m_No_Internet;
			}
			set
			{
				if (value != m_No_Internet)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_No_Internet);
				}
			}
		}

		public Protocol_MTK_By_Devronix Protocol_MTK_By_Devronix
		{
			get
			{
				m_Protocol_MTK_By_Devronix = Create__Instance__(m_Protocol_MTK_By_Devronix);
				return m_Protocol_MTK_By_Devronix;
			}
			set
			{
				if (value != m_Protocol_MTK_By_Devronix)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Protocol_MTK_By_Devronix);
				}
			}
		}

		public Select_Prtitoin Select_Prtitoin
		{
			get
			{
				m_Select_Prtitoin = Create__Instance__(m_Select_Prtitoin);
				return m_Select_Prtitoin;
			}
			set
			{
				if (value != m_Select_Prtitoin)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Select_Prtitoin);
				}
			}
		}

		public Services_Network Services_Network
		{
			get
			{
				m_Services_Network = Create__Instance__(m_Services_Network);
				return m_Services_Network;
			}
			set
			{
				if (value != m_Services_Network)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Services_Network);
				}
			}
		}

		public SPDR SPDR
		{
			get
			{
				m_SPDR = Create__Instance__(m_SPDR);
				return m_SPDR;
			}
			set
			{
				if (value != m_SPDR)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_SPDR);
				}
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Form, new()
		{
			if (Instance == null || Instance.IsDisposed)
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(T), null);
				try
				{
					return new T();
				}
				catch (TargetInvocationException ex) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					ProjectData.SetProjectError(ex);
					return ex.InnerException != null;
				}).Invoke())
				{
					throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message), ex.InnerException);
				}
				finally
				{
					m_FormBeingCreated.Remove(typeof(T));
				}
			}
			return Instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance) where T : Form
		{
			instance.Dispose();
			instance = null;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyForms()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return typeof(MyForms);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class MyWebServices
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			return typeof(MyWebServices);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance)
		{
			instance = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyWebServices()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T m_ThreadStaticValue;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new T();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ThreadSafeObjectProvider()
		{
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

	private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

	private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

	[HelpKeyword("My.Computer")]
	internal static MyComputer Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication Application
	{
		[DebuggerHidden]
		get
		{
			return m_AppObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static MyForms Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static MyWebServices WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
