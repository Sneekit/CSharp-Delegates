using System;
using System.IO;
using System.Text;
using DelegateTest.Classes;
using System.Windows.Forms;

namespace DelegateTest
{
	public partial class DeletgateForm : Form
	{
		private static FileLogger _fl;
		private static LogDelegate _ld;
		private static RandomText _test;


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
			_test = new RandomText(1000);
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

		private async void btnWrite_Click(object sender, EventArgs e)
		{
			string fname = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "randomfile.log");
			_test = new RandomText(10000);
			StreamWriter sw = new StreamWriter(fname);
			for (int i=0; i<100; i++)
			{
				_test.GetRandomString();
				await sw.WriteLineAsync(_test._randstr);
			}
			sw.Close();
		}

		private async void btnRead_Click(object sender, EventArgs e)
		{
			string fname = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "randomfile.log");
			StringBuilder sb = new StringBuilder();
			string line;
			StreamReader sr = new StreamReader(fname);
			while ((line = await sr.ReadLineAsync()) != null)
				sb.Append(line);
			txtLog.AppendText(sb.ToString());
			sr.Close();
		}
	}
}
