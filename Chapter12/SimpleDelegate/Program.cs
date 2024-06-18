
using SimpleDelegate;

Console.WriteLine("*** Simple Delegate");
SimpleMath sm = new SimpleMath();
BinaryOP b = new BinaryOP(sm.Add);

DisplayDelegateInfo(b);

Console.WriteLine($"10 + 10 is {b(10, 10)}");

//BinaryOP b2 = new BinaryOP(SimpleMath.SquareNumber);

static void DisplayDelegateInfo(Delegate delObj)
{
    foreach (Delegate d in delObj.GetInvocationList())
    {
        Console.WriteLine($"Method Name: {d.Method}");
        Console.WriteLine($"Type Name: {d.Target}");
    }
}

public delegate int BinaryOP(int x, int y);
