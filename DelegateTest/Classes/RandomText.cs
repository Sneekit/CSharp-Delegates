using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest.Classes
{
	class RandomText
	{
		private static List<int> _intlist;
		private static int _size;
		public string _randstr;
		private static Random _random = new Random();

		//creates a random string of length size
		public RandomText(int size)
		{
			_size = size;
			GetRandomString();
		}

		public void GetRandomString()
		{
			Random random = new Random();
			_intlist = new List<int>();
			_randstr = string.Empty;

			for (int i=0; i<_size; i++)
			{
				int val = _random.Next(32, 127);
				_intlist.Add(val);
			}

			foreach (int val in _intlist)
			{
				_randstr += Convert.ToChar(val).ToString();
			}
		}
	}
}
