using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 1, second = 1, delta, Sum = 0;
            while (first <= 4000000 )
            {
                if (first%2==0)
                {
                    Sum += first;
                }
                delta = first;
                first = second + first;
                second = delta;
            }
            Console.WriteLine("Sum is = {0}", Sum);
        }
    }
}
