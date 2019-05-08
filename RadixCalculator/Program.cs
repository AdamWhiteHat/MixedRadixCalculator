/*
 *
 * Developed by Adam White 
 *  http://csharpcodewhisperer.blogspot.com
 * 
 */
using System;
using System.Windows.Forms;

namespace RadixCalculator
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}

	}
}
