using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class NietGenoegGeldException : Exception
    {
        public NietGenoegGeldException():base("Er is niet genoeg geld op het account!")
        {
            
        }
    }
    internal class BankAccount
    { 

        public BankAccount(int budget)
        {
            Budget = budget;
        }


        public int Budget { get; set; }

        public void NeemGeldOp(string bedragString)
        {
            int bedrag = int.Parse(bedragString);
            if(bedrag > Budget)
            {
                throw new NietGenoegGeldException();
            }
            Budget -= bedrag;
        }
     
    }
}
