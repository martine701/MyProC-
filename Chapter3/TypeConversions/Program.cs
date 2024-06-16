

Console.WriteLine("***** Fun with type conversions *****\n");
// Add two shorts and print the result.
short numb1 = 9, numb2 = 10;
Console.WriteLine("{0} + {1} = {2}", numb1, numb2, Add(numb1, numb2));
Console.WriteLine();

// compiler error below!
//short numb3 = 3000000000000000, numb4 = 30000;
//Console.WriteLine("{0} + {1} = {2}", numb3, numb4, Add(numb3, numb4));
//Console.WriteLine();

//Another compiler error!
//static void NarrowingAttempt()
//{
//    byte myByte = 0;
//    int myInt = 200;
//    myByte = myInt;
//    Console.WriteLine("Value of myByte: {0}", myByte);
//}

short numb3 = 30000, numb4 = 30000;
Console.WriteLine("{0} + {1} = {2}", numb3, numb4, (short)Add(numb3, numb4));
Console.WriteLine();
NarrowingAttempt();
ProcessBytes();
LinqQueryOverInts();
IfElsePatternMatchingUpdatedInCSharp();
ExecuteIfElseUsingConditionalOperator();
ConditionalRefExample();
ExecutePatternMatchingSwitchWithWhen();

void ExecutePatternMatchingSwitchWithWhen()
{
    Console.WriteLine("***** Fun with Pattern Matching *****\n");
    Console.WriteLine("1 [C#], 2 [VB]");
    Console.Write("Please pick your language preference: ");

    string langChoice = Console.ReadLine();

    object choice = langChoice == "1" ? (object)"C#" : "VB";

    switch (choice)
    {
        case int i when i == 2:
        case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
            Console.WriteLine("VB:OOP, multithreading, and more!");
            break;
        case int i when i == 1:
        case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
            Console.WriteLine("Good choice, C# is a fine language");
            break;
        default:
            Console.WriteLine("Well...good luck with that!");
            break;
    }
    Console.WriteLine();
}

void ConditionalRefExample()
{
    var smallArray = new int[] { 1, 2, 3, 4, 5 };
    var largeArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int index = 7;
    ref int refValue = ref ((index < 5) ? ref smallArray[index] : ref largeArray[index]);
    refValue = 0;
    index = 2;
    ((index < 5) ? ref smallArray[index] : ref largeArray[index]) = 100;
    Console.WriteLine("smallArray[2] = " + smallArray[2]);
    Console.WriteLine("largeArray[7] = " + largeArray[7]);

    Console.WriteLine();
    Console.WriteLine(string.Join(", ", smallArray));
    Console.WriteLine(string.Join(", ", largeArray));
}

void ExecuteIfElseUsingConditionalOperator()
{
    string stringData = "My textual data";
    Console.WriteLine(stringData.Length > 0 ? "string is greater than 0" : "string is not greater than 0");
    Console.WriteLine();

    //stringData.Length > 0 ? Console.WriteLine("string is greater than 0") : Console.WriteLine("string is not greater than 0");

    Console.WriteLine();

}

void IfElsePatternMatchingUpdatedInCSharp()
{
    Console.WriteLine("***** Fun with Pattern Matching *****\n");
    object testItem1 = 123;
    Type t = typeof(string);
    char c = 'f';

    //Type patterns
    if (t is Type)
    {
        Console.WriteLine($"{t} is a Type");
    }

    //Relational, conjuctive, and disjunctive patterns
    if (c is >= 'a' and <= 'z' or >= 'A' and <= 'Z')
    {
        Console.WriteLine($"{c} is a character");
    }

    //Parenthesized patterns
    if (c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z'))
    {
        Console.WriteLine($"{c} is a character or separator");
    }

    //Negative patterns
    if (testItem1 is not string)
    {
        Console.WriteLine($"{testItem1} is not a string");
    }

    if (testItem1 is not null)
    {
        Console.WriteLine($"{testItem1} is not null");
    }
}

void LinqQueryOverInts()
{
    int[] ints = { 10, 45, 15, 39, 21, 26 };
    var subset = from i in ints where i < 20 select i;
    Console.Write("Values in subset: ");
    foreach (var i in subset)
    {
        Console.Write("{0} ", i);
    }
    Console.WriteLine();
    Console.WriteLine("subset is of type: {0}", subset.GetType().Name);
    Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
    Console.WriteLine();
}

void ProcessBytes()
{
    byte b1 = 100;
    byte b2 = 250;
    try
    {
        byte sum = checked((byte)Add(b1, b2));
        Console.WriteLine("sum = {0}", sum);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

static void NarrowingAttempt()
{
    byte myByte = 0;
    int myInt = 200;
    myByte = (byte)myInt;
    Console.WriteLine("Value of myByte: {0}", myByte);
}

static int Add(int x, int y)
{
    return x + y;
}
