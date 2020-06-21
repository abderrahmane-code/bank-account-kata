using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountKata
{
    public class Account
    {
        private IAccountManager _accountManager;

        public Account(IAccountManager accountManager)
        {
            _accountManager = accountManager;
        }

        public decimal GetBalance()
        {
            return _accountManager.GetBalance();
        }

        public void Deposit(decimal amount)
        {
            _accountManager.Deposit(amount);
        }

        public void Withdraw(decimal amount)
        {
            _accountManager.Withdraw(amount);
        }
    }
}
