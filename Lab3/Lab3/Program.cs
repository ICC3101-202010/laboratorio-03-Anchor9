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
            Console.WriteLine("Manual MODE");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[1]Show product list \n[2]Show employee info \n[3]Purchase \n");


            string mode2 = Console.ReadLine();
            while (mode2 != "1" && mode != "2" && mode2 != "3" && mode2 != "4" && mode2 != "4")
            {
                Console.WriteLine("ERROR, choose a correct option");
                mode2 = Console.ReadLine();

            }

 
            Producto MART = new Producto();
            MART.MarketList();
            while (true)
            {
                if (mode2 == "1")
                {
                    MART.ShowProductInfo();
                    mode2 = Console.ReadLine();
                }




            }



         }
    }
}
