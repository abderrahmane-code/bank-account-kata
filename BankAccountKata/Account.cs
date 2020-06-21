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
        private IOperationFormatter _operationFormatter;

        public Account(IAccountManager accountManager, IOperationFormatter operationFormatter)
        {
            _accountManager = accountManager;
            _operationFormatter = operationFormatter;
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

        public List<String> GetOperations()
        {
            List<Operation> operations = _accountManager.GetOperations();
            return _operationFormatter.Format(operations);
        }
    }
}
