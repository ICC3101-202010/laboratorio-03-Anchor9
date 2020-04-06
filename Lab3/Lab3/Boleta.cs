using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Boleta
    {
        private string id;
        private string buyer;
        private DateTime date;
        private int amount;
        private List<Boleta> voucher_list;
        private string checker;

        public string Id { get => id; set => id = value; }
        public string Buyer { get => buyer; set => buyer = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Amount { get => amount; set => amount = value; }
        public string Checker { get => checker; set => checker = value; }

        public List<Boleta> Voucher_List { get => voucher_list; set => voucher_list = value; }


        public void ShowVoucherInfo(Boleta boleta)
        {
            Console.WriteLine("ID:" + boleta.Id + "PURCHASER:" + boleta.buyer + "DATE:" + boleta.buyer + "AMOUNT:" + boleta.amount + "CHECKER:" + boleta.checker);
            
        }













    }

}
