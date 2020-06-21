using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BankAccountKata.Tests
{
    [TestClass]
    public class AccountTests
    {

        private IAccountManager accountManager;
        private IOperationFormatter operationFormatter;
        private Account account;

        [TestInitialize]
        public void Setup()
        {
            accountManager = new AccountManager();
            operationFormatter = new OperationFormatter();
            account = new Account(accountManager, operationFormatter);
        }

        [TestMethod]
        public void Should_Have_0_As_Balance_When_Account_Is_Newly_Created()
        {
            decimal expectedBalance = 0;

            decimal actualBalance = account.GetBalance();

            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod]
        public void Should_Throw_Argument_Exception_When_Deposited_Amount_Is_Negative()
        {
            decimal amount = -30;

            Assert.ThrowsException<ArgumentException>(() => account.Deposit(amount));
        }

        [TestMethod]
        public void Should_Throw_Argument_Exception_When_Deposited_Amount_Is_0()
        {
            decimal amount = 0;

            Assert.ThrowsException<ArgumentException>(() => account.Deposit(amount));
        }

        [TestMethod]
        public void Should_Have_An_Increased_Balance_After_A_Deposit()
        {
            decimal expectedBalance = 100;

            account.Deposit(100);
            decimal actualBalance = account.GetBalance();

            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod]
        public void Should_Throw_Argument_Exception_When_Withdrawn_Amount_Is_Negative()
        {
            decimal amount = -30;

            Assert.ThrowsException<ArgumentException>(() => account.Withdraw(amount));
        }

        [TestMethod]
        public void Should_Throw_Argument_Exception_When_Withdrawn_Amount_Is_0()
        {
            decimal amount = 0;

            Assert.ThrowsException<ArgumentException>(() => account.Withdraw(amount));
        }

        [TestMethod]
        public void Should_Have_A_Decreased_Balance_After_A_Withdraw()
        {
            decimal expectedBalance = -100;

            account.Withdraw(100);
            decimal actualBalance = account.GetBalance();

            Assert.AreEqual(expectedBalance, actualBalance);
        }
        
    }
}
