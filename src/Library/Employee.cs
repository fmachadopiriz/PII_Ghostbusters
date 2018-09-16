//--------------------------------------------------------------------------
// <copyright file="Employee.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------
using System;

namespace Ghostbusters
{
    public class Employee : Person
    {
        public Employee(string name, string familyName, string mail, string id, int age)
        : base(name, familyName, mail)
        {
            this.ID = id;
            this.Age = age;
        }

        public string ID { get; }

        public int Age { get; }
    }
}