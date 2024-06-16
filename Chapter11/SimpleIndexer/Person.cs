internal class Person
{
    private string v1;
    private string v2;
    private int v3;

    public string Name { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Notes { get; set; }
    public int Age { get; set; }
    public Person(string name, string address, string phone, string email, string notes)
    {
        Name = name;
        Address = address;
        Phone = phone;
        Email = email;
        Notes = notes;
    }
    public Person()
    {
    }

    public Person(string v1, string v2, int v3)
    {
        this.Name = v1;
        this.LastName = v2;
        this.Age = v3;
    }

    public override string ToString()
    {
        return Name;
    }
}