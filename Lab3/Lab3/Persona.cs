using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public abstract class Person
    {
        protected string name;
        protected string lastName;
        protected int rut;
        protected string nationality;
        protected string type;


        public Person()
        {


        }
        public string Name { get => name; set => name = value; }
        public int Rut { get => rut; set => rut = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public string Lastname { get => lastName; set => lastName = value; }
        public string Type { get => type; set => type = value; }


        public void ChangePosition(Person persona)
        {
            string new_position = persona.Type;

            Console.WriteLine("Choose a new position to" + persona.name);
            Console.WriteLine("[1]Boss \n[2]Client \n[3]");




        }

    }
}
