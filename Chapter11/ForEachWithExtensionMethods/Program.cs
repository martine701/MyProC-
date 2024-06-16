// See https://aka.ms/new-console-template for more information
using ForEachWithExtensionMethods;

Console.WriteLine("**** Support for Extension Method GetEnumerator ****");

Garage carLot = new Garage();

// Hand over each car in the collection?
foreach (Car c in carLot)
{
    Console.WriteLine("{0} is going {1} MPH", c.PetName, c.Speed);
}
