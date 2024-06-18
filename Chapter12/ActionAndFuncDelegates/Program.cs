static void DisplayMessage(string msg, ConsoleColor txtcolor, int printCount)
{
    ConsoleColor originalColor = Console.ForegroundColor;
    Console.ForegroundColor = txtcolor;
    for (int i = 0; i < printCount; i++)
    {
        Console.WriteLine(msg);
    }
    Console.ForegroundColor = originalColor;

}


Console.WriteLine("***** Fun with Action and Func *****\n");

Action<string, ConsoleColor, int> actionTarget = DisplayMessage;
actionTarget("Action Message!", ConsoleColor.Yellow, 5);

Console.WriteLine("***** End Fun with Action and Func *****\n");

static int Add(int x, int y) => x + y;
static string SumToString(int x, int y) => (x + y).ToString();

Func<int, int, int> funcTarget = Add;
int result = funcTarget.Invoke(40, 40);
Console.WriteLine("40 + 40 = {0}", result);
Func<int, int, string> funcTarget2 = SumToString;
string sum = funcTarget2(90, 300);
Console.WriteLine(sum);



Console.ReadLine();


