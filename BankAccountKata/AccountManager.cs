using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountKata
{
    public class AccountManager : IAccountManager
    {
        private decimal _balance = 0;

        public decimal GetBalance()
        {
            return _balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException();

            _balance += amount;
        }
        
    }
}
