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
            var expected = true;
            var evaluation = new Evaluation();

            var actual = evaluation.Zero(0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IdentifiesNegativeNumberInputs()
        {
            var expected = true;
            var evaluation = new Evaluation();

            var actual = evaluation.Negative(-1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IdentifiesEmptyStringInputs()
        {
            var expected = true;
            var evaluation = new Evaluation();

            var actual = evaluation.Empty("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IdentifiesIfNotAnInt()
        {
            var expected = true;
            var evaluation = new Evaluation();

            var actual = evaluation.NotAnInt("4.7");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IdentifiesIfNotADecimal()
        {
            var expected = true;
            var evaluation = new Evaluation();

            var actual = evaluation.NotADecimal("notADecimal");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsQUARTER25DIME10PENNY03()
        {
            var expected = "[QUARTER, 0.25][DIME, 0.10][PENNY, 0.03]";

            var cashRegister = new CashRegister();
            var testDictionary = new Dictionary<string, decimal>() { { "ONE HUNDRED", 300.00M }, { "TWENTY", 60.00M }, { "TEN", 30.00M }, { "FIVE", 15.00M }, { "ONE", 3.00M }, { "QUARTER", 0.75M }, { "DIME", 0.30M }, { "NICKEL", 0.15M }, { "PENNY", 0.03M } };
            var actual = cashRegister.GiveProperChange(0.38M, testDictionary);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTEN10FIVE5QUARTER75PENNY01()
        {
            var expected = "[TEN, 10.00][FIVE, 5.00][QUARTER, 0.75][PENNY, 0.01]";

            var cashRegister = new CashRegister();
            var testDictionary = new Dictionary<string, decimal>() { { "ONE HUNDRED", 300.00M }, { "TWENTY", 60.00M }, { "TEN", 30.00M }, { "FIVE", 15.00M }, { "ONE", 3.00M }, { "QUARTER", 0.75M }, { "DIME", 0.30M }, { "NICKEL", 0.15M }, { "PENNY", 0.03M } };
            var actual = cashRegister.GiveProperChange(15.76M, testDictionary);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsQUARTER50()
        {
            string expected = "[QUARTER, 0.50]";

            var cashRegister = new CashRegister();
            var testDictionary = new Dictionary<string, decimal>() { { "ONE HUNDRED", 100.00M }, { "TWENTY", 60.00M }, { "TEN", 20.00M }, { "FIVE", 55.00M }, { "ONE", 90.00M }, { "QUARTER", 4.25M }, { "DIME", 3.10M }, { "NICKEL", 2.05M }, { "PENNY", 1.01M } };
            var actual = cashRegister.GiveProperChange(0.50M, testDictionary);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsInsufficientFunds()
        {
            string expected = "Insufficient Funds";

            var cashRegister = new CashRegister();
            var testDictionary = new Dictionary<string, decimal>() { { "ONE HUNDRED", 0M }, { "TWENTY", 0M }, { "TEN", 0M }, { "FIVE", 0M }, { "ONE", 0M }, { "QUARTER", 0M }, { "DIME", 0M }, { "NICKEL", 0M }, { "PENNY", 0.01M } };
            var actual = cashRegister.checkCashRegister(0.50M, testDictionary);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsSufficientFunds()
        {
            var expected = "Sufficient Funds";

            var cashRegister = new CashRegister();
            var testDictionary = new Dictionary<string, decimal>() { { "ONE HUNDRED", 0M }, { "TWENTY", 0M }, { "TEN", 0M }, { "FIVE", 0M }, { "ONE", 0M }, { "QUARTER", 3M }, { "DIME", 0M }, { "NICKEL", 0M }, { "PENNY", 0.01M } };
            var actual = cashRegister.checkCashRegister(0.50M, testDictionary);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsPENNY50()
        {
            var expected = "Closed";

            var cashRegister = new CashRegister();
            var testDictionary = new Dictionary<string, decimal>() { { "ONE HUNDRED", 0M }, { "TWENTY", 0M }, { "TEN", 0M }, { "FIVE", 0M }, { "ONE", 0M }, { "QUARTER", 0M }, { "DIME", 0M }, { "NICKEL", 0M }, { "PENNY", 0.50M } };
            var actual = cashRegister.checkCashRegister(0.50M, testDictionary);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTWENTY60TEN20FIVE15ONE1QUARTER50DIME20PENNY04()
        {
            var expected = "[TWENTY, 60.00][TEN, 20.00][FIVE, 15.00][ONE, 1.00][QUARTER, 0.50][DIME, 0.20][PENNY, 0.04]";

            var cashRegister = new CashRegister();
            var testDictionary = new Dictionary<string, decimal>() { { "ONE HUNDRED", 100.00M }, { "TWENTY", 60.00M }, { "TEN", 20.00M }, { "FIVE", 55.00M }, { "ONE", 90.00M }, { "QUARTER", 4.25M }, { "DIME", 3.10M }, { "NICKEL", 2.05M }, { "PENNY", 1.01M } };
            var actual = cashRegister.GiveProperChange(96.74M, testDictionary);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnInsufficientFundsDueToWrongDenominations()
        {
            var expected = "Insufficient Funds";

            var cashRegister = new CashRegister();
            var testDictionary = new Dictionary<string, decimal>() { { "ONE HUNDRED", 0M }, { "TWENTY", 0M }, { "TEN", 0M }, { "FIVE", 0M }, { "ONE", 1.00M }, { "QUARTER", 0M }, { "DIME", 0M }, { "NICKEL", 0M }, { "PENNY", 0.01M } };
            var actual = cashRegister.GiveProperChange(0.50M, testDictionary);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForValidDecimal()
        {
            var Expected = true;

            var evaluation = new Evaluation();
            var Actual = evaluation.IsAValidDecimal("19.57");

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void ReturnsFalseForInvalidDecimal()
        {
            var Expected = false;

            var evaluation = new Evaluation();
            var Actual = evaluation.IsAValidDecimal("nonsense");

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void IdentifiesAValidDecimal()
        {
            var expected = InputType.Valid;

            var evaluation = new Evaluation();
            var actual = evaluation.GetInputTypeForDecimal("74.51");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IdentifiesNotDecimal()
        {
            var expected = InputType.NotADecimal;

            var evaluation = new Evaluation();
            var actual = evaluation.GetInputTypeForDecimal("kablamajam");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IdentifiesEmptyNotDecimal()
        {
            var expected = InputType.Empty;

            var evaluation = new Evaluation();
            var actual = evaluation.GetInputTypeForDecimal("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IdentifiesAcceptableDecimal()
        {
            var expected = InputType.Valid;

            var evaluation = new Evaluation();
            var actual = evaluation.HaveValidDecimal("12.95");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IdentifiesAZeroDecimal()
        {
            var expected = InputType.Zero;

            var evaluation = new Evaluation();
            var actual = evaluation.HaveValidDecimal("0.00");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IdentifiesANegativeDecimal()
        {
            var expected = InputType.Negative;

            var evaluation = new Evaluation();
            var actual = evaluation.HaveValidDecimal("-12.95");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IdentifiesADecimalWithTrailing()
        {
            var expected = InputType.TooManyTrailingDigits;

            var evaluation = new Evaluation();
            var actual = evaluation.HaveValidDecimal("12.955");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForValidInt()
        {
            var Expected = true;

            var evaluation = new Evaluation();
            var Actual = evaluation.IsAValidInt("7");

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void ReturnsFalseForInvalidInt()
        {
            var Expected = false;

            var evaluation = new Evaluation();
            var Actual = evaluation.IsAValidInt("-7");

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void IdentifiesValidInt()
        {
            var expected = InputType.Valid;

            var evaluation = new Evaluation();
            var actual = evaluation.GetInputTypeForInt("4");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IdentifiesEmptyInt()
        {
            var expected = InputType.Empty;

            var evaluation = new Evaluation();
            var actual = evaluation.GetInputTypeForInt("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IdentifiesNotAnInt()
        {
            var expected = InputType.NotAnInt;

            var evaluation = new Evaluation();
            var actual = evaluation.GetInputTypeForInt("Kaibeau");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IdentifiesAcceptableInt()
        {
            var ExpecectedType = InputType.Valid;

            var evaluation = new Evaluation();
            var actual = evaluation.HaveValidInt("3");

            Assert.AreEqual(ExpecectedType, actual);
        }

        [TestMethod]
        public void IdentifiesNegativeInt()
        {
            var ExpecectedType = InputType.Negative;

            var evaluation = new Evaluation();
            var actual = evaluation.HaveValidInt("-3");

            Assert.AreEqual(ExpecectedType, actual);
        }

        [TestMethod]
        public void IdentifiesIfMoreThanTwoTrailingDigits()
        {
            var expected = true;
            var evaluation = new Evaluation();

            var actual = evaluation.TooManyTrailingDigits(4.789M);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns1CentForAPenny()
        {
            var expected = 0.01m;

            var cashRegister = new CashRegister();
            var actual = cashRegister.GetTotalOfCashInDrawer(new Dictionary<string, decimal>() { { "ONE HUNDRED", 0.00M }, { "TWENTY", 0.00M }, { "TEN", 0.00M }, { "FIVE", 0.00M }, { "ONE", 0.00M }, { "QUARTER", 0.00M }, { "DIME", 0.00M }, { "NICKEL", 0.00M }, { "PENNY", 0.01M } });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns41CentsForAPennyANickelADimeAndAQuarter()
        {
            var expected = 0.41m;

            var cashRegister = new CashRegister();
            var actual = cashRegister.GetTotalOfCashInDrawer(new Dictionary<string, decimal>() { { "ONE HUNDRED", 0.00M }, { "TWENTY", 0.00M }, { "TEN", 0.00M }, { "FIVE", 0.00M }, { "ONE", 0.00M }, { "QUARTER", 0.25M }, { "DIME", 0.10M }, { "NICKEL", 0.05M }, { "PENNY", 0.01M } });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns136Dollars41CentsForAPennyANickelADimeAQuarterAOneAFiveATenATwentyAndAHundred()
        {
            var expected = 136.41m;

            var cashRegister = new CashRegister();
            var actual = cashRegister.GetTotalOfCashInDrawer(new Dictionary<string, decimal>() { { "ONE HUNDRED", 100.00M }, { "TWENTY", 20.00M }, { "TEN", 10.00M }, { "FIVE", 5.00M }, { "ONE", 1.00M }, { "QUARTER", 0.25M }, { "DIME", 0.10M }, { "NICKEL", 0.05M }, { "PENNY", 0.01M } });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns409Dollars23CentsFor3Pennies3Nickels3Dimes3Quarters3Ones3Fives3Tens3TwentiesAnd3Hundreds()
        {
            var expected = 409.23m;

            var cashRegister = new CashRegister();
            var actual = cashRegister.GetTotalOfCashInDrawer(new Dictionary<string, decimal>() { { "ONE HUNDRED", 300.00M }, { "TWENTY", 60.00M }, { "TEN", 30.00M }, { "FIVE", 15.00M }, { "ONE", 3.00M }, { "QUARTER", 0.75M }, { "DIME", 0.30M }, { "NICKEL", 0.15M }, { "PENNY", 0.03M } });

            Assert.AreEqual(expected, actual);
        }
    }
}
