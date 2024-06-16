using CustomException;

Console.WriteLine("**** Fun with Custom Exception ****");
Car myCar = new Car("Rusty", 90);

try
{
    // Trip exception.
    myCar.Accelerate(50);
}
catch (CarIsDeadException e)
{
    Console.WriteLine($"\n*** Error! ***");
    Console.WriteLine($"Method: {e.TargetSite}");
    Console.WriteLine($"Message: {e.ErrorTimeStamp}");
    Console.WriteLine($"Source: {e.CauseOfError}");
    Console.WriteLine($"Stack: {e.StackTrace}");
    Console.WriteLine($"\n-> Custom Data:");
    foreach (System.Collections.DictionaryEntry de in e.Data)
        Console.WriteLine($"-> {de.Key}: {de.Value}");
}
