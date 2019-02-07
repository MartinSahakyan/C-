using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Martin's Big Giveaway");
            Console.WriteLine("Choose a door : 1,2,3");
            string userValue = Console.ReadLine();
            if (userValue == "1")
            {
                Console.WriteLine("You won a new car");
            }
            else if (userValue == "2")
            {
                Console.WriteLine("You won a new house");
            }
            else if(userValue=="3")
            {
                Console.WriteLine("You are a looser");
            }
            else
            {
                Console.WriteLine("We don't understand");                 
            }
        }
    }
}
