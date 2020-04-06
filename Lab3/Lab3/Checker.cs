using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Checker : Person
    {
        private int box;
        private int salary;
        private string schedule;


        public Checker(int Box, int Salary, string Schedule, string Name, string Lastname, string Nationality, int Rut, string Type)
        {
            box = Box;
            salary = Salary;
            schedule = Schedule;
            name = Name;
            lastName = Lastname;
            nationality = Nationality;
            rut = Rut;
            type = Type;

        }
        public Checker()
        {

        }
        public int Box { get => box; set => box = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Schedule { get => schedule; set => schedule = value; }

        public List<Checker> Checkers = new List<Checker>();

        public void CheckersInfo()
        {
            Checker Antonie = new Checker(1, 1000000, "9:00-17:00", "Anotnie", "Belanguer", "France", 1345674311, "Checker");
            Checker Francesco = new Checker(2, 1000000, "9:00-17:00", "Francesco", "Auditore", "Italy", 123444567, "Checker");
            Checker Andrej = new Checker(3, 2500000, "9:00-17:00", "Andrej", "Linc  ", "Serbia", 174651398, "Checker");
            Checker Vladimir = new Checker(4, 1000000, "9:00-17:00", "Vladimir", "Mirknov", "Rusia", 156734518, "Checker");
            Checker Alexandra = new Checker(5, 1000000, "9:00-17:00", "Alexandra", "Klirt", "Rusia", 193755923, "Checker");
            Checker Murat = new Checker(6, 2500000, "9:00-17:00", "Murat", "Zhinr", "Turkey", 164623718, "Checker");

            Checkers.Add(Antonie);
            Checkers.Add(Francesco);
            Checkers.Add(Andrej);
            Checkers.Add(Vladimir);
            Checkers.Add(Alexandra);
            Checkers.Add(Murat);
        }

        public void ShowCheckerInfo()
        {
            foreach (var checker in Checkers)
            {
                Console.WriteLine("BOX: " + checker.Box + "||" + "SALARY: " + checker.Salary + "||" + "SHCEDULE: " + checker.Schedule + "||" + "NAME: " + checker.Name + " " + checker.Lastname + "||" + "NATIONALITY: " + checker.Nationality + "||" + "RUT: " + checker.rut + "||" + "TYPE: " + checker.Type);
            }

        }

    }
}
