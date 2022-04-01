using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Card
    {
        public string Number { get; set; }  
        public Bank Bank { get; set; }
        public string CVV  { get; set; }
        public DateTime ValidTrue { get; set; }
        public Client User { get; set; }
        public PaymentType PaymentType { get; set; }
        public Account Account { get; set; }
        public Card (string number, Bank bank, string cvv, Client user, DateTime validTrue, PaymentType paymentType, Account account)
        {
            Number = number;
            Bank = bank;
            CVV = cvv;
            ValidTrue = validTrue;
            PaymentType = paymentType;
            User = user;
            Account = account;
        }
        public Check Withdraw(decimal value)
        {
            if (Account.Balance < value) return null;
            Account.Balance -= value;
            return new Check();
        }
        public Check Refill(decimal value)
        {
            if (Account.Balance < value) return null;
            Account.Balance += value;
            return new Check();
        }
    }

}
