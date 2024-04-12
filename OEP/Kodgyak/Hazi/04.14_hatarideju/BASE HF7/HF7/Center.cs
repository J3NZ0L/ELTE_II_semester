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
    }
}
