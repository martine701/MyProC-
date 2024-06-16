using static InterfaceExtensions.AnnoyingExtensions;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("**** Extending Interface Compatible Types **** \n");
string[] data = { "Wow", "this", "is", "sort", "of", "annoying", "but", "in", "a", "weird", "way", "fun!" };
data.PrintDataAndBeep();
Console.WriteLine();

List<int> myInts = new List<int>() { 10, 15, 20 };
myInts.PrintDataAndBeep();
Console.WriteLine();

