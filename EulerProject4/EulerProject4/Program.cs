using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 999; i++)
            {
                for (int j = 100; j < 999; j++)
                {
                    int thepolindromenumber = i * j;
                    if (PolindromeFunction(thepolindromenumber))
                    {
                        Console.WriteLine("The numbers are {0} and {1}, The product is = {2} ", i, j, thepolindromenumber);
                        
                    }
                }
            }

        }
        static bool PolindromeFunction(int number)
        {
            bool IsPolindrome = false;
            int reversedInteger = 0, remainder, originalInteger;
            originalInteger = number;
            while (number != 0)
            {
                remainder = number % 10;
                reversedInteger = reversedInteger * 10 + remainder;
                number /= 10;
            }
            if (originalInteger == reversedInteger)
            {
                IsPolindrome = true;
            }
            else
            {
                IsPolindrome = false;
            }
            return IsPolindrome;
        }
    }
}
