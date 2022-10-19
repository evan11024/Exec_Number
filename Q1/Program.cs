using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入數值:");
			string input = Console.ReadLine();

			double number = Convert.ToDouble(input);
			double sqrt = Math.Sqrt(number);
			for (int i = 2; i <= sqrt; i++)
			{
				if (number % i == 0)
				{
					Console.WriteLine("不是質數");
					return;
				}
			}
			Console.WriteLine("是質數");
		}
	}
}
