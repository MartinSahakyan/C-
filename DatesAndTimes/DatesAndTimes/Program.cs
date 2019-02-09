using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToOADate());
            //Console.WriteLine(myValue.ToLongTimeString());
            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            DateTime MyBirthday = new DateTime(1999, 03, 24);
            //Console.WriteLine(MyBirthday.ToLongDateString()); 
            TimeSpan myAge = DateTime.Now.Subtract(MyBirthday);
            Console.WriteLine(myAge.TotalDays);
        }
    }
}
