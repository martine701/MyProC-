using System.Collections.ObjectModel;
using System.Collections.Specialized;
using FunWithObservableCollections;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Fun with Observable Collections ****");
ObservableCollection<Person> people = new ObservableCollection<Person>()
{
    new Person{FirstName = "Peter", LastName = "Murphy", Age = 52},
    new Person{FirstName = "Kevin", LastName = "Key", Age = 48}
};

people.CollectionChanged += people_CollectionChanged;

people.Add(new Person { FirstName = "Sally", LastName = "Smith", Age = 30});
people.RemoveAt(0);


void people_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
{
    Console.WriteLine($"Action for this event: {e.Action}");
    if (e.Action == NotifyCollectionChangedAction.Remove)
    {
        Console.WriteLine("Here are the OLD items:");
        foreach (Person p in e.OldItems)
        {
            Console.WriteLine(p.ToString());
        }
        Console.WriteLine();
    }
    if (e.Action == NotifyCollectionChangedAction.Add)
    {
        Console.WriteLine("Here are the NEW items:");
        foreach (Person p in e.NewItems)
        {
            Console.WriteLine(p.ToString());
        }
        Console.WriteLine();
    }
}