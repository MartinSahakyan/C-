using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
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

            SelectionSort(myArray);

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }

        }
        static void SelectionSort(int[] Array)
        {
            int minimum;
            for (int i = 0; i < Array.Length - 1; i++)
            {
                int index = i;
                for (int j = i + 1; j < Array.Length ; j++)
                {
                    if (Array[j] > Array[index])
                    {
                        index = j ;
                    }
                }
                if (index != i)
                {
                    minimum = Array[i];
                    Array[i] = Array[index];
                    Array[index] = minimum;
                }
                    
                
            }
            
            
        }
    }
}
