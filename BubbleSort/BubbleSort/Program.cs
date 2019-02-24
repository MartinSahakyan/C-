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

            BubbleSort(myArray);

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
        }

        static void BubbleSort(int[] Array)
        {
            int length = Array.Length;
            while (length != 0)
            {

                for (int i = 0; i < Array.Length - 1; i++)
                {

                    if (Array[i] > Array[i + 1])
                    {
                        int a = Array[i + 1];
                        Array[i + 1] = Array[i];
                        Array[i] = a;

                    }


                }
                length = length - 1;
            }
        }
    }
}

