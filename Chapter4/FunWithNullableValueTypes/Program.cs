// See https://aka.ms/new-console-template for more information
using FunWithNullableValueTypes;

Console.WriteLine("**** Fun with Nullable Value Types *****\n");
DatabaseReader dr = new DatabaseReader();

// get int from "database"
int? i = dr.GetIntFromDatabase();
if (i.HasValue)
    Console.WriteLine($"Value of 'i' is: {i.Value}");
else
    Console.WriteLine("Value of 'i' is undefined.");

// get bool from "database"
bool? b = dr.GetBoolFromDatabase();
if (b != null)
    Console.WriteLine($"Value of 'b' is: {b.Value}");
else
    Console.WriteLine("Value of 'b' is undefined.");

//shorthand notation using ?? syntax
int myData = dr.GetIntFromDatabase() ?? 100;
Console.WriteLine($"Value of myData: {myData}");

//longhand notation not using ?? syntax
int? moreData = dr.GetIntFromDatabase();
if (!moreData.HasValue)
    moreData = 100;
Console.WriteLine($"Value of moreData: {moreData}");


static void LocalNullableVariables()
{
    //define some local nullable variables
    int? nullableInt = 10;
    double? nullableDouble = 3.14;
    bool? nullableBool = null;
    char? nullableChar = 'a';
    int?[] arrayOfNullableInts = new int?[10];
}

static void LocalNullableVariablesUsingNullable()
{
    //define some local nullable variables
    Nullable<int> nullableInt = 10;
    Nullable<double> nullableDouble = 3.14;
    Nullable<bool> nullableBool = null;
    Nullable<char> nullableChar = 'a';
    Nullable<int>[] arrayOfNullableInts = new int?[10];
}
