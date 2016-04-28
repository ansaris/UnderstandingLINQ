using System;
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
                new Car() { VIN="A1", Make="BMW", Model="550i", StickerPrice=-0 },
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=0 },
                new Car() { VIN="C3", Make="BMW", Model="745li", StickerPrice=0 },
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=0 },
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=0 }

            };

            // LINQ query
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       select car;

            // LINQ method

            foreach (var car in bmws)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }

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
