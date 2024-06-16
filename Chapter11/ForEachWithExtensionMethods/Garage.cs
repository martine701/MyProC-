using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachWithExtensionMethods
{
    internal class Garage
    {
        private Car[] carArray = new Car[4];

        public Garage()
        {
            carArray[0] = new Car("Rusty", 30, "Brown");
            carArray[1] = new Car("Clunker", 55, "Rust");
            carArray[2] = new Car("Zippy", 30, "Black");
            carArray[3] = new Car("Fred", 45, "Red");
        }

        public IEnumerator<Car> GetEnumerator()
        {
            foreach (Car c in carArray)
            {
                yield return c;
            }
        }
    }
}
