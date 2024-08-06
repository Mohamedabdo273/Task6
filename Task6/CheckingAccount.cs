using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class CheckingAccount : Account
    {
        const double withdrawalFee = 1.50;
        public CheckingAccount(string name = "Unnamed Account", double balance = 0.0)
        : base(name, balance)
        {
        }
        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount + withdrawalFee);
        }
        public override string ToString()
        {
            return $"[CheckingAccount: {base.ToString()}]";
        }

    }
}
