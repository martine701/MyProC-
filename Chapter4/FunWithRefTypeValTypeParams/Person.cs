using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithRefTypeValTypeParams
{
    class Person
    {
        public string personName;
        public int personAge;

        public Person(string name, int age)
        {
            personName = name;
            personAge = age;
        }

        public void Display()
        {
            Console.WriteLine(string.Format("Name: {0}, Age: {1}", personName, personAge));
        }
    }
}
