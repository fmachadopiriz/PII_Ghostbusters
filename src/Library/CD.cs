//-------------------------------------------------------------------------
// <copyright file="CD.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System;

namespace Ghostbusters
{
    public class CD
    {
        public CD(string name, string genre, int year, string artist, string[] songs)
        {
            this.Name = name;
            this.Genre = genre;
            this.Year = year;
            this.Artist = artist;
            this.Songs = songs;
        }

        public string Name { get; }

        public string Genre { get; }

        public int Year { get; }

        public string Artist { get; }

        public string[] Songs { get; }
    }
}