using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountKata
{
    public class OperationFormatter : IOperationFormatter
    {
        private const string HEADER = "Operation || Date || Amount || Balance";

        public List<string> Format(List<Operation> operations)
        {
            List<string> formattedOperations = new List<string>();

            decimal balance = 0;
            foreach (Operation operation in operations)
            {
                if (operation.Type == OperationType.Deposit)
                    balance += operation.Amount;
                else
                    balance -= operation.Amount;

                formattedOperations.Add($"{operation.ToString()} || {String.Format("{0:0.00}", balance)}");
            }

            formattedOperations.Reverse();
            formattedOperations.Insert(0, HEADER);

            return formattedOperations;
        }
    }
}
