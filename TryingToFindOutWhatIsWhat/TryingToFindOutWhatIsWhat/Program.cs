using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryingToFindOutWhatIsWhat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello Guys";
            Console.WriteLine(message);
            Console.WriteLine("Hello World");
            
            const int a = 10;
            
        }

       
    }
    public  class MyClass
    {

        public string Myfield = string.Empty;
        public MyClass()
        {
        }
        public void MyMethod(int parameter1, int parameter2)
        {
            Console.WriteLine("FirstParameter{1},SecondParameter{2}", parameter1, parameter2);
        }
        public int MyAutoMakingProperty { get; set;}
        private int MyPropertyVar;
        public int MyProperty
        {
            get
            {
                return MyPropertyVar;
            }
            set { MyPropertyVar = value; }
        }
    }
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

}
