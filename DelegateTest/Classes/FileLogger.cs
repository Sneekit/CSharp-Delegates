using System.IO;

namespace DelegateTest.Classes
{
	class FileLogger
	{
		private static StreamWriter _sw;

		public FileLogger(string fname)
		{
			// create new stream writer
			_sw = new StreamWriter(fname, true);
		}

		public void Logger(string str)
		{
			_sw.WriteLine(str);
		}

		public void Close()
		{
			_sw.Close();
		}
	}
}