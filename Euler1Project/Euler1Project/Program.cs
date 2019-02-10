using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler1Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int SumOfAllTheMultiples = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    SumOfAllTheMultiples = SumOfAllTheMultiples + i;
                }
            }
            Console.WriteLine("Sum = {0}",SumOfAllTheMultiples);
        }
    }
}
