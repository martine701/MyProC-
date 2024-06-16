// See https://aka.ms/new-console-template for more information
Console.WriteLine("**** Fun with Structures ****");

Point myPoint;
myPoint.X = 349;
myPoint.Y = 76;
myPoint.Display();

//adjust the X and Y values
myPoint.Increment();
myPoint.Display();

//call custom constructor
Point p2 = new Point(50, 60);
p2.Display();

//a custom constructor for the ReadOnlyPoint
PointWithReadOnly p3 = new PointWithReadOnly(50, 60,"Point w/RO");
p3.Display();

struct Point
{
    public int X;
    public int Y;

    public Point(int XPos, int YPos)
    {
        X = XPos;
        Y = YPos;
    }

    //add 1 to the X and Y values of the Point object
    public void Increment()
    {
        X++;
        Y++;
    }

    //subtract 1 from the X and Y values of the Point object
    public void Decrement()
    {
        X--;
        Y--;
    }
    //display the current X and Y values of the Point object
    public void Display()
    {
        Console.WriteLine("X = {0}, Y = {1}", X, Y);
    }
}

readonly struct  ReadOnlyPoint
{
    //Fiels of the structure
    public int X { get; }
    public int Y { get; }

    public void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}");
    }

    public ReadOnlyPoint(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }

}

struct PointWithReadOnly
{
    public int X;
    public readonly int Y;
    public readonly string Name;

    public PointWithReadOnly(int xPos, int yPos,string name)
    {
        Name = name;
        X = 0;
        Y = 0;
    }

    public void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}, Name = {Name}");
    }
}
