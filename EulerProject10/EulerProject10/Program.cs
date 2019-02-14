using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject10
{
    class Program
    {
        static void Main(string[] args)
        {
            long Number = 2000000;
            long Sum = 0;
            for (long i = 0; i < Number; i++)
            {
                bool prime = PrimeTool.IsPrime(i);
                if (prime)
                {
                    Sum = Sum + i;
                }

            }
            Console.WriteLine("Sum is = {0}", Sum);
        }
    }
}