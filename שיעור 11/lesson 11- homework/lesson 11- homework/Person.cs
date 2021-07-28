using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_11__homework
{
    class Person
    {
        readonly int iD;
        private string name;
        private double phone;
        private  int numberOfPersons = 0;

        public Person(string name, double phone)
        {
            this.name = name;
            this.phone = phone;
            numberOfPersons++;
            iD = numberOfPersons;
        }
        public static void ChangeName(Person person,string name)
        {
            person.name = name;
        }
        public static void ChangePhone(Person person, int phone)
        {
            person.phone = phone;
        }

    }
}
