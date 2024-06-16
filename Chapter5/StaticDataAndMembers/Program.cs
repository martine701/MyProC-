// See https://aka.ms/new-console-template for more information
using StaticDataAndMembers;

Console.WriteLine("**** Fun with Static Data ****");
SavingsAccount s1 = new SavingsAccount(50);
SavingsAccount s2 = new SavingsAccount(100);
// Print the current interest rate.
Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
// Try to change the interest rate via property.
SavingsAccount.SetInterestRate(0.08);
// Make a new object, this does NOT reset interest rate.
SavingsAccount s3 = new SavingsAccount(10000.75);
Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());


TimeUtilClass.PrintDate();
TimeUtilClass.PrintTime();


Console.ReadLine();

