using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class supervisor : Person
    {
        public string sector;
        private int salary;
        private string schedule;

        public supervisor(string Sector, int Salary, string Schedule, string Name, string Lastname, string Nationality, int Rut, string Type)

        {
            sector = Sector;
            salary = Salary;
            schedule = Schedule;
            name = Name;
            lastName = Lastname;
            nationality = Nationality;
            rut = Rut;
            type = Type;
        }


        public string Sector { get => sector; set => sector = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Schedule { get => schedule; set => schedule = value; }

        public List<supervisor> Supervisors = new List<supervisor>();

        public void SupervisorInfo()
        {
            supervisor Sam = new supervisor("A1", 500000, "9:00-18:00", "Klrak", "Drinkwater", "E", 169087631, "Supervisor");
            supervisor Mumad = new supervisor("C4", 600000, "9:00-18:00", "Camila", "Albaan", "Panama", 125546753, "Supervisorf");
            supervisor Clarie = new supervisor("L7", 450000, "9:00-18:00", "Eugenia", "Kutarnic", "Colombia", 179092657, "Supervisor");

            Supervisors.Add(Sam);
            Supervisors.Add(Sam);
            Supervisors.Add(Sam);


        }
        public void ShowChiefInfo()
        {
            foreach (var supervisor in Supervisors)
            {
                Console.WriteLine("POSITION:" + supervisor.Sector + "||" + "SALARY:" + supervisor.Salary + "||" + "SHCEDULE:" + supervisor.Schedule + "||" + "NAME: " + supervisor.Name + supervisor.Lastname + "||" + "NATIONALITY" + supervisor.Nationality + "||" + "RUT" + supervisor.rut + "||" + "TYPE" + supervisor.Type);
            }



        }

    }







}
