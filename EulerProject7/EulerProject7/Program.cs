using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject7
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            for (int i = 0; i < 1000000; i++)
            {
                if (PrimeTool.IsPrime(i))
                {
                    index++;
                }
                if (index == 10001)
                {
                    Console.WriteLine("The 10001st prime number is {0}",i);
                    break;
                }
            }
        }
    }
}
