﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Understanding_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", Price=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", Price=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", Price=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", Price=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", Price=57000, Year=2010}
            };

            // LINQ query
            
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car;
            

            
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;


            // LINQ method
            var bmws2 = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);

            var orderedCars2 = myCars.OrderByDescending(p => p.Year);


            var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
            Console.WriteLine(firstBMW.VIN);


            Console.WriteLine(myCars.TrueForAll(p => p.Year > 2007));

            myCars.ForEach(p => p.Price -= 3000);
            myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.Price));

            Console.WriteLine(myCars.Exists(p => p.Model == "745li"));

            Console.WriteLine(myCars.Sum(p => p.Price));

            
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1}", car.Year, car.Model, car.VIN);
            }
            

            Console.WriteLine(myCars.GetType());
            var orderedCars3 = myCars.OrderByDescending(p => p.Year);
            Console.WriteLine(orderedCars3.GetType());

            var bmws3 = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);
            Console.WriteLine(bmws3.GetType());


            var newCars = from car in myCars
                          where car.Make == "BMW"
                          && car.Year == 2010
                          select new { car.Make, car.Model };
            Console.WriteLine(newCars.GetType());

            Console.ReadLine();
        }
    
    }
    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
    }
}
