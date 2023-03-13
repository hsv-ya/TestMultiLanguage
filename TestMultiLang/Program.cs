/*
 * Created by SharpDevelop.
 * User: OpenCNC
 * Date: 22.02.2023
 * Time: 11:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace TestMultiLang {

internal sealed class Program {
	[STAThread]
	private static void Main(string[] args) {
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run(new frmMainForm());
	}
}

}
