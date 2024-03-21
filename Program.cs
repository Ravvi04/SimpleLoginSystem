using System;
using System.Windows.Forms;

namespace SimpleLoginSystem
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x06000007 RID: 7 RVA: 0x000025DA File Offset: 0x000007DA
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
