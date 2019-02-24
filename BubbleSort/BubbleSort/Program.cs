using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("myArrayitem [{0}] = ", i);
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            int length = myArray.Length;
            while (length != 0)
            {

                for (int i = 0; i < myArray.Length - 1; i++)
                {

                    if (myArray[i] > myArray[i + 1])
                    {
                        int a = myArray[i + 1];
                        myArray[i + 1] = myArray[i];
                        myArray[i] = a;

                    }


                }
                length = length - 1;
            }
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}

