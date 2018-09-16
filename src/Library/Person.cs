//-------------------------------------------------------------------------
// <copyright file="Person.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System;

namespace Ghostbusters
{
    public class Person
    {
        public Person(string name, string familyName, string mailAddress)
        {
            this.Name = name;
            this.FamilyName = familyName;
            this.MailAddress = mailAddress;
        }

        public string Name { get; }

        public string FamilyName { get; }

        public string MailAddress { get; }
    }
}
