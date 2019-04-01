namespace DelegateTest
{
	public class LogDelegate

	{
		public delegate void LogHandler(string str);

		public event LogHandler Log;

		public void Process(string str)
		{
			OnLog("[Log Started]");
			OnLog(str);
			OnLog("[Log Ended]");
		}

		protected void OnLog(string str)
		{
			Log?.Invoke(str);
		}
	}
}
