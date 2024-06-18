using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        private bool carIsDead;

        public delegate void CarEngineHandler(string msgForCaller);
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;
         
   

    public void Accelerate(int delta)
    {
        if (carIsDead)
        {
            if (Exploded != null)
                Exploded("Sorry, this car is dead...");
        }
        else
        {
            CurrentSpeed += delta;

            if (10 == MaxSpeed - CurrentSpeed && AboutToBlow != null)
                AboutToBlow("Careful buddy! Gonna blow!");
            if (CurrentSpeed >= MaxSpeed)
                carIsDead = true;
            else
                Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
        }
    }
    }
}
