using System;

namespace Ghostbusters
{
    public class Customer : Person
    {
        public string PostalAddress { get; }

        public Customer(string name, string FamilyName, string mail, string postalAddress)
        : base(name, FamilyName, mail)
        {
            this.PostalAddress = postalAddress;
        }
    }
}