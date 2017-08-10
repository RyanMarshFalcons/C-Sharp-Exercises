using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Love_Eighteen;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Love_Eighteen_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor29()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("29");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFory()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("y");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor18()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfEighteen(18, 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNo18s()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfEighteen(7, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor4and14()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfSumIsEighteen(4, 14);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor4and15()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfSumIsEighteen(4, 15);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor13and31()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDifferenceIsEighteen(13, 31);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor13and32()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDifferenceIsEighteen(13, 32);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor3and6()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfProductIsEighteen(3, 6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor3and7()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfProductIsEighteen(3, 7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor36and2()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfQuotientIsEighteen(36, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor36and3()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfQuotientIsEighteen(36, 3);

            Assert.AreEqual(expected, actual);
        }
    }
}
