using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class BankAccount
    { 

        public BankAccount(int budget)
        {
            Budget = budget;
        }


        public int Budget { get; set; }

        public void NeemGeldOp(int bedrag)
        {
            Budget -= bedrag;
        }
     
    }
}
