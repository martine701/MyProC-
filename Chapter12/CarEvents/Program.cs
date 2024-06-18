using CarEvents;
Console.WriteLine("*** Car Events ***");

Car c1 = new Car();
c1.MaxSpeed = 100;
c1.CurrentSpeed = 10;
c1.AboutToBlow += CarIsAlmostDoomed;
c1.AboutToBlow += CarAboutToBlow;

Car.CarEngineHandler d = CarExploded;
c1.Exploded += d;
for (int i = 0; i < 6; i++)
{
    c1.Accelerate(20);
}
c1.Exploded -= d;
for (int i = 0; i < 6; i++)
{
    c1.Accelerate(20);
}

static void CarAboutToBlow(string msg)
{
    Console.WriteLine(msg);
}

static void CarIsAlmostDoomed(string msg)
{
    Console.WriteLine("=> Critical Message from Car: {0}", msg);
}

static void CarExploded(string msg)
{
    Console.WriteLine(msg);
}