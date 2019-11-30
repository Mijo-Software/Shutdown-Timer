using System;
using System.Windows.Forms;

namespace ShutdownTimer
{
	internal static class Program
	{
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(true);
			Application.Run(new ShutdownTimerForm());
		}
	}
}
