﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>
            {
                new Car() { VIN = "A1", Make = "BMW",Model = "550i", StickerPrice = 55000, Year = 2008  },
                new Car() { VIN = "B2", Make = "Toyota",Model = "Raf4", StickerPrice = 35000, Year = 2012  },
                new Car() { VIN = "C3", Make = "BMW",Model = "745li", StickerPrice = 75000, Year = 2004  },
                new Car() { VIN = "D4", Make = "Ford",Model = "Escape", StickerPrice = 25000, Year = 2009  },
                new Car() { VIN = "E5", Make = "BMW", Model = "55i", StickerPrice = 57000, Year = 2018 }
            };
            //LINQ query
            /*
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2004
                       select car;
            */
            /*
            var orderedCars = from car in myCars
                              orderby car.Year ascending
                              select car;
            */

            //LINQ method

            //var bmws = myCars.Where(Car =>Car.Make == "BMW" && Car.Year == 2004);

            //var orderedCars = myCars.OrderByDescending(Car => Car.Year);
            /*
            var firstBMW = myCars.OrderByDescending(Car => Car.Year).First(Car => Car.Make == "BMW");
            Console.WriteLine(firstBMW.VIN);
            */

            //Console.WriteLine(myCars.TrueForAll(Car => Car.Year > 2003));

            //myCars.ForEach(Car => Console.WriteLine("{0} {1}", Car.Make, Car.Model));

            //Console.WriteLine(myCars.Exists(Car => Car.VIN == "A1"));

            /*
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1}", car.Model, car.Year);
            }
            */
            Console.WriteLine(myCars.GetType());

            var orderedCars = myCars.OrderByDescending(Car => Car.Year);
            Console.WriteLine(orderedCars.GetType());
            var orderedCar = myCars.OrderByDescending(Car => Car.Model);
            Console.WriteLine(orderedCar.GetType());
            Console.ReadLine();
        }
    }
    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
