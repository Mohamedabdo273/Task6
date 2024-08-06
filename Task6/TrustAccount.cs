using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task6
{
    internal class TrustAccount : SavingsAccount
    {
        const int maxWithdrawalsPerYear = 3;
        const double maxWithdrawalPercent = 0.20;
        public List<DateTime> withdrawalDates = new List<DateTime>();
        DateTime today = DateTime.Now;
        public TrustAccount(string name = "Unnamed Trust Account", double balance = 0.0, double interestRate = 0.0)
        : base(name, balance, interestRate)
        {

        }
        public override bool Deposit(double amount)
        {
            if (amount >= 5000)
            {
                amount += 50;
            }
            return base.Deposit(amount);
        }
        
        public override bool Withdraw(double amount)
        {
           
            withdrawalDates.RemoveAll(date => date.Year < today.Year);


            if (withdrawalDates.Count >= maxWithdrawalsPerYear )
            {
                return false; 
            }

            if (amount > base.balance * maxWithdrawalPercent)
            {
                return false;
            }

            if (base.Withdraw(amount))
            {
                withdrawalDates.Add(today); 
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"[TrustAccount: {base.ToString()}, Max Withdrawals Per Year: {maxWithdrawalsPerYear}, Max Withdrawal Percent: {maxWithdrawalPercent * 100}% : Date {today}]";
        }

    }
    }
        

 

