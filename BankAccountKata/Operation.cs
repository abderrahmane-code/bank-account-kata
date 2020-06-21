using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountKata
{
    public class Operation
    {
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public OperationType Type{ get; set; }

        public Operation(decimal amount, DateTime date, OperationType type)
        {
            Amount = amount;
            Date = date;
            Type = type;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            Operation operation = obj as Operation;

            return this.Amount == operation.Amount
                && this.Date == operation.Date
                && this.Type == operation.Type;
        }

    }
}
