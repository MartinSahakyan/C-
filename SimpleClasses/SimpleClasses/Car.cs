using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public decimal DetermineMarketValue()
        {
            decimal CarValue;
            if (Year > 1990)
                CarValue = 10000;
            else
                CarValue = 100;
            return CarValue;
        }    
    }
}
