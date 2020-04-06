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
        public chief()
        {

        }
        public string Position { get => position; set => position = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Schedule { get => schedule; set => schedule = value; }

        public List<chief> Chiefs = new List<chief>();

        public void ChiefsInfo()
        {
            chief Sam = new chief("Marketing", 1000000, "9:00-18:00", "Sam", "Drinkwater", "England", 169087631, "Chief");
            chief Mumad = new chief("production", 1000000, "9:00-18:00", "Munahid", "Albaan", "Lebanon", 125546753, "Chief");
            chief Clarie = new chief("Finances", 2500000, "9:00-18:00", "Clarie", "Kutarnic", "Croatia", 179092657, "Chief");

            Chiefs.Add(Sam);
            Chiefs.Add(Mumad);
            Chiefs.Add(Clarie);
        }

        public void ShowChiefInfo()
        {
            foreach (var chief in Chiefs)
            {
                Console.WriteLine("POSITION: " + chief.Position + "||" + "SALARY: " + chief.Salary + "||" + "SHCEDULE: " + chief.Schedule + "||" + "NAME: " + chief.Name + " " + chief.Lastname + "||" + "NATIONALITY: " + chief.Nationality + "||" + "RUT: " + chief.rut + "||" + "TYPE: " + chief.Type);
            }
        }

        public void AddChief(Person person)
        { 
        
        
        }

    }
}
