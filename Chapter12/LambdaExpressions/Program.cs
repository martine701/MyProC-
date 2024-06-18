// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Fun with Lambdas");
TraditionalDelegateSyntaxx();
AnonymousMethodSyntax();
LambdaExpressionSyntax();
Console.ReadLine();

static void TraditionalDelegateSyntaxx()
{
    List<int> list = new List<int> { 20, 1, 4, 8, 9, 44 };
    Predicate<int> callback = IsEvenNumber;
    List<int> evenNumbers = list.FindAll(callback);
    Console.WriteLine("Here are your even numbers:");
    foreach (int evenNumber in evenNumbers)
    {
        Console.Write("{0}\t", evenNumber);
    }
    Console.WriteLine();
}

static bool IsEvenNumber(int i)
{
    return (i % 2) == 0;
}

static void AnonymousMethodSyntax()
{
    List<int> list = new List<int> { 20, 1, 4, 8, 9, 44 };
    List<int> evenNumbers = list.FindAll(delegate (int i)
    {
        return (i % 2) == 0;
    });
    Console.WriteLine("Here are your even numbers:");
    foreach (int evenNumber in evenNumbers)
    {
        Console.Write("{0}\t", evenNumber);
    }
    Console.WriteLine();
}

static void LambdaExpressionSyntax()
{
    List<int> list = new List<int> { 20, 1, 4, 8, 9, 44 };
    List<int> evenNumbers = list.FindAll((i =>
    {
        Console.WriteLine("Value of i is currently: {0}", i);
        bool isEven = ((i % 2 )== 0);
        return isEven;
        }));
    
    Console.WriteLine("Here are your even numbers:");
    foreach (int evenNumber in evenNumbers)
    {
        Console.Write("{0}\t", evenNumber);
    }
    Console.WriteLine();
}
