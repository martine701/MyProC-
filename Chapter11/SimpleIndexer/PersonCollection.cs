internal class PersonCollection
{
    private Dictionary<string, Person> listPeople = new Dictionary<string, Person>();
    public Person this[string name]
    {
        get => (Person)listPeople[name];
        set => listPeople[name] = value;
    }
    public Person this[int index]
    {
        get => (Person)listPeople.ElementAt(index).Value;
        set => listPeople[listPeople.ElementAt(index).Key] = value;
    }
    public void ClearPeople()
    {
        listPeople.Clear();
    }
    public int Count => listPeople.Count;
}