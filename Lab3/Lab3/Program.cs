using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("W E L C O M E   T O    E - M A R T\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Choose an option \n[1] Manual\n[2] Simulation\n");
            Console.ForegroundColor = ConsoleColor.White;
            string mode = Console.ReadLine();

            while (mode != "1" && mode != "2")
            {
                Console.WriteLine("ERROR, choose a correct option");
                mode = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Magenta;

            ////////////////////////////////////////////////////////////////
            Console.WriteLine("Manual MODE\n");
            Console.ForegroundColor = ConsoleColor.White;
            
            Checker checker = new Checker();
            supervisor supervisor = new supervisor();
            Assistant assistant = new Assistant();
            Producto MART = new Producto();
            chief chiefs = new chief();
            Client client = new Client();
            Boleta boleta = new Boleta();

            List<int> unic_ID = new List<int>();
            List<Boleta> voucher_list = new List<Boleta>();

            client.ClientInfo();
            assistant.AssistantInfo();
            chiefs.ChiefsInfo();
            MART.MarketList();
            supervisor.SupervisorInfo();
            checker.CheckersInfo();

            /////////////////////////////////////////////////////////////////////////////
            while (true)
            {
                
                Console.WriteLine("Main menu, choose an option\n");
                Console.WriteLine("[1]Show product list \n[2]Show employee info \n[3]Purchase \n[4]See purchases \n[5]Options \n[0]EXIT");
                string mode2 = Console.ReadLine();
                while (mode2 != "1" && mode2 != "2" && mode2 != "3" && mode2 != "4" && mode2 != "4" && mode2 != "5")
                {
                    Console.WriteLine("ERROR, choose a correct option");
                    mode2 = Console.ReadLine();

                }
                if (mode2 == "1")
                {
                    MART.ShowProductInfo();
                    continue;
                }
                else if (mode2 == "2")
                {
                    Console.WriteLine("[1]Chief \n[2]Assistant \n[3]Supervisor \n[4]Checker \n[0]EXIT");
                    string mode3 = Console.ReadLine();

                    if (mode3 == "1") //CHIEF
                    {
                        chiefs.ShowChiefInfo();
                        continue;
                    }
                    else if (mode3 == "2") //ASSISTANT
                    {
                        assistant.ShowAsisstantInfo();
                    }
                    else if (mode3 == "3") //SUPERVISOR
                    {
                        supervisor.ShowSupervisorInfo();

                    }
                    else if (mode3 == "4") // CHECKER
                    {
                        checker.ShowCheckerInfo();
                    }
                    else if (mode3 == "0") // EXIT
                    {
                        continue;
                    }

                }
                else if (mode2 == "3") //PURCHASE
                {

                    Console.WriteLine("Choose a client");
                    client.ShowClientName();
                    string client_chosen = Console.ReadLine();
                    List<Producto> shoppingCart = new List<Producto>();
                    
                    // B U Y
                    MART.BUY(shoppingCart);

                    Console.WriteLine("Choose a cheker");
                    checker.ShowCheckerName();
                    string checker_chosen = Console.ReadLine();


                    //GENERATING VOUCHER
                    DateTime start = new DateTime(2020, 1, 1);
                    int range = (DateTime.Today - start).Days;

                    Random random = new Random();
                    string checker_Name;
                    int total = MART.Total_Amount(shoppingCart);
                    
                    int ID = random.Next(1000, 9999);
                    while (unic_ID.Contains(ID))
                    {
                        ID = random.Next(1000, 9999);
                    }
                    checker_Name = checker.SelectChecker(checker_chosen);
                    DateTime buyDate = start.AddDays(random.Next(range));
                    string strID = Convert.ToString(ID);

                    Boleta new_voucher = new Boleta(strID, client_chosen, buyDate, total, checker_Name);
                    boleta.ADDvoucher(voucher_list, new_voucher);

                    Console.WriteLine("Thanks to visit US");

                }

                else if (mode2 == "4") //SEE PURCHASES
                {
                    boleta.ShowPurchases(voucher_list);
                }
                else if (mode2 == "5") //OPTIONS
                {

                }

                else if (mode2 == "0") //EXIT
                {
                    continue;
                }








            }



         }
    }
}
