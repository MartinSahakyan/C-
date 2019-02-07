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
            /*void Method()
             {
                 int i = 300000000, j = 10;
                 i++;
                 ++j;
                 Console.WriteLine(i);
                 j++;
                 Console.WriteLine(j);
             }
             Method(); */
            Console.WriteLine("What is your name ");
            Console.Write("What is your firstname");
            string MyFirstName;
            MyFirstName = Console.ReadLine();
            Console.WriteLine("hello" + MyFirstName);
        }
    }
}
