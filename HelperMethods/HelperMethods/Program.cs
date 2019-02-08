using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");
            Console.WriteLine("What is Your FirstName");
            string FirstName=Console.ReadLine();
            Console.WriteLine("What is Your LastName");
            string LastName = Console.ReadLine();
            Console.WriteLine("Where were you born");
            string Country = Console.ReadLine();
            char[] firstNameArray = FirstName.ToCharArray();
            Array.Reverse(firstNameArray);
            char[] lastNameArray = LastName.ToCharArray();
            Array.Reverse(lastNameArray);
            char[] YourCountry = Country.ToCharArray();
            Array.Reverse(YourCountry);
            string result = "";
            foreach (var item in firstNameArray)
            {
                result += item;
            }
            result += " ";
            foreach (var item in lastNameArray)
            {
                result += item;
            }
            result += " ";
            foreach (var item in YourCountry)
            {
                result += item;
            }
            result += " ";
            Console.WriteLine(result);
        }

    }
}
