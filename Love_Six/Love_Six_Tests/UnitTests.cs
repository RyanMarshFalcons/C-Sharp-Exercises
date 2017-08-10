using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Love_Six;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Love_Six_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor13()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("13");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForp()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("p");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor6()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfSix(6, 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNo6s()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfSix(7, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor4and2()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfSumIsSix(4, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor4and3()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfSumIsSix(4, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor7and1()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDifferenceIsSix(7, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor7and2()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDifferenceIsSix(7, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor3and2()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfProductIsSix(3, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor3and1()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfProductIsSix(3, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor12and2()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfQuotientIsSix(12, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor12and3()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfQuotientIsSix(12, 3);

            Assert.AreEqual(expected, actual);
        }
    }
}
