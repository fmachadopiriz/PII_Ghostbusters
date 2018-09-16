//-------------------------------------------------------------------------------------
// <copyright file="CustomerMailMessage.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------------
using System;

namespace Ghostbusters
{
    // Esta clase sucesora del tipo genérico MailMessage con Customer como argumento del tipo parámetro hace más
    // concreta la clase MailMessage para que el mensaje a cualqueir Person sea sólo mensajes a Customer.
    public class CustomerMailMessage : MailMessage<Customer>
    {
        public CustomerMailMessage(string subject, string sender, Customer customer)
        : base(subject, sender, customer)
        {
            // Intencionalmente en blanco
        }

        public override string Header
        {
            get
            {
                return $"Estimada/o cliente {this.To.Name} {this.To.FamilyName}";
            }
        }
    }
}