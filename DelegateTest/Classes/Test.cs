using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest.Classes
{
	class Test
	{
		private List<int> _intlist = new List<int>();
		public string _randstr;
		private static Random _random = new Random();

		//creates a random string of length size
		public Test(int size)
		{
			for (int i=0; i < size; i++)
			{
				int val = _random.Next(32,127);
				_intlist.Add(val);
			}

			foreach (int val in _intlist)
			{
				Char c = Convert.ToChar(val);
				_randstr += Convert.ToChar(val).ToString();
			}
		}
	}
}
