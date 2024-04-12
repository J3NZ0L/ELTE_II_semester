using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF7
{
    internal class Bank
    {
        private List<Account> accounts;

        public Bank() { 
            accounts = new List<Account>();
        }
        public void OpenAccount(string cNum, Customer c)
        {
            Account a = new Account(cNum);
            accounts.Add(a);
            c.AddAccount(a);
        }

        public void ProvidesCard(Account a)
        {
            Card c = new Card(a.accNum, "1234");
            if (accounts.Contains(a))
            {

                a.cards.Add(c);
            } 
        }

        public int GetBalance(string cNum)
        {
            (bool l, Account account) = FindAccount(cNum);
            if (l)
            {
                return account.GetBalance();
            }
            else
            {
                return -1;
            }
        }

        public void Transaction(string cNum, int amount)
        {
            (bool l, Account account) = FindAccount(cNum);
            if (l)
            {
                account.Change(amount);
            }
        }
        
        public bool CheckAccount(string cNum)
        {    
            /*
            int i = 0;
            while (i<=accounts.Count && (accounts[i].accNum!=cNum))
            {
                i++;
            }
            return i<=accounts.Count;*/
            (bool found,_)=FindAccount(cNum);
            return found;
        }

        private (bool found, Account a) FindAccount(string cNum)
        {
            int i = 0;
            while (i <= accounts.Count && (accounts[i].accNum != cNum))
            {
                i++;
            }
            return (i <= accounts.Count,accounts[i]);
        }


    }
}
