using PublicDelegateProblem;

Console.WriteLine("*** Problem with Delegates");

Console.WriteLine("**** Agh, No encapsulation!");

//Make a car
Car myCar = new Car();
myCar.listOfHandlers = CallWhenExploded;
myCar.Accelerate(10);

myCar.listOfHandlers = CallHereToo;
myCar.Accelerate(10);

myCar.listOfHandlers.Invoke("hee, hee, hee...");
Console.ReadLine();

static void CallWhenExploded(string msg)
{
    Console.WriteLine(msg);
}
static void CallHereToo(string msg)
{
    Console.WriteLine(msg);
}

