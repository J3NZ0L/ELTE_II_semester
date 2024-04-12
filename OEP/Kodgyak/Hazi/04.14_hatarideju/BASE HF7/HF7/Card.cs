using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF7
{
    public class Card
    {
        public string cNum;

        private string pin;

        public Card(string _accountNum, string _pin) { 
            this.cNum = _accountNum;
            this.pin = "1234";

        }

        public void SetPIN(string p)
        {
            this.pin = p;
        }
    }
}
