using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
                if (i == 4)
                {
                    Console.WriteLine("Hey 4");
                    break;
                }
            }
        }
    }
}
