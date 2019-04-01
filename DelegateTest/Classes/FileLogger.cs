using System.IO;

namespace DelegateTest.Classes
{
	class FileLogger
	{
		private static StreamWriter _sw;

		public FileLogger(string fname)
		{
			// create new stream writer, true is for append
			_sw = new StreamWriter(fname, true);
		}

		// Logger method that is added to the delegate event
		public void Logger(string str)
		{
			_sw.WriteLine(str);
		}


		// clean up
		public void Close()
		{
			_sw.Close();
		}
	}
}