// See https://aka.ms/new-console-template for more information
using SimpleException;
using System.Collections;

Console.WriteLine("Simple Exception Example");
Console.WriteLine("=> Creating a car and stepping on it!");
Car myCar = new Car("Zippy", 20);
myCar.CrankTunes(true);
try
{
    for (int i = 0; i < 15; i++)
    {
        myCar.Accelerate(10);
    }
}
catch (Exception e)
{
    const string message = "**** Error ****";
    Console.WriteLine(message);
    Console.WriteLine($"Method: {e.TargetSite}");
    Console.WriteLine($"Message: {e.Message}");
    Console.WriteLine($"Source: {e.Source}");
    Console.WriteLine($"Help Link: {e.HelpLink}");
    Console.WriteLine("\n-> Custom Data:");
    foreach (DictionaryEntry de in e.Data)
        Console.WriteLine($"-> {de.Key}: {de.Value}");
    

    //throw;
}

Console.ReadLine();

