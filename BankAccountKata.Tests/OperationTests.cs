using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankAccountKata.Tests
{
    [TestClass]
    public class OperationTests
    {
        [TestMethod]
        public void Should_Be_Equal_When_Operations_Have_The_Same_Values()
        {
            Operation expectedOperation = new Operation(200, DateTime.Today, OperationType.Withdraw);

            Operation actualOperation = new Operation(200, DateTime.Today, OperationType.Withdraw);

            Assert.AreEqual(expectedOperation, actualOperation);
        }

        [TestMethod]
        public void Should_Format_Operation()
        {
            string expectedResult = "Deposit || 21/06/2020 || 200,00";

            Operation operation = new Operation(200, new DateTime(2020, 06, 21), OperationType.Deposit);

            string actualResult = operation.ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
