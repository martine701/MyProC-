// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Generic Delegates ***");
MyGenericDelegate<string> strTarget = new MyGenericDelegate<string>(StringTarget);
strTarget("Some string data");
MyGenericDelegate<int> intTarget = new MyGenericDelegate<int>(IntTarget);
intTarget(9);
static void StringTarget(string arg)
{
    Console.WriteLine("arg in uppercase: " + arg.ToUpper());
}

static void IntTarget(int arg)
{
    Console.WriteLine("++arg: " + ++arg);
}

public delegate void MyGenericDelegate<T>(T arg);

