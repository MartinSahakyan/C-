using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car1.VIN = "B2";

            Book b1 = new Book();
            b1.Author = "Knuth";
            b1.Title = "Algorithms";
            b1.ISBN = "0-000-00000-0";
            //ArrayLists are Dynamic sized
            /*
            ArrayList MyArrayList = new ArrayList();
            MyArrayList.Add(car1);
            MyArrayList.Add(car2);
            MyArrayList.Add(b1);
            MyArrayList.Remove(b1);
            foreach (Car car in MyArrayList)
            {
                Console.WriteLine(car.Make);
            }
            */
            /*
            //List<T>
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(b1);
            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }
            */
            //Dictionare<TKey,TValue>


            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();

            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);
            Console.WriteLine(myDictionary["B2"].Model);
        }
    }

    internal class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { set; get; }
        public string Model { set; get; }
    }
}
