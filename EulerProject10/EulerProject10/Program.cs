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
            int Number = 2000000;
            int Sum = 0;
            for (int i = 0; i < Number; i++)
            {
                
                if (IsPrime(i))
                {
                    Sum = Sum + i;
                }

            }
            Console.WriteLine("Sum is = {0}", Sum);
            
        }
        public static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number % 2 == 0) return (number == 2);
            int root = (int)Math.Sqrt((double)number);
            for (int i = 3; i <= root; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}