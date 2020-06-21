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

        public override string ToString()
        {
            string type = (this.Type == OperationType.Deposit) ? "Deposit" : "Withdraw";
            string date = this.Date.ToString("dd/MM/yyyy");
            string amount = String.Format("{0:0.00}", this.Amount);

            return $"{type} || {date} || {amount}";
        }

    }
}
