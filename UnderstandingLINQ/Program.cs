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

            }
            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int StickerPrice { get; set; }
    }
}
