using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Assistant : Person
    {
        private string sector;
        private int salary;
        private string schedule;


        public Assistant(string Sector, int Salary, string Schedule, string Name, string Lastname, string Nationality, int Rut, string Type)
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

    
        public Assistant() 
        {
        
        }
        public string Sector { get => sector; set => sector = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Schedule { get => schedule; set => schedule = value; }

        public List<Assistant> Assistants = new List<Assistant>();

        public void AssistantInfo()
        {
            Assistant Ellie = new Assistant("A1", 400000, "8:30-17:00", "Ellie", "Meer", "England", 169087631, "Assistant");
            Assistant Krisna = new Assistant("A3", 5000000, "8:30-17:00", "Krisna", "Jones", "England", 125546753, "Assistant");
            Assistant Marta = new Assistant("B3", 500000, "8:30-17:00", "Marta", "Gonzalez", "Chile", 179092657, "Assistant");
            Assistant Norman = new Assistant("E2", 455000, "8:30-17:00", "Norman", "Reedus", "U.S", 179092657, "Assistant");
            Assistant William = new Assistant("Cellar", 600000, "8:30-17:00", "William", "Sean", "U.S", 179092657, "Assistant");

            Assistants.Add(Ellie);
            Assistants.Add(Krisna);
            Assistants.Add(Marta);
            Assistants.Add(Norman);
            Assistants.Add(William);
        }

        public void ShowAsisstantInfo()
        {
            foreach (var assistant in Assistants)
            {
                Console.WriteLine("POSITION: " + assistant.Sector + "||" + "SALARY: " + assistant.Salary + "||" + "SHCEDULE: " + assistant.Schedule + "||" + "NAME: " + assistant.Name + " " + assistant.Lastname + "||" + "NATIONALITY: " + assistant.Nationality + "||" + "RUT: " + assistant.rut + "||" + "TYPE: " + assistant.Type);
            }

        }

        public void AddAssistant(Person person)
        {


        }




    }
   

}
