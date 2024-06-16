using ExtensionMethods;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Fun with Extension Methods ***");
int myInt = 1234567;
myInt.DisplayDefiningAssembly();

System.Data.DataSet d = new System.Data.DataSet();
d.DisplayDefiningAssembly();
Console.WriteLine("Value of myInt: {0}", myInt);
Console.WriteLine("Reversed value of myInt: {0}", myInt.ReverseDigits());
Console.WriteLine();

string myString = "Hello Extension Methods";
Console.WriteLine("Value of myString: {0}", myString);
Console.WriteLine("Word count of myString: {0}", myString.WordCount());
Console.WriteLine(myString.ToDecapitalize());
Console.WriteLine(myString.ToDotCase());



