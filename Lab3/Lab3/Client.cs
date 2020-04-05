using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Client : Person
    {
        private int id_voucher;

        public Client(string Name, string Lastname, string Nationality, int Rut, string Type, int Id_voucher)
        {

            name = Name;
            lastName = Lastname;
            nationality = Nationality;
            rut = Rut;
            type = Type;
            id_voucher = Id_voucher;

        }



    }
}
