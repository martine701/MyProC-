// See https://aka.ms/new-console-template for more information
using BasicInheritance;

Console.WriteLine("**** Basic Inheritance ****");
Car car = new Car(80) { Speed = 50 };
Console.WriteLine($"Car is going {car.Speed} MPH" );

MiniVan mv = new MiniVan() { Speed = 10 };
Console.WriteLine($"Van is going {mv.Speed} MPH");

