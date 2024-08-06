using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class SavingsAccount : Account
    {
        private double interestRate;

        public SavingsAccount(string name = "Unnamed  Account", double balance = 0.0, double interestRate = 0.0)
            : base(name, balance)
        {
            this.interestRate = interestRate;
        }

        

        public override string ToString()
        {
            return $"[SavingsAccount: {base.ToString()} , {interestRate}]";
        }
    }
}

