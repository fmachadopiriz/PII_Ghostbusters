using System;

namespace Ghostbusters
{
    public class Person
    {
        public string Name { get; }
        public string FamilyName { get; }
        public string MailAddress { get; }

        public Person(string name, string FamilyName, string mailAddress)
        {
            this.Name = name;
            this.FamilyName = FamilyName;
            this.MailAddress = mailAddress;
        }
    }
}
