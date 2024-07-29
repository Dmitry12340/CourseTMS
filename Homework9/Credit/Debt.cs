using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9.Credit
{
    internal class Debt
    {
        private double balance;
        private double InterestRate;
        public Debt(double initialBalance, double initialInterestRate)
        {
            balance = initialBalance;
            InterestRate = initialInterestRate;
        }
        public void PrintBalance()
        {
            Console.WriteLine($"Balance = {balance}");
        }
        public void WaitOneYear()
        {
            balance = balance * InterestRate;
        }
    }
}
