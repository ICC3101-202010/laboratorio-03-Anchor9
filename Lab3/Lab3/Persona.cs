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
            Console.WriteLine("Choose a new position to" + persona.name);
            Console.WriteLine("[1]Boss \n[2]Client \n[3]Supervisor \n[4]Assistant [5]Supermarket Cashier");
            string new_position = Console.ReadLine();

            if (new_position == "1")
            {
                persona.type = "Boss";
            }
            else if (new_position == "2")
            {
                persona.type = "Client";
            }
            else if (new_position == "3")
            {
                persona.type = "Supervisor";
            }
            else if (new_position == "4")
            {
                persona.type = "Assintant";
            }
            else if (new_position == "5")
            {
                persona.type = "Supermarket";
            }







        }

    }
}
