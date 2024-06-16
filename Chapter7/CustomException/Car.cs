using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    internal class Car
    {
        public const int MaxSpeed = 100;
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";
        private bool carIsDead;
        private readonly Radio theMusicBox = new Radio();
        public Car() { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }
        public void CrankTunes(bool state)
        {
            theMusicBox.TurnOn(state);
        }
        public void Accelerate(int delta)
        {
            if (carIsDead)
                Console.WriteLine($"{PetName} is out of order...");
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    Console.WriteLine($"{PetName} has overheated!");
                    //CurrentSpeed = 0;
                    //carIsDead = true;
                    throw new CarIsDeadException($"{PetName} has overheated!", "You have a lead foot", DateTime.Now);
                    //Exception ex = new Exception($"{PetName} has overheated!");
                    //ex.HelpLink = "http://www.CarsRUs.com";
                    //ex.Data.Add("TimeStamp", $"The car exploded at {DateTime.Now}");
                    //ex.Data.Add("Cause", "You have a lead foot.");
                    //throw ex;
                }
                else
                    Console.WriteLine($"=> CurrentSpeed = {CurrentSpeed}");
            }
        }
    }
}

