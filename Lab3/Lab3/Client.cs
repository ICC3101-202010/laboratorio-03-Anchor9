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
        private int purchases;

        public Client(string Name, string Lastname, string Nationality, int Rut, int Id_voucher, int Purchases, string Type)
        {

            name = Name;
            lastName = Lastname;
            nationality = Nationality;
            rut = Rut;
            type = Type;
            id_voucher = Id_voucher;
            purchases = Purchases;

        }
        public Client()
        {

        }
        public int Id_Voucher { get => id_voucher; set => id_voucher = value; }
        public int Purchases { get => purchases; set => purchases = value; }

        public List<Client> Clients = new List<Client>();

        public void ClientInfo()
        {
            Client Peter = new Client("Noah", "Jameson", "Belgium", 112435673, 000000, 0, "Client");
            Client Fiona = new Client("Peter", "Nolik", "Canada", 132123145, 000000, 0, "Client");
            Client Ester = new Client("Ester", "Araujo", "Portugal", 178994624, 000000, 0, "Client");
            Client Mark = new Client("Mark", "Riihn", "Australia", 1465113183, 000000, 0, "Client");
            Client Yuming = new Client("Yuming", "Cho", "China", 98632659, 000000, 0, "Client");
            Client Luka = new Client("Luca", "Magnota", "Croatia", 131335927, 000000, 0, "Client");
            Client Carmen = new Client("Carmen", "Gutierrez", "Mexico", 178935556, 000000, 0, "Client");


            Clients.Add(Peter);
            Clients.Add(Fiona);
            Clients.Add(Ester);
            Clients.Add(Mark);
            Clients.Add(Yuming);
            Clients.Add(Luka);
            Clients.Add(Carmen);

        }

        public void ShowClientInfo()
        {
            foreach (var client in Clients)
            {
                Console.WriteLine("NAME: " + client.Name+ "||" + "LAST NANME: " + client.Name + "||" + "NATIONALITY: " + client.Name + "||" + "RUT: " + client.Rut + "||" + "Id_voucher" + client.Id_Voucher + "||" + "PURCHASES: " + client.Purchases + "||" + "TYPE: " + client.Type);
            }
        }
        public void ShowClientName()
        {
            foreach (var client in Clients)
                Console.WriteLine("NAME: " + client.Name);


        }

        public void ChooseToBuyClient()
        {
            int cont = 1    ;
            foreach (var client in Clients)
                Console.WriteLine(cont + " " + client.Name, cont++);
            Console.WriteLine("Choose client");
            string number = Console.ReadLine();
            int final_client = Convert.ToInt32(number);

            int cont2 = 1;

            foreach (var client in Clients)
                if (final_client == cont2)
                {
                    Console.WriteLine("CLIENT["+cont2+"]" + client.Name);
                    cont2++;
                    string client_buyer = client.Name;
                    

                }
                else 
                {
                    cont2++;                
                }

            ////////////// B   U   Y //////////////////////////////

            

            {

            }
        }





    }
}
