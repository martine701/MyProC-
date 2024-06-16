using System.Data;



// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Fun with Indexers ***");

PersonCollection myPeople = new PersonCollection();

myPeople["Homer"] = new Person("Homer", "Simpson", 40);
myPeople["Marge"] = new Person("Marge", "Simpson", 38);
myPeople["Lisa"] = new Person("Lisa", "Simpson", 9);
myPeople["Bart"] = new Person("Bart", "Simpson", 7);
myPeople["Maggie"] = new Person("Maggie", "Simpson", 2);

for (int i = 0; i < myPeople.Count; i++)
{
    Console.WriteLine($"Person number: {i}");
    Console.WriteLine(myPeople[i].Name);
    Console.WriteLine($"Age: {myPeople[i].Age}");
    Console.WriteLine();
}
