using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Love_Number;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Love_Number_Tests
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
        public void ReturnsTrueFor343()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLoveNum(3, 4, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor345()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLoveNum(3, 4, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor8917()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfSumIsLoveNum(8, 9, 17);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor8916()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfSumIsLoveNum(8, 9, 16);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor871()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDifferenceIsLoveNum(8, 7, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor861()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDifferenceIsLoveNum(8, 6, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor3515()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfProductIsLoveNum(3, 5, 15);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor4515()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfProductIsLoveNum(4, 5, 15);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor1226()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfQuotientIsLoveNum(12, 2, 6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor1236()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfQuotientIsLoveNum(12, 3, 6);

            Assert.AreEqual(expected, actual);
        }
    }
}
