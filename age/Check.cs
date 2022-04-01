using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Check
    {
        public int TransactionNumber { get; set; }
        public DateTime TransactionDate { get; set; }
        public Bank BankName { get; set; }
        public string AccountID { get; set; }
        public decimal Balance { get; set; }
        public Check()
        {
            Random random = new Random();
            TransactionNumber = random.Next(10000, 99999);
            TransactionDate = DateTime.Now;
            BankName = BankName;
            AccountID = "1231";
            Console.WriteLine(TransactionNumber);
            Console.WriteLine(TransactionDate);
            Console.WriteLine(BankName);
            Console.WriteLine(AccountID);
        }

    }
}
