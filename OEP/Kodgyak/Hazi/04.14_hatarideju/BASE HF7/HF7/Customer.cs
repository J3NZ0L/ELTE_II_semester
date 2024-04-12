using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF7
{
    internal class Customer
    {
        private string pin;
        private int withdraw=atm.Process(this);
        private List<Account> accounts;
        public Customer(string pin, int _wihtdraw)
        {
            this.pin = pin;
            this.withdraw = _wihtdraw;
            accounts = new List<Account>();
        }
        public void Withdrawal(ATM atm)
        {

        }

        public Card ProvidesCard()
        {
            return accounts[0].cards[0];
        }

        public string ProvidesPIN()
        {
            return pin;
        }

        public int RequestMoney()
        {
            return withdraw;
        }

        public void AddAccount(Account a)
        {
            accounts.Add(a);
        }
    }
}
