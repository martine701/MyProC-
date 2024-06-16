// See https://aka.ms/new-console-template for more information
using ObjectOverrides;

Console.WriteLine("**** Fun with System.Object ****\n");
Person p1 = new Person();
//use inherited members of System.Object.
Console.WriteLine("ToString: {0}", p1.ToString());
Console.WriteLine("Hash code: {0}", p1.GetHashCode());
Console.WriteLine("Type: {0}", p1.GetType());
// Make some other references to p1.
Person p2 = p1;
object o = p2;
// Are the references pointing to the same object in memory?
if (o.Equals(p1) && p2.Equals(o))
{
    Console.WriteLine("Same instance!");
}
else
{
    Console.WriteLine("Different instance!");
}

Person p3 = new Person("111-11-1111","Sally", "Jones", 4);
Person p4 = new Person("111-11-1111","Sally", "Jones", 4);
// Get stringified version of objects.
Console.WriteLine("p3.ToString() = {0}", p3.ToString());
Console.WriteLine("p4.ToString() = {0}", p4.ToString());
// Test overriden Equals().
Console.WriteLine("p3 = p4?: {0}", p3.Equals(p4));
// Test hash codes.
Console.WriteLine("Same hash codes?: {0}", p3.GetHashCode() == p4.GetHashCode());
// Change age of p4 and test again.
p4.Age = 456;
Console.WriteLine("p3 = p4?: {0}", p3.Equals(p4));
Console.WriteLine("p3's hash code: {0}", p3.GetHashCode());
Console.WriteLine("p4's hash code: {0}", p4.GetHashCode());
Console.ReadLine();

