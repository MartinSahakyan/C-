using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Armenia();
            HelloWorld();
        }

        private static void Armenia()
        {
            string drosh = "Կարմիր Կապույտ Ծիրանագույն";
            string orhnerg = "Մեր Հայրենիք";
            string zinanshan = "Առյուծ և Արծիվ";
            Console.WriteLine("{0} {1} {2}", drosh, orhnerg, zinanshan);
        }
        private static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }
    }
}
