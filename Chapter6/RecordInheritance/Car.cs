using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordInheritance
{
    internal class Car
    {
        public string Make { get; init; }
        public string Model { get; init; }
        public int Year { get; init; }
        public string Color { get; init; }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
    }
}
