using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Love_Thirty;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Love_Thirty_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor8()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("8");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForb()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("b");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor30()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfThirty(30, 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNo30s()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfThirty(7, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor16and14()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfSumIsThirty(16, 14);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor16and15()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfSumIsThirty(16, 15);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor31and1()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDifferenceIsThirty(31, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor31and2()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDifferenceIsThirty(31, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor5and6()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfProductIsThirty(5, 6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor5and7()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfProductIsThirty(5, 7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor90and3()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfQuotientIsThirty(90, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor91and3()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfQuotientIsThirty(90, 4);

            Assert.AreEqual(expected, actual);
        }
    }
}
