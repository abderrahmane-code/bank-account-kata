using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountKata
{
    public interface IAccountManager
    {
        decimal GetBalance();

        void Deposit(decimal amount);

        void Withdraw(decimal amount);

        List<Operation> GetOperations();
    }
}
