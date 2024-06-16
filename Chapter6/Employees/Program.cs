// See https://aka.ms/new-console-template for more information


using Employees;

Console.WriteLine("**** The Employee Class Hierarchy ****");
SalesPerson fred = new SalesPerson("Fred", 31, 30, 3000, "932-32-3232", 31);
fred.GiveBonus(200);
fred.DisplayStats();
Console.WriteLine();
Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
chucky.GiveBonus(300);
chucky.DisplayStats();
Console.WriteLine();


