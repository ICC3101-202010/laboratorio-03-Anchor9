using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Persona
    {
        private string name;
        private string lastName;
        private int rut;
        private string nationality;


        public Persona(string Name, string Lastname, string Nationality, int Rut)
        {
            name = Name;
            lastName = Lastname;
            nationality = Nationality;
            rut = Rut;

        }
        public string Name { get => name; set => name = value; }
        public int Rut { get => rut; set => rut = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public string Lastname { get => lastName; set => lastName = value; }

    }
}
