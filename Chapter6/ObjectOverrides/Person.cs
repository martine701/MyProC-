using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    internal class Person
    {
        public string SSN { get; set; }
        public string FirstName { get; set; } = "Mikael";
        public string LastName { get; set; } = "Waltersson";
        public int Age { get; set; } = 25;
        public int Birthday { get; set;
        } = 1996;
        public int Month { get; set; }
        public int Day { get; set; }
        public Person() { }
        public Person(string fName, string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }
        public Person(string sSN, string firstName, string lastName, int age)
        {
            SSN = sSN;
            FirstName = firstName;
            LastName = lastName;
            Age = age;            
        }

        public Person(string fName, string lName, int personAge, int year, int month, int day)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
            Birthday = year;
            Month = month;
            Day = day;
        }
        public override string ToString()
        {
            string myState;
            myState = string.Format("[First Name: {0}; Last Name: {1}; Age: {2}; Birthday: {3}/{4}/{5}]", FirstName, LastName, Age, Birthday, Month, Day);
            return myState;
        }

        public override bool Equals(object obj)
        {
            if (obj is Person && obj != null)
            {
                Person temp;
                temp = (Person)obj;
                if (temp.FirstName == this.FirstName
                                   && temp.LastName == this.LastName
                                                  && temp.Age == this.Age
                                                                 && temp.Birthday == this.Birthday
                                                                                && temp.Month == this.Month
                                                                                               && temp.Day == this.Day)
                {
                    return true;
                }
            }
            return false;
        }

        //public override int GetHashCode() => SSN.GetHashCode();
        
    }
}
