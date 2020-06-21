using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BankAccountKata.Tests
{
    [TestClass]
    public class OperationFormatterTests
    {
        private IOperationFormatter operationFormatter;

        [TestInitialize]
        public void Setup()
        {
            operationFormatter = new OperationFormatter();
        }

        [TestMethod]
        public void Should_Show_The_Entire_Formatted_Operations_In_A_Descending_Order()
        {
            List<string> expectedResult = new List<string>
            {
                "Operation || Date || Amount || Balance",
                "Withdraw || 21/06/2020 || 1000,00 || 500,00",
                "Deposit || 14/06/2020 || 500,00 || 1500,00",
                "Deposit || 01/05/2020 || 1000,00 || 1000,00"
            };

            List<Operation> operations = new List<Operation>
            {
                new Operation(1000, new DateTime(2020, 05, 01), OperationType.Deposit),
                new Operation(500, new DateTime(2020, 06, 14), OperationType.Deposit),
                new Operation(1000, new DateTime(2020, 06, 21), OperationType.Withdraw),
            };

            List<string> actualResult = operationFormatter.Format(operations);

            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}
