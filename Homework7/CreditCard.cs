using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public class CreditCard
    {
        string numberAccount;
        decimal moneyAccount;
        public CreditCard()
        {
            numberAccount = "Unknown account";
            moneyAccount = 0;
        }
        public CreditCard(string numberAccount, decimal moneyAccount)
        {
            this.numberAccount = numberAccount;
            this.moneyAccount = moneyAccount;
        }

        public void DepositMoney(decimal sum)
        {
            moneyAccount += sum;
        }

        public void WithdrawMoney(decimal sum)
        {
            moneyAccount -= sum;
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Uccount:{numberAccount}, Balance:{moneyAccount}");
        }
    }
}
