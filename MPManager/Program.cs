using System;
using System.Windows.Forms;

namespace SessionManagement
{
	// Token: 0x0200001B RID: 27
	internal static class Program
	{
		// Token: 0x06000167 RID: 359 RVA: 0x00013514 File Offset: 0x00011714
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmMain());
		}
	}
}
