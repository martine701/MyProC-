// See https://aka.ms/new-console-template for more information

using FunWithValueAndReferenceTypes;

Console.WriteLine("**** Fun with Value and Reference Types ****");
ValueTypeContainingRefType();

void ValueTypeContainingRefType()
{
   // Create the first Rectangle
   Console.WriteLine("-> Creating r1");
    Rectangle r1 = new Rectangle("First Rect", 10, 10, 50, 50);
    // Now assign a new Rectangle to r1
    Console.WriteLine("-> Assigning r2 to r1");
    Rectangle r2 = r1;
    // Change some values of r2
    Console.WriteLine("-> Changing values of r2");
    r2.rectInfo.infoString = "This is new info!";
    r2.rectBottom = 4444;
    // Print values of both rectangles
    r1.Display();
    r2.Display();
    Console.WriteLine();
}