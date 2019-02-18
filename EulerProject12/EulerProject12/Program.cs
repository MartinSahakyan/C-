using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject12
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int Sum = TriangleNumber(4000);
                TheFactors(Sum);
                if (TheFactors(Sum))
                {
                    Console.WriteLine(Sum);
                    
                }
            
        }
        static int TriangleNumber(int number)
        {
            int theNumber = 0;
            for (int j = 0; j <= number; j++)
            {
                theNumber = theNumber + j;
            }
            return theNumber;

        }
        static bool TheFactors(int number)
        {
            bool theNumber = false;
            int j = 0;
            for (int i = 1; i <= number/2; i++)
            {
                if (number % i == 0)
                {
                    j++;
                }
            }
            /*
            if (j == 500)
            {
                theNumber = true;
            }
            */
            Console.WriteLine(j);
            theNumber = true;
            return theNumber;
        }
    }
}
