
Console.WriteLine("***** Fun with Methods *****");
int x= 9, y = 10;
Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
Console.WriteLine("Answer is: {0}", Add(x, y));
Console.WriteLine("After call: X: {0}, Y: {1}", x, y);

Console.WriteLine("***********************************");
int ans;
AddUsingOutParam(90, 90, out ans);
Console.WriteLine("90 + 90 = {0}", ans);
Console.WriteLine("***********************************");


FillTheseValues(out int i, out string str, out bool b);
Console.WriteLine("Int is: {0}", i);
Console.WriteLine("String is: {0}", str);
Console.WriteLine("Boolean is: {0}", b);
//This only gets value for a, and ignores the other two parameters
FillTheseValues(out int a, out _, out _);
Console.WriteLine("Int is: {0}", a);
Console.WriteLine("***********************************");

string str1 = "Flip";
string str2 = "Flop";
Console.WriteLine("Before: {0}, {1}", str1, str2);
SwapStrings(ref str1, ref str2);
Console.WriteLine("After: {0}, {1}", str1, str2);
Console.WriteLine("***********************************");
double average;
average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
Console.WriteLine("Average of data is: {0}", average);
Console.WriteLine("***********************************");
EnterLogData("Oh no! Grid can't find data");
EnterLogData("Oh no! I can't find the payroll data", "CFO");
Console.WriteLine("***********************************");
DisplayFancyMessage(message: "Wow! Very Fancy indeed!", textColor: ConsoleColor.DarkRed, backgroundColor: ConsoleColor.White);
DisplayFancyMessage(backgroundColor: ConsoleColor.Green, textColor: ConsoleColor.DarkBlue, message: "Testing 1, 2, 3");
DisplayFancyMessage(ConsoleColor.Blue, ConsoleColor.White, "Hello!");
Console.WriteLine("***********************************");


static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
{
    // Store old colors to restore after message is printed.
    ConsoleColor oldTextColor = Console.ForegroundColor;
    ConsoleColor oldbackgroundColor = Console.BackgroundColor;
    // Set new colors and print message
    Console.ForegroundColor = textColor;
    Console.BackgroundColor = backgroundColor;
    Console.WriteLine(message);
    // Restore previous colors
    Console.ForegroundColor = oldTextColor;
    Console.BackgroundColor = oldbackgroundColor;
}   
static void EnterLogData(string message, string owner = "Programmer")
{
    Console.Beep();
    Console.WriteLine("Error: {0}", message);
    Console.WriteLine("Owner of Error: {0}", owner);
}   
//Return average of "some" number of doubles
static double CalculateAverage(params double[] values)
{
    Console.WriteLine("You sent me {0} doubles.", values.Length);
    double sum = 0;
    if (values.Length == 0)
    {
        return sum;
    }
    for (int i = 0; i < values.Length; i++)
    {
        sum += values[i];
    }
    return (sum / values.Length);
}
static int AddReadOnly(in int x, in int y)
{
    // Error! Can't modify value of x or y!
    //x = 10000;
    //y = 88888;
    return x + y;
}

void SwapStrings(ref string str1, ref string str2)
{
    string tempStr = str1;
    str1 = str2;
    str2 = tempStr;
}

//Returning multiple output parameters
static void FillTheseValues(out int a, out string b, out bool c)
{
    a = 9;
    b = "Enjoy your string";
    c= true;
}
static int Add(int x, int y)
{
    int ans = x + y;
    // Caller will not see these changes
    // as you are modifying a copy of the original data.
    x = 10000;
    y = 88888;
    return ans;
}   

//output parameters must be assigned a value by the called method
static void AddUsingOutParam(int x, int y, out int ans)
{
    ans = x + y;
}

