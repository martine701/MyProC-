



Console.WriteLine("***** Fun with Arrays");
SimpleArrays();
ArrayInitialization();
DeclareImplicitArrays();
ArrayOfObjects();
RectMultidimensionalArray();
JaggedMultidimensionalArray();
PassAndReceiveArrays();
SystemArrayFunctionality();
IndicesAndRanges();

void IndicesAndRanges()
{
    Console.WriteLine("=> Indices and Ranges.");
    string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

    for (int i = 0; i < gothicBands.Length; i++)
    {
        Index idx = i;
        Console.WriteLine(gothicBands[idx] +", ");
    }
    Console.WriteLine();
    for (int i = 1; i <= gothicBands.Length; i++)
    {
        Index idx = ^i;
        Console.WriteLine(gothicBands[idx] + ", ");
    }
    Console.WriteLine();
    foreach (string band in gothicBands[0..2])
    {
        Console.WriteLine(band + ", ");
    }
    Console.WriteLine();

    Range range = 0..2;
    foreach (string band in gothicBands[range])
    {
        Console.WriteLine(band + ", ");
    }
    Console.WriteLine();

    Index idx1 = 0;
    Index idx2 = 2;
    Range range2 = idx1..idx2;
    foreach (string band in gothicBands[range2])
    {
        Console.WriteLine(band + ", ");
    }
    Console.WriteLine();
}

void SystemArrayFunctionality()
{
    Console.WriteLine("=> Working with System.Array.");
    // Initialize items at startup.
    string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };
    // Print out names in declared order.
    Console.WriteLine("Here is the array:");
    for (int i = 0; i < gothicBands.Length; i++)
    {
        // Print a name.
        Console.Write(gothicBands[i] + ", ");
    }
    Console.WriteLine("\n");
    // Reverse them...
    Array.Reverse(gothicBands);
    Console.WriteLine("The reversed array");
    // ... and print them.
    for (int i = 0; i < gothicBands.Length; i++)
    {
        // Print a name.
        Console.Write(gothicBands[i] + ", ");
    }
    Console.WriteLine("\n");
    // Clear out all but the first two items.
    Console.WriteLine("Cleared out all but two...");
    Array.Clear(gothicBands, 2, 1);
    // ... and print them.
    for (int i = 0; i < gothicBands.Length; i++)
    {
        // Print a name.
        Console.Write(gothicBands[i] + ", ");
    }
    Console.WriteLine();
}

void PassAndReceiveArrays()
{
    Console.WriteLine("=> Arrays as params and return values.");
    // Pass array as parameter.
    int[] ages = { 20, 22, 23, 0 };
    PrintArray(ages);
    // Get array as return value.
    string[] strs = GetStringArray();
    foreach (string s in strs)
    {
        Console.WriteLine(s);
    }
    Console.WriteLine();

}

static string[] GetStringArray()
{
    string[] theStrings = { "Hello", "from", "GetStringArray" };
    return theStrings;
}   
static void PrintArray(int[] myInts)
{
    for (int i = 0; i < myInts.Length; i++)
    {
        Console.WriteLine("Item {0} is {1}", i, myInts[i]);
    }    
}
void JaggedMultidimensionalArray()
{
    Console.WriteLine("=> Jagged Multidimensional Array.");
    // A jagged MD array (i.e., an array of arrays).
    // Here we have an array of 5 different arrays.
    int[][] myJagArray = new int[5][];
    // Create the jagged array.
    for (int i = 0; i < myJagArray.Length; i++)
    {
        myJagArray[i] = new int[i + 7];
    }
    // Print each row (remember, each element is defaulted to zero!).
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < myJagArray[i].Length; j++)
        {
            Console.Write(myJagArray[i][j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void RectMultidimensionalArray()
{
    Console.WriteLine("=> Rectangular Multidimensional Array.");
    // A rectangular MD array.
    int[,] myMatrix;
    myMatrix = new int[6, 6];
    // Populate (6 * 6) array.
    for (int i = 0; i < 6; i++)
    {
        for (int j = 0; j < 6; j++)
        {
            myMatrix[i, j] = i * j;
        }
    }
    // Print (6 * 6) array.
    for (int i = 0; i < 6; i++)
    {
        for (int j = 0; j < 6; j++)
        {
            Console.Write(myMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ArrayOfObjects()
{
    Console.WriteLine("=> Array of Objects.");
    // An array of objects can be anything at all.
    object[] myObjects = new object[4];
    myObjects[0] = 10;
    myObjects[1] = false;
    myObjects[2] = new DateTime(1969, 3, 11);
    myObjects[3] = "Form & Void";
    foreach (object obj in myObjects)
    {
        // Print the type and value for each item in array.
        Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
    }
    Console.WriteLine();
}

void DeclareImplicitArrays()
{
    Console.WriteLine("=> Implicit Array Initialization.");
    // a is really int[]
    var a = new[] { 1, 10, 100, 1000 };
    Console.WriteLine("a is a: {0}", a.ToString());
    
    // b is really double[]
    var b = new[] { 1, 1.5, 2, 2.5 };
    Console.WriteLine("b is a: {0}", b.ToString());

    // c is really string[]
    var c = new[] { "hello", null, "world" };
    Console.WriteLine("c is a: {0}", c.ToString());
    Console.WriteLine();
}

void ArrayInitialization()
{
    Console.WriteLine("=> Array Initialization.");
    // Array initialization syntax using the new keyword.
    string[] stringArray = new string[] { "one", "two", "three" };
    Console.WriteLine("stringArray has {0} elements", stringArray.Length);

    // Array initialization syntax without using the new keyword.
    bool[] boolArray = { false, false, true };
    Console.WriteLine("boolArray has {0} elements", boolArray.Length);

    // Array initialization with new keyword and size.
    int[] intArray = new int[4] { 20, 22, 23, 0 };
    Console.WriteLine("intArray has {0} elements", intArray.Length);
    Console.WriteLine();
}

void SimpleArrays()
{
   Console.WriteLine("=> Simple Array Creation.");
    // Create and fill an array of 3 Integers
    int[] myInts = new int[3];
    myInts[0] = 100;
    myInts[1] = 200;
    myInts[2] = 300;
    // Now print each value.
    foreach (int i in myInts)
    {
        Console.WriteLine(i);
    }

    //create an array of 100 strings, indexed 0-99
    string[] booksOnDotNet = new string[100];
    Console.WriteLine();
}
