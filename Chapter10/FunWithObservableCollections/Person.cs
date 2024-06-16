namespace FunWithObservableCollections
{
    internal class Person

    {
        public Person()
        {

        }
        public Person(string fName, string lName, int a)
        {
            FirstName = fName;
            LastName = lName;
            Age = a;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Age: {Age}";
        }
    }
}

