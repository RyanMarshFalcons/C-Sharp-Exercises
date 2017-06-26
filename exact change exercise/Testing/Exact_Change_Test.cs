using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exact_Change;
using StartUp;


namespace Testing
{
    [TestClass]
    public class Exact_Change_Test
    {
        [TestMethod]
        public void IdentifiesInputsOfZero()
        {
            bool ExpectedType = true;
            var testVer = new Verification();

            bool ActualType = testVer.Zero(0);

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void IdentifiesNegativeNumberInputs()
        {
            bool ExpectedType = true;
            var testVer = new Verification();

            bool ActualType = testVer.Negative(-1);

            Assert.AreEqual(ExpectedType, ActualType);
        }  

        [TestMethod]
        public void IdentifiesEmptyStringInputs()
        {
            bool ExpectedType = true;
            var testVer = new Verification();

            bool ActualType = testVer.Empty("");

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void IdentifiesIfNotAnInt()
        {
            bool ExpectedType = true;
            var testVer = new Verification();

            bool ActualType = testVer.NotAnInt("4.7");

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void IdentifiesIfNotADecimal()
        {
            bool ExpectedType = true;
            var testVer = new Verification();

            bool ActualType = testVer.NotADecimal("notADecimal");

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void IdentifiesIfMoreThanTwoTrailingDigits()
        {
            bool ExpectedType = true;
            var testVer = new Verification();

            bool ActualType = testVer.TooManyTrailingDigits(4.789M);

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void ReturnsQUARTER25DIME10PENNY03()
        {
            string ExpectedType = "[QUARTER, 0.25][DIME, 0.1][PENNY, 0.03]";

            CashRegister cashRegister = new CashRegister();
            Dictionary<string, decimal> testDictionary = new Dictionary<string, decimal>() { { "ONE HUNDRED", 300.00M }, { "TWENTY", 60.00M }, { "TEN", 30.00M }, { "FIVE", 15.00M }, { "ONE", 3.00M }, { "QUARTER", 0.75M }, { "DIME", 0.30M }, { "NICKEL", 0.15M }, { "PENNY", 0.03M } };
            string ActualType = cashRegister.checkCashRegister(0.62M, 1.00M, testDictionary);

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void ReturnsTEN10FIVE5QUARTER75PENNY01()
        {
            string ExpectedType = "[TEN, 10][FIVE, 5][QUARTER, 0.75][PENNY, 0.01]";

            CashRegister cashRegister = new CashRegister();
            Dictionary<string, decimal> testDictionary = new Dictionary<string, decimal>() { { "ONE HUNDRED", 300.00M }, { "TWENTY", 60.00M }, { "TEN", 30.00M }, { "FIVE", 15.00M }, { "ONE", 3.00M }, { "QUARTER", 0.75M }, { "DIME", 0.30M }, { "NICKEL", 0.15M }, { "PENNY", 0.03M } };
            string ActualType = cashRegister.checkCashRegister(84.24M, 100.00M, testDictionary);

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void ReturnsQUARTER50()
        {
            string ExpectedType = "[QUARTER, 0.50]";

            CashRegister cashRegister = new CashRegister();
            Dictionary<string, decimal> testDictionary = new Dictionary<string, decimal>() { { "ONE HUNDRED", 100.00M }, { "TWENTY", 60.00M }, { "TEN", 20.00M }, { "FIVE", 55.00M }, { "ONE", 90.00M }, { "QUARTER", 4.25M }, { "DIME", 3.10M }, { "NICKEL", 2.05M }, { "PENNY", 1.01M }};
            string ActualType = cashRegister.checkCashRegister(19.50M, 20.00M, testDictionary);

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void ReturnsInsufficientFunds()
        {
            string ExpectedType = "Insufficient Funds";

            CashRegister cashRegister = new CashRegister();
            Dictionary<string, decimal> testDictionary = new Dictionary<string, decimal>() { { "ONE HUNDRED", 0M }, { "TWENTY", 0M }, { "TEN", 0M }, { "FIVE", 0M }, { "ONE", 0M }, { "QUARTER", 0M }, { "DIME", 0M }, { "NICKEL", 0M }, { "PENNY", 0.01M } };
            string ActualType = cashRegister.checkCashRegister(19.50M, 20.00M, testDictionary);

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void ReturnsPENNY50()
        {
            string ExpectedType = "Closed";

            CashRegister cashRegister = new CashRegister();
            Dictionary<string, decimal> testDictionary = new Dictionary<string, decimal>() { { "ONE HUNDRED", 0M }, { "TWENTY", 0M }, { "TEN", 0M }, { "FIVE", 0M }, { "ONE", 0M }, { "QUARTER", 0M }, { "DIME", 0M }, { "NICKEL", 0M }, { "PENNY", 0.50M } };
            string ActualType = cashRegister.checkCashRegister(19.50M, 20.00M, testDictionary);

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void ReturnsTWENTY60TEN20FIVE15ONE1QUARTER50DIME20PENNY04()
        {
            string ExpectedType = "[TWENTY, 60][TEN, 20][FIVE, 15][ONE, 1][QUARTER, 0.50][DIME, 0.2][PENNY, 0.04]";

            CashRegister cashRegister = new CashRegister();
            Dictionary<string, decimal> testDictionary = new Dictionary<string, decimal>() { { "ONE HUNDRED", 100.00M }, { "TWENTY", 60.00M }, { "TEN", 20.00M }, { "FIVE", 55.00M }, { "ONE", 90.00M }, { "QUARTER", 4.25M }, { "DIME", 3.10M }, { "NICKEL", 2.05M }, { "PENNY", 1.01M } };
            string ActualType = cashRegister.checkCashRegister(3.26M, 100.00M, testDictionary);

            Assert.AreEqual(ExpectedType, ActualType);
        }

        [TestMethod]
        public void ReturnInsufficientFundsDueToWrongDenominations()
        {
            string ExpectedType = "Insufficient Funds";

            CashRegister cashRegister = new CashRegister();
            Dictionary<string, decimal> testDictionary = new Dictionary<string, decimal>() { { "ONE HUNDRED", 0M }, { "TWENTY", 0M }, { "TEN", 0M }, { "FIVE", 0M }, { "ONE", 1.00M }, { "QUARTER", 0M }, { "DIME", 0M }, { "NICKEL", 0M }, { "PENNY", 0.01M } };
            string ActualType = cashRegister.checkCashRegister(19.50M, 20.00M, testDictionary);

            Assert.AreEqual(ExpectedType, ActualType);
        }
    }
}
