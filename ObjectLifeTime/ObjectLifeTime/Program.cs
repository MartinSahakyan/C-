using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Car myCar = new Car();
            /*
            myCar.Make = "Mercedez";
            myCar.Model = "E 200";
            myCar.Year = 2018;
            myCar.Color = "red";
            */
            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make, 
                myCar.Model, 
                myCar.Year, 
                myCar.Color);
            Car myotherCar;
            myotherCar = myCar;
            myotherCar.Color = "Metalic";
            Console.WriteLine("{0} {1} {2} {3}",
                myotherCar.Make,
                myotherCar.Model,
                myotherCar.Year,
                myotherCar.Color);
            /*
            myCar = null;
            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);
            */
            Car myThirdCar = new Car("a", "s", 98, "PlatformID");
            Console.WriteLine(myThirdCar);
            Car.MyMethod();
        }
    }
    class Car
    {
        
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        
        public Car()
        {
            //You could load from a configuration file, 
            //a database, etc.
            this.Make = "Nissan";
        }
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Color = color;
            Year = year;
        }
        public static void MyMethod()
        {
            Console.WriteLine("called the static method");

        }
        
    }
}
