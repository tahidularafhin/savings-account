using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_18Creating_AccountClass
{
    class Account
    {   public string AccNum { get; set; }
        public decimal StartBalnce { get; set; }
        public decimal Charges { get; set; }
        public decimal Credit { get; set; }
        public decimal CreditLimit { get; set; }

        public Account(string accNum, decimal startBalance,decimal charges,decimal credit, decimal creditLimit)
        {
            AccNum = accNum;
            StartBalnce = startBalance;
            Charges = charges;
            Credit = Credit;
            CreditLimit = creditLimit;

        }
        public decimal calculateNewBalance()
        {
            return (StartBalnce + Charges - Credit);
        }
    }
}
