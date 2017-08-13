using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Table;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Restaurant_Table_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor26()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("26");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFork()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("k");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNegative5()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfWithinRange("-5");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor5()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfWithinRange("5");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor8()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.FashionableEnough(8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor7()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.FashionableEnough(7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForA()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfABCDEFG("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForB()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfABCDEFG("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForC()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfABCDEFG("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForD()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfABCDEFG("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForE()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfABCDEFG("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForF()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfABCDEFG("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForG()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfABCDEFG("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForP()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfABCDEFG("P");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForEWeekend()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsWeekEnd("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForFWeekend()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsWeekEnd("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForGWeekend()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsWeekEnd("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForTrueTrueFalse()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.GetTable(true, true, false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForTrueTrueTrue()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.GetTable(true, true, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForTrueFalseFalse()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.GetTable(true, false, false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForFalseTrueFalse()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.GetTable(false, true, false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForFalseFalseTrue()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.GetTable(false, false, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForTrueFalseTrue()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.GetTable(true, false, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForFalseTrueTrue()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.GetTable(false, true, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForFalseFalseFalse()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.GetTable(false, false, false);

            Assert.AreEqual(expected, actual);
        }


    }
}
