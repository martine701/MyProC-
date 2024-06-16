using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    internal class Car
    {
        public readonly int maxSpeed;
        private int _currSpeed;

        public Car(int max)
        {
            maxSpeed = max;
        }
        public Car() { maxSpeed = 55; }
        public int Speed
        {
            get { return _currSpeed; }
            set
            {
                _currSpeed = value;
                if (_currSpeed > maxSpeed)
                {
                    _currSpeed = maxSpeed;
                }
            }
        }
    }
}
