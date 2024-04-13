using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF7
{
    internal class Center
    {
        private List<Bank> banks;
        
        public Center(List<Bank> _banks) { 
            this.banks = _banks;
        }
        public int GetBalance(string cNum)
        {
            (bool l, Bank bank) = FindBank(cNum);
            if (l)
            {
                return bank.GetBalance(cNum);
            }
            else
            {
                return -1;
            }
        }

        public void Transaction(string cNum, int amount)
        {
            (bool l, Bank bank) = FindBank(cNum);
            if (l)
            {
                bank.Transaction(cNum, amount);
            }
        }

        private (bool l, Bank? bank) FindBank(string cNum)
        {
            int i = 0;
            Bank currentBank = banks[i];
            while (i<=banks.Count && !currentBank.CheckAccount(cNum))
            {
                i++;
            }
            if (i <= banks.Count)
            {
                return (true, currentBank);
            }
            else
            {
                return (false, null);
            }

            
        }
    }
}
