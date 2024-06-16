using FunWithRefTypeValTypeParams;

Console.WriteLine("*** Passing Person object by value ***");
Person fred = new Person("Fred", 12);
Console.WriteLine("\nBefore by value call, Person is:");
fred.Display();
SendAPersonByValue(fred);
Console.WriteLine("\nAfter by value call, Person is:");
fred.Display();
Console.WriteLine();

Console.WriteLine("*** Passing Person object by reference ***");
Person mel = new Person("Mel", 23);
Console.WriteLine("Before by reference call, Person is:");
mel.Display();
SendAPersonByReference(ref mel);
Console.WriteLine("After by reference call, Person is:");
mel.Display();
Console.WriteLine();

void SendAPersonByValue(Person p)
{
   // Change the age of "p"?
   p.personAge = 99;

    // Will the caller see this reassignment?
    p = new Person("Nikki", 99);
}

static void SendAPersonByReference(ref Person p)
{
    // Change some data of "p".
    p.personAge = 555;

    // "p" is now pointing to a new object on the heap!
    p = new Person("Nikki", 999);
}
