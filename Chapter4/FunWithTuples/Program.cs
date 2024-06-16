// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
(string,int,string) values = ("a", 5, "c");
var values2 = ("a",5, "c");
Console.WriteLine(values.Item1);
Console.WriteLine(values.Item2);
Console.WriteLine(values.Item3);


Console.WriteLine(values2.Item1);
Console.WriteLine(values2.Item2);
Console.WriteLine(values2.Item3);

(string FirstLetter, int TheNumber, string SecondLetter)  valuesWithNames = ("a", 5, "c");
var valuesWithNames2 = (FirstLetter:"a", TheNumber:5, SecondLetter:"c");
Console.WriteLine(valuesWithNames.FirstLetter);
Console.WriteLine(valuesWithNames.TheNumber);
Console.WriteLine(valuesWithNames.SecondLetter);

Console.WriteLine(valuesWithNames2.Item1);
Console.WriteLine(valuesWithNames2.Item2);
Console.WriteLine(valuesWithNames2.Item3);



