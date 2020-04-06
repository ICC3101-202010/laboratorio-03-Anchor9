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
        public supervisor()
        {

        }

        public string Sector { get => sector; set => sector = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Schedule { get => schedule; set => schedule = value; }

        public List<supervisor> Supervisors = new List<supervisor>();

        public void SupervisorInfo()
        {
            supervisor Nethan = new supervisor("Food", 700000, "9:00-18:00", "Nethan", "Swersch", "Sweeden", 163567631, "Supervisor");
            supervisor Camila = new supervisor("Technology", 650000, "9:00-18:00", "Camila", "Lartues", "Panama", 112034943, "Supervisorf");
            supervisor Eugenia = new supervisor("Home&Deco", 800000, "9:00-18:00", "Eugenia", "Montes", "Colombia", 117888982, "Supervisor");

            Supervisors.Add(Nethan);
            Supervisors.Add(Camila);
            Supervisors.Add(Eugenia);


        }
        public void ShowSupervisorInfo()
        {
            foreach (var supervisor in Supervisors)
            {
                Console.WriteLine("POSITION:" + supervisor.Sector + "||" + "SALARY:" + supervisor.Salary + "||" + "SHCEDULE:" + supervisor.Schedule + "||" + "NAME: " + supervisor.Name + supervisor.Lastname + "||" + "NATIONALITY" + supervisor.Nationality + "||" + "RUT" + supervisor.rut + "||" + "TYPE" + supervisor.Type);
            }



        }

    }







}
