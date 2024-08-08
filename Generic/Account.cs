using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Account
    {
        public Account(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }

        public bool Deposit(double amount)
        {
            Balance += amount;
            return true;
        }

        public override bool Equals(object? obj)
        {
            Account account = (Account)obj;
            return this.Id == account.Id;
        }
    }
}
