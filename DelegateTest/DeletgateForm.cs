using System;
using System.IO;
using DelegateTest.Classes;
using System.Windows.Forms;

namespace DelegateTest
{
	public partial class DeletgateForm : Form
	{
		private static FileLogger _fl;
		private static LogDelegate _ld;
		private static Test _test;


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
			InvokeDelegate(txtLog.Text, "delegatetest.log");
		}

		private void btnRandom_Click(object sender, EventArgs e)
		{
			Test _test = new Test(1000);
			InvokeDelegate(_test._randstr, "randomtest.log");
		}

		private void InvokeDelegate(string str, string fname)
		{
			_fl = new FileLogger(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), fname));
			_ld = new LogDelegate();
			_ld.Log += new LogDelegate.LogHandler(Logger);
			_ld.Log += new LogDelegate.LogHandler(_fl.Logger);
			_ld.Process(str);
			_fl.Close();
		}
	}
}
