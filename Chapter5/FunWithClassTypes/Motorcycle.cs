using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithClassTypes
{
    class Motorcycle
    {
        public int driverIntensity;
        public string driverName;
        public Motorcycle() {}
        public Motorcycle(int intensity) 
            : this(intensity, ""){}
        public Motorcycle(string name): this(0, name) { }
        
        public Motorcycle(int intensity=0, string name="")
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }
        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaaaw!");
            }
        }
        public void SetDriverName(string dname) => this.driverName = dname;
        
    }
}
