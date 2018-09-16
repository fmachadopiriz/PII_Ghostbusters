//--------------------------------------------------------------------------------
// <copyright file="PasswordReader.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------
using System;

namespace Ghostbusters
{
    public class PasswordReader
    {
        public static string ReadPassword()
        {
            return ReadPassword("*");
        }

        public static string ReadPassword(string prompt)
        {
            Console.Write(prompt);
            return ReadPassword();
        }

        public static string ReadPassword(string prompt, char mask)
        {
            Console.Write(prompt);
            return ReadPassword(mask);
        }

        public static string ReadPassword(char mask)
        {
            string pass = String.Empty;
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                // Backspace shoud not work
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    pass += key.KeyChar;
                    Console.Write(mask);
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                    {
                        pass = pass.Substring(0, pass.Length - 1);
                        Console.Write("\b \b");
                    }
                }
            }
            while (key.Key != ConsoleKey.Enter); // Stops receving keys once enter is pressed

            Console.WriteLine();

            return pass;
        }
    }
}