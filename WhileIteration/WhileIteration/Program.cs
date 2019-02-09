using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu==true)
            {
                displayMenu = MainMenu();
            }
            
            
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option");
            Console.WriteLine("1) PrintNumbers");
            Console.WriteLine("2) Guessing Game");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingName();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Try again");
                return true;
            }
        }
        private static void PrintNumbers()
        {
            Console.WriteLine("Print numbers");
            Console.Write("Type a number - ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result + 1 )
            {
                Console.Write(counter);
                if (counter != result)
                {
                    Console.Write("-");
                }
                
                counter++;
            }
            Console.ReadLine();
        }
        private static void GuessingName()
        {
            Console.WriteLine("Guessing game!");
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);
            int guesses = 0;
            bool incorrect = true;
            do
            {
                guesses++;
                Console.WriteLine("Guess a number between 1 to 11");
                string result = Console.ReadLine();
                if (result==randomNumber.ToString())
                   incorrect = false;
                else
                   Console.WriteLine("Wrong");
               
            } while (incorrect);
            Console.WriteLine("It took You{0} guesses", guesses);
            Console.ReadLine();
        }
    }
}
