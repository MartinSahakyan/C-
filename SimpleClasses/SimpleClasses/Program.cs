using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Ferrari = new Car();
            Ferrari.Color = "Red";
            Ferrari.Model = "Monza Spi";
            Ferrari.Year = 1999;
            Console.WriteLine("{0},{1},{2}", Ferrari.Year, Ferrari.Model, Ferrari.Color);
            decimal value = DetermineMarketValue(Ferrari);
            Console.WriteLine("{0:C}", value);
            Console.WriteLine("{0:C}", Ferrari.DetermineMarketValue());
            Console.ReadLine();
            
        }
        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 100.0M;
            return carValue;

        }
    }
}
