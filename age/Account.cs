using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Account
    {
        public string Id { get; set; }
        public Bank Bank { get; set; }
        public Client Client { get; set; }
        public Currency Currency { get; set; }
        public decimal Balance { get; set; }
  
        public Account(string id, Bank bank, Client client, Currency currency)
        {
             Client = client;
             Id = id;
             Bank = bank;
             Currency = currency;
        }
    }
}
