using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Squirrel_Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Squirrel_Party_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor19()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("19");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForc()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("c");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative3()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-3");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor3()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("3");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor65()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.EnoughNuts(65);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor45()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.EnoughNuts(45);

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
        public void ReturnsFalseForH()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfABCDEFG("H");

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
        public void ReturnsTrueForGWeekend()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsWeekEnd("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForIWeekend()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsWeekEnd("I");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SuccessForEnoughNutsEnoughSodasAndIsWeekend()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsSuccessful(true, true, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SuccessForEnoughNutsNotEnoughSodasAndIsWeekend()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsSuccessful(true, false, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SuccessForEnoughNutsEnoughSodasAndIsNotWeekend()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsSuccessful(true, true, false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FailureForEnoughNutsNotEnoughSodasAndIsNotWeekend()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsSuccessful(true, false, false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SuccessForNotEnoughNutsEnoughSodasAndIsWeekend()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsSuccessful(false, true, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SuccessForNotEnoughNutsNotEnoughSodasAndIsWeekend()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsSuccessful(false, false, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FailureForNotEnoughNutsEnoughSodasAndIsNotWeekend()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsSuccessful(false, true, false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FailureForNotEnoughNutsNotEnoughSodasAndIsNotWeekend()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsSuccessful(false, false, false);

            Assert.AreEqual(expected, actual);
        }
    }
}
