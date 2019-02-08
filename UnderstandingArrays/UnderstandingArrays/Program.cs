using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int number1 = 54;
            int number2 = 14;
            int number3 = 24;
            int number4 = 34;
            int number5 = 4;
            int number6 = 5;
            */
            /*int[] numbers = new int[6];
            numbers[0] = 54;
            numbers[1] = 54;
            numbers[2] = 54;
            numbers[3] = 54;
            numbers[4] = 34;
            numbers[5] = 24;
            Console.WriteLine(numbers.Length);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            */
            //int[] numbers = new int[6] { 4, 5, 6, 4, 5, 3 };
            /*string[] names = new string[] { "Armen", "Martin", "Vahe", "Viktor" };
            // for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
            foreach (var name in names )
            {
                Console.WriteLine(name);
            }
            */
            string Joker = "Let’s put a smile on that face!" + "I believe, whatever doesn't kill you, simply makes you...stranger.";
            char[] charArray = Joker.ToCharArray();
            Array.Reverse(charArray);
            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
        }

    }
}
