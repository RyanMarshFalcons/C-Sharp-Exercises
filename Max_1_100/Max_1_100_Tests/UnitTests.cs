using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max_1_100;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Max_1_100_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor44()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("44");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForf()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("f");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor1()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfHasPower(1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor50()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfHasPower(50);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor100()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfHasPower(100);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor0()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfHasPower(0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor101()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfHasPower(101);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFoNegative50()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfHasPower(-50);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor5252()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfEqual(52, 52);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor5253()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfEqual(52, 53);

            Assert.AreEqual(expected, actual);
        }
    }
}
