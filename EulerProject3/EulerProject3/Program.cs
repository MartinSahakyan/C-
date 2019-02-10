using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject3
{
    class Program
    {
        static void Main()
        {
            long Number = 600851475143;
            for (long i = 0; i < 600851475143 / 2; i++)
            {
                bool prime = PrimeTool.IsPrime(i);
                if (prime)
                {
                    if (Number % i == 0)
                    {
                        Console.WriteLine("prime factor {0}",i);
                        Number = Number / i;
                    }
                }
            }
        }
    }
}
