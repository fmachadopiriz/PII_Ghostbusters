//--------------------------------------------------------------------------------------
// <copyright file="CorporateMailMessage.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------------
using System;

namespace Ghostbusters
{
    // Esta clase sucesora del tipo genérico MailMessage con Employee como argumento del tipo parámetro hace más
    // concreta la clase MailMessage para que el mensaje a cualqueir Person sea sólo mensajes a Employee.
    public class CorporateMailMessage : MailMessage<Employee>
    {
        public CorporateMailMessage(string subject, string sender, Employee employee)
        : base(subject, sender, employee)
        {
            // Intencionalmente en blanco
        }

        public override string Header
        {
            get
            {
                return $"Estimada/o {this.To.Name} {this.To.FamilyName}";
            }
        }
    }
}