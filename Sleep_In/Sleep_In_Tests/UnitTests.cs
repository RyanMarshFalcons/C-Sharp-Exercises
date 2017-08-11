﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sleep_In;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sleep_In_Tests
{
    [TestClass]
    public class UnitTests
    {
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
        public void ReturnsTrueFory()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("y");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForn()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("n");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForz()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("z");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForIsWeekendIsVacation()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CanSleepIn(true, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForIsWeekendIsNotVacation()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CanSleepIn(true, false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForIsNotWeekendIsVacation()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CanSleepIn(false, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForIsNotWeekendIsNotVacation()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CanSleepIn(false, false);

            Assert.AreEqual(expected, actual);
        }
    }
}
