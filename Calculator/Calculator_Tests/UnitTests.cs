using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForC()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative3point14()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("-3.14");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForPlusSign()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfOperator("+");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForMinusSign()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfOperator("-");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForTimesSign()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfOperator("*");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForDividedSign()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfOperator("/");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForPercentageSign()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfOperator("%");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns9For4Plus5()
        {
            var expected = 9;

            var utility = new Utility();
            var actual = utility.GetSum(4, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsNegative1For4Minus5()
        {
            var expected = -1;

            var utility = new Utility();
            var actual = utility.GetDifference(4, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns20For4Times5()
        {
            var expected = 20;

            var utility = new Utility();
            var actual = utility.GetProduct(4, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0Point8For4DividedBy5()
        {
            var expected = 0.8;

            var utility = new Utility();
            var actual = utility.GetQuotient(4, 5);

            Assert.AreEqual(expected, actual);
        }
    }
}
