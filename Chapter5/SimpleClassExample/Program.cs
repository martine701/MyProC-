using SimpleClassExample;
    
    
Console.WriteLine("**** Fun with Class Types ****");
Car myCar = new Car();
myCar.PrintState();

myCar.petName = "Henry";
myCar.currSpeed = 10;

for (int i = 0; i <= 10; i++)
{
    myCar.SpeedUp(5);
    myCar.PrintState();
}

Car Mary = new Car("Mary");
Mary.PrintState();

Car Daisy = new Car("Daisy", 75);
Daisy.PrintState();

