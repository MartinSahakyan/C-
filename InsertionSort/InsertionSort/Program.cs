using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
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
            InsertionSort(myArray);

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
        }
        static void InsertionSort(int[] Array)
        {
            int holePosition;
            int valueToInsert;
            for (int i = 0; i < Array.Length; i++)
            {
                valueToInsert = Array[i];
                holePosition = i;

                while (holePosition > 0 && Array[holePosition - 1] > valueToInsert)
                {
                    Array[holePosition] = Array[holePosition - 1];
                    holePosition = holePosition - 1;
                }
                Array[holePosition] = valueToInsert;
            }
        }
    }
}
