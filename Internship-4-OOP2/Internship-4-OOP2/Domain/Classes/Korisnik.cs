﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_4_OOP2.Domain.Classes
{
    public abstract class Korisnik
    {
        private int id = 0;
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }

        public Korisnik(string name, string email)
        {
            Id = id++;
            Name = name;
            Email = email;
        }
    }
}
