using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string number = string.Empty;
			for (double i = 1000; i < 10000; i++)
			{
				double k = Math.Sqrt(i);
				number = i.ToString();
				if (number.Substring(0, 1) == number.Substring(1, 1) && number.Substring(2, 1) == number.Substring(3, 1)&&k%1==0)
				{
					Console.WriteLine(i);
				}

			}
		}
	}
}
