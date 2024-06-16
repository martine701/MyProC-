// See https://aka.ms/new-console-template for more information
using FunWithNullableReferenceTypes;

Console.WriteLine("**** Fun with Nullable Reference Types ****");
string? NullString = null;
Console.WriteLine($"NullString length: {NullString?.Length}");
TestClass? tc = null;
Console.WriteLine($"tc?.Name length: {tc?.Name.Length}");

#nullable disable
TestClass tc2 = null;
Console.WriteLine($"tc2?.Name length: {tc2?.Name.Length}");
#nullable restore

