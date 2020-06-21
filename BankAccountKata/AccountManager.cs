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
        private List<Operation> _operations = new List<Operation>();

        public decimal GetBalance()
        {
            return _balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException();

            _balance += amount;
            _operations.Add(new Operation(amount, DateTime.Today, OperationType.Deposit));
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException();

            _balance -= amount;
            _operations.Add(new Operation(amount, DateTime.Today, OperationType.Withdraw));
        }

        public List<Operation> GetOperations()
        {
            return _operations;
        }
    }
}
