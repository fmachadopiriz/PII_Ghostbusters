//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Security;
using Ghostbusters;

namespace Program
{
    public class Program
    {
        private const string FromName = "Fernando Machado"; // Reemplazar por tu nombre

        private const string ReceiverMailToTest = "fernando.machado@gmail.com"; // A esta dirección llegan las pruebas

        private static List<Customer> customers = new List<Customer>();

        private static List<Employee> employees = new List<Employee>();

        public static void Main(string[] args)
        {
            CreateCustomers();
            CreateEmployees();

            Console.Write("Usuario: ");
            string fromMail = Console.ReadLine();
            string password = PasswordReader.ReadPassword("Contraseña: ", '%');

            MailSender mailSender = new MailSender(fromMail, password);

            SendMailToCustomers(fromMail, mailSender);
            SendMailToEmployees(fromMail, mailSender);
        }

        private static void CreateCustomers()
        {
            customers.Add(new Customer("Maria", "González", ReceiverMailToTest, "Cornelio Cantera 1234"));
            customers.Add(new Customer("Juan", "Pérez", ReceiverMailToTest, "Av. 8 de Octubre 2738"));
        }

        private static void CreateEmployees()
        {
            employees.Add(new Employee("José", "Martínez", ReceiverMailToTest, "12345678-9", 30));
            employees.Add(new Employee("Andrea", "Hernández", ReceiverMailToTest, "9876543-2", 25));
        }

        private static void SendMailToCustomers(string fromMail, MailSender mailSender)
        {
            CustomerMailMessage mail;
            foreach (Customer customer in customers)
            {
                mail = new CustomerMailMessage("Oferta imperdible", FromName, customer);
                mail.Body = "Visite nuestra página para ver las ofertas de la semana";
                Console.Write($"Enviando mensaje a {customer.Name} {customer.FamilyName}... ");
                bool sent = mailSender.EnviarMail(fromMail, FromName, mail.To.MailAddress, mail.Subject, mail.Content);
                Console.WriteLine(sent ? "enviado." : "no enviado.");
            }
        }

        private static void SendMailToEmployees(string fromMail, MailSender mailSender)
        {
            CorporateMailMessage mail;
            foreach (Employee employee in employees)
            {
                mail = new CorporateMailMessage("Feliz cumpleaños", FromName, employee);
                mail.Body = "La empresa te desea feliz cumpleaños";
                Console.Write($"Enviando mensaje a {employee.Name} {employee.FamilyName}... ");
                bool sent = mailSender.EnviarMail(fromMail, FromName, mail.To.MailAddress, mail.Subject, mail.Content);
                Console.WriteLine(sent ? "enviado." : "no enviado.");
            }
        }
    }
}
