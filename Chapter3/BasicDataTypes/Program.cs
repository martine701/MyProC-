using System.Numerics;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("**** Fun with Basic Data Types");
LocalVarDeclarations();
DefautDeclarations();
NewingDataTypes();
ObjectFunctionality();
DataTypeFunctionality();
CharFunctionality();
ParsingFromString();
ParseFromStringWithTryParse();
UseDatesAndTimes();
UseBigInteger();
DigitSeparators();
BinaryLiterals();

void BinaryLiterals()
{
    Console.WriteLine("=> Use Binary Literals:");
    Console.WriteLine("Sixteen: {0}", 0b0001_0000);
    Console.WriteLine("Thirty Two: {0}", 0b0010_0000);
    Console.WriteLine("Sixty Four: {0}", 0b0100_0000);
}

void DigitSeparators()
{
    Console.WriteLine("=> Use Digit Separators:");
    Console.WriteLine("Integer:");
    Console.WriteLine(123_456);
    Console.WriteLine("Long:");
    Console.WriteLine(123_456_789L);
    Console.WriteLine("Float:");
    Console.WriteLine(123_456.1234F);
    Console.WriteLine("Double:");
    Console.WriteLine(123_456.12);
    Console.WriteLine("Decimal:");
    Console.WriteLine(123_456.12M);
    Console.WriteLine("Hex:");
    Console.WriteLine(0x2A_2B_2C);
    Console.WriteLine();
}

void UseBigInteger()
{
    Console.WriteLine("=> Use BigInteger:");
    BigInteger biggy = BigInteger.Parse("999999999999999999999999999999999999999999999999999");
    Console.WriteLine("Value of biggy is {0}", biggy);
    Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
    Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
    BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse("88888888888888888888888888888888888888"));
    Console.WriteLine("Value of reallyBig is {0}", reallyBig);
}

void UseDatesAndTimes()
{
    Console.WriteLine("=> Dates and Times:");

    //This constructor takes (year, month, day)
    DateTime dt = new DateTime(2024, 03, 14);
    //What day of the month is this?
    Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
    //Month is now December
    dt = dt.AddMonths(2);
    Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

    //This constructor takes (hours, minutes, seconds)
    TimeSpan ts = new TimeSpan(4, 30, 0);
    Console.WriteLine(ts);
    //Subtract 15 minutes from the current TimeSpan and
    //print the result
    Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));



}

void ParseFromStringWithTryParse()
{
    Console.WriteLine("=> Data type parsing with TryParse:");
    if (bool.TryParse("True", out bool b))
    {
        Console.WriteLine("Value of b: {0}", b);
    }
    else
    {
        Console.WriteLine("Value could not be parsed");
    }
    string value = "Hello";
    if (double.TryParse(value, out double d))
    {
        Console.WriteLine("Value of d: {0}", d);
    }
    else
    {
        Console.WriteLine("Value could not be parsed");
    }
    Console.WriteLine();
}

void ParsingFromString()
{
    Console.WriteLine("=> Data type parsing:");
    bool b = bool.Parse("True");
    Console.WriteLine("Value of b: {0}", b);
    double d = double.Parse("99.884");
    Console.WriteLine("Value of d: {0}", d);
    int i = int.Parse("8");
    Console.WriteLine("Value of i: {0}", i);
    char c = Char.Parse("w");
    Console.WriteLine("Value of c: {0}", c);
    Console.WriteLine();
}

void CharFunctionality()
{
    Console.WriteLine("=> char type Functionality:");
    char myChar = 'a';
    Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
    Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
    Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}", char.IsWhiteSpace("Hello There", 5));
    Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
    Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
    Console.WriteLine();
}

void DataTypeFunctionality()
{
    Console.WriteLine("=> Data Type Functionality:");

    Console.WriteLine("Max of int: {0}", int.MaxValue);
    Console.WriteLine("Min of int: {0}", int.MinValue);
    Console.WriteLine("Max of double: {0}", double.MaxValue);
    Console.WriteLine("Min of double: {0}", double.MinValue);
    Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
    Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
    Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);
    Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
    Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
    Console.WriteLine();
}

void ObjectFunctionality()
{
    Console.WriteLine("=> System.Object Functionality:");
    //A C# int is really a shorthand for System.Int32,
    //which inherits the following members from System.Object.
    Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
    Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
    Console.WriteLine("12.ToString() = {0}", 12.ToString());
    Console.WriteLine("12.GetType() = {0}", 12.GetType());
    Console.WriteLine();

}

static void LocalVarDeclarations()
{
    Console.WriteLine("=> Data Declarations:");
    // Local variables are declared using the following syntax:
    // dataType varName = initialValue;
    int myInt = 0;
    string myString;
    myString = "This is my character data";
    //declare three bools on a single line
    bool b1 = true, b2 = false, b3 = b1;
    //use System.Boolean data type to declare a bool
    System.Boolean b4 = false;
    Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);
    Console.WriteLine();
}

static void DefautDeclarations()
{
    Console.WriteLine("=> Default Declarations:");
    int myInt = default;
    bool myBool = default;
    char myChar = default;
    Console.WriteLine("Default int: {0}", myInt);
    Console.WriteLine("Default bool: {0}", myBool);
    Console.WriteLine("Default char: {0}", myChar);
    Console.WriteLine();
}

static void NewingDataTypes()
{
    Console.WriteLine("=> Using new to create variables:");
    bool b = new bool(); //set to false
    int i = new int(); //set to 0
    double d = new double(); //set to 0
    DateTime dt = new DateTime(); //set to 1/1/0001
    Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
    Console.WriteLine();
}
