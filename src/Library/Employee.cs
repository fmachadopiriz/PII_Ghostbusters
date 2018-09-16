using System;

namespace Ghostbusters
{
    public class Employee : Person
    {
        public string ID { get; }

        public int Age { get; }

        public Employee(string name, string FamilyName, string mail, string id, int age)
        : base(name, FamilyName, mail)
        {
            this.ID = id;
            this.Age = age;
        }
    }
}