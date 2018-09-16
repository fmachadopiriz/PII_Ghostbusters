//--------------------------------------------------------------------------
// <copyright file="Customer.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------
using System;

namespace Ghostbusters
{
    public class Customer : Person
    {
        public Customer(string name, string familyName, string mail, string postalAddress)
        : base(name, familyName, mail)
        {
            this.PostalAddress = postalAddress;
        }

        public string PostalAddress { get; }
    }
}