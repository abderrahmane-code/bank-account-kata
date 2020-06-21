using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountKata
{
    public interface IOperationFormatter
    {
        List<string> Format(List<Operation> operations);
    }
}
