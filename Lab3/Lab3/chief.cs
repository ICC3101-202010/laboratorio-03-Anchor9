    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class chief : Person
    {
        private string position;
        private int salary;
        private string schedule;


        public chief(string Position, int Salary, string Schedule, string Name, string Lastname, string Nationality, int Rut, string Type)
      
        {
            position = Position;
            salary = Salary;
            schedule = Schedule;
            name = Name;
            lastName = Lastname;
            nationality = Nationality;
            rut = Rut;
            type = Type;

        }
        public string Position { get => position; set => position = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Schedule { get => schedule; set => schedule = value; }

    }
}
