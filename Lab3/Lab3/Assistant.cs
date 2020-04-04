using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Assistant : Persona
    {
        private string sector;
        private int salary;
        private string schedule;


        public Assistant(string Sector, int Salary, string Schedule)
        {
            sector = Sector;
            salary = Salary;
            schedule = Schedule;

        }
        public string Sector { get => sector; set => sector = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Schedule { get => schedule; set => schedule = value; }





    }
   

}
