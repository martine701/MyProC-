

Console.WriteLine("**** Fun with Enums ****");
EmpTypeEnum emp = EmpTypeEnum.Contractor;
AskForBonus(emp);

Console.WriteLine("EmpTypeEnum uses {0} for storage", Enum.GetUnderlyingType(emp.GetType()));
Console.WriteLine("EmpTypeEnum uses {0} for storage", Enum.GetUnderlyingType(typeof(EmpTypeEnum)));
Console.WriteLine("emp is a {0}", emp.ToString());
Console.WriteLine("{0} = {1}", emp.ToString(),(byte)emp);

DayOfWeek day = DayOfWeek.Monday;
ConsoleColor cc = ConsoleColor.Gray;

EvaluateEnum(EmpTypeEnum.Manager);
EvaluateEnum(day);
EvaluateEnum(cc);


//This method will print out the details of any enum
static void EvaluateEnum(System.Enum e)
{
    Console.WriteLine("=> Information about {0}", e.GetType().Name);
    Console.WriteLine("Underlying storage type: {0}", Enum.GetUnderlyingType(e.GetType()));

    //Get all name/value pairs for incoming parameter
    Array enumData = Enum.GetValues(e.GetType());
    Console.WriteLine("This enum has {0} members.", enumData.Length);

    //Now show the string name and associated value, using the D format flag
    for (int i = 0; i < enumData.Length; i++)
    {
        Console.WriteLine("Name: {0}, Value: {0:D}", enumData.GetValue(i));
    }   
}

Console.WriteLine();

void AskForBonus(EmpTypeEnum emp)
{
    switch (emp)
    {
        case EmpTypeEnum.Manager:
            Console.WriteLine("How about stock options instead?");
            break;
        case EmpTypeEnum.Grunt:
            Console.WriteLine("You have got to be kidding...");
            break;
        case EmpTypeEnum.Contractor:
            Console.WriteLine("You already get enough cash...");
            break;
        case EmpTypeEnum.VicePresident:
            Console.WriteLine("VERY GOOD, Sir!");
            break;
        default:
            break;
    }
}

enum EmpType
{
    Manager, // = 0
    Grunt, // = 1
    Contractor, // = 2
    VicePresident // = 3
}

enum EmpTypeEnum : byte
{
    Manager = 102, // = 102
    Grunt, // = 103
    Contractor, // = 104
    VicePresident // = 105
}

//Elements of an enumeration need not be sequential
enum EmpTypeEnum2 : byte
{
    Manager = 10, 
    Grunt = 1, 
    Contractor = 100, 
    VicePresident = 9 
}   


