//-----------------------------------------------------------------------------
// <copyright file="MailMessage.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-----------------------------------------------------------------------------
using System;

namespace Ghostbusters
{
    // MailMessage es un tipo genérico y el tipo parámetro T puede ser una persona de tipo Person o cualquier sucesor.
    // Además al ser una clase abstracta es necesario que haya un sucesor conreto para poder crear instancias de else
    // sucesor.
    public abstract class MailMessage<T>
        where T : Person
    {
        private string body;

        public MailMessage(string subject, string senderAddress, T to)
        {
            this.Subject = subject;
            this.SenderAddress = senderAddress;
            this.To = to;
        }

        public string Subject { get; }

        public string SenderAddress { get; }

        // La persona de tipo Person o cualquier sucesor a la que se envía este mensaje.
        public T To { get; }

        public abstract string Header { get; }

        // El cuerpo del mensaje de correo no es el contenido completo; la propiedad es de sólo escritura para que
        // no se pueda usar el cuerpo como contenido del correo a enviar.
        public string Body
        {
            set
            {
                this.body = value;
            }
        }

        // El contenido del mensaje de correo es el encabezado y el cuerpo; la propiedad es de sólo lectura  para
        // asegurar que el contenido tiene siempre ese formato.
        public string Content
        {
            get
            {
                return $"{this.Header}\n{this.body}";
            }
        }
    }
}