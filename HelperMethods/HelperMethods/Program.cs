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
            ReverseString(FirstName);
            ReverseString(LastName);
            ReverseString(Country);
        }
        static private void ReverseString(string Sentence)
        {
            char[] sentence = Sentence.ToCharArray();
            Array.Reverse(sentence);
            string result = "";
            foreach (var item in sentence)
            {
                result += item;
            }
            result += " ";
            Console.Write(result);
        }

    }
}
