using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachWithExtensionMethods
{
    internal class Car
    {
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

        public Car(string name, int speed, string color)
        {
            PetName = name;
            Speed = speed;
            Color = color;
        }
    }
}
