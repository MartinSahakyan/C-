using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Please enter your number = ");
            number = Int32.Parse(Console.ReadLine());

            SquareOfSum(number);
            SumOfSquares(number);
            int Result = SquareOfSum(number) - SumOfSquares(number);
            Console.WriteLine("Your SquareOfSum - SumOfSquares = {0} ",Result);
        }
        public static int SumOfSquares(int n)
        {
            int Sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Sum = Sum + i * i;
            }
            return Sum;
        }
        public static int SquareOfSum( int n)
        {
            int Sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Sum = Sum + i;
            }
            int product = Sum * Sum;
            return product;
        }
    }
}
