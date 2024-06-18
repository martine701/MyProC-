using CarDelegate;

Console.WriteLine("***** Simple Delegate Example *****\n");

Car c1 = new Car("SlugBug", 100, 10);
c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));

Console.WriteLine("***** Speeding up *****");
for (int i = 0; i < 6; i++)
    c1.Accelerate(20);

c1.UnRegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
static void OnCarEngineEvent(string msg)
{
    Console.WriteLine("\n***** Message From Car Object *****");
    Console.WriteLine("=> {0}", msg);
    Console.WriteLine("***********************************\n");
}
