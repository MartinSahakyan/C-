using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        private static object result;

        static void Main(string[] args)
        {
            //string MyString = "My\"sis\"sad";
            //string MyString = "What if I need a \n new line";
            //string MyString = "Go to your c:\\ drive";
            //string MyString = @"Go to your c:\ drive";
            //string MyString = String.Format("{0} = {1}", "First", "Second");
            //string MyString = string.Format("{0:C2}", 123.45);
            //string MyString = string.Format("{0:N}", 123456789);
            //string MyString = string.Format("{0:(###)  ##-##-##-##}", 37499629468);
            //string MyString = " Does that make me Crazy  ";
            //MyString = MyString.Substring(6,14);
            //MyString = MyString.ToUpper();
            //MyString = MyString.Trim();
            StringBuilder MyString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                MyString.Append("--");
                MyString.Append(i);
            }
            Console.WriteLine(MyString);
            Console.ReadLine();
        }
    }
}
