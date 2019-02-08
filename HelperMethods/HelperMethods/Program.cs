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
            DisplayResult(ReverseString(FirstName), ReverseString(LastName), ReverseString(Country));

        }
        private static void DisplayResult(string reversedFirstName, string reversedLastName, string reversedCountry)
        {
            
            Console.Write(String.Format("{0} {1} {2}", reversedFirstName, reversedLastName,reversedCountry));
        }
        private static string ReverseString(string Sentence)
        {
            char[] sentence = Sentence.ToCharArray();
            Array.Reverse(sentence);
            return String.Concat(sentence);
            
        }

    }
}
