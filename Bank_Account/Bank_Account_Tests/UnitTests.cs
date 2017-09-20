using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Account;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bank_Account_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void AIsAValidSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BIsAValidSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CIsAValidSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DIsAValidSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EIsNotAValidSelection()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AIsForDeposit()
        {
            var expected = Selection.Deposit;

            var utility = new Utility();
            var actual = utility.ConvertLetterToSelection("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BIsForWithdrawal()
        {
            var expected = Selection.Withdrawal;

            var utility = new Utility();
            var actual = utility.ConvertLetterToSelection("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CIsForCheckBalance()
        {
            var expected = Selection.CheckBalance;

            var utility = new Utility();
            var actual = utility.ConvertLetterToSelection("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DIsForCloseAccount()
        {
            var expected = Selection.CloseAccount;

            var utility = new Utility();
            var actual = utility.ConvertLetterToSelection("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForhog()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("hog");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor19point79()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("19.79");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNegative5()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("-5");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor5()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("5");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddsDeposit()
        {
            var expected = 72.39;

            var utility = new Utility();
            var actual = utility.GetNewBalance(57.35, 15.04, Selection.Deposit);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractsWithdrawal()
        {
            var expected = 42.31;

            var utility = new Utility();
            var actual = utility.GetNewBalance(57.35, 15.04, Selection.Withdrawal);

            Assert.AreEqual(expected, actual);
        }
    }
}
