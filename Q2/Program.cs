using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int start = 3;
			int end = 100;
			double sqrt = 0;
			double sqrt1 = 0;
			for (int k = start; k <= end; k++)
			{
				 sqrt = Math.Sqrt(k);
				sqrt1 = Math.Floor(sqrt);
				for (int i = 2; i <= sqrt; i++)
				{
					
					if (k % i == 0)
					{
						break;
					}
					else if(i==sqrt1)
					{
						Console.WriteLine(k);
					}
					
				}
				
			}
		}
	}
}
