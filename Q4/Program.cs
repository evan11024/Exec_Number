using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int cock = 0; cock <= 15; cock++)
				for (int hen = 0; hen <= 25; hen++)
					for (int chicken3 = 0; chicken3 <= 100; chicken3++)
						if (cock + hen + 3 * chicken3 == 100 && 5 * cock + 3 * hen + chicken3 == 100)
						{
							Console.WriteLine($"公雞{cock}隻 母雞{hen}隻 小雞{chicken3*3}隻");
						}
		}
	}
}
