using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankAccountKata.Tests
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void Should_Have_0_As_Balance_When_Account_Is_Newly_Created()
        {
            decimal expectedBalance = 0;
            Account account = new Account();

            decimal actualBalance = account.Balance;

            Assert.AreEqual(expectedBalance, actualBalance);
        }
    }
}
