using System;
using DelegateTest.Classes;
using System.Windows.Forms;

namespace DelegateTest
{
	public partial class DeletgateForm : Form
	{
		public DeletgateForm()
		{
			InitializeComponent();
		}

		static void Logger(string str)
		{
			MessageBox.Show(str);
		}

		private void btnLog_Click(object sender, EventArgs e)
		{
			FileLogger fl = new FileLogger("delegatetest.log");
			LogDelegate ld = new LogDelegate();
			ld.Log += new LogDelegate.LogHandler(Logger);
			ld.Log += new LogDelegate.LogHandler(fl.Logger);
			ld.Process(txtLog.Text);
			fl.Close();
		}
	}
}
