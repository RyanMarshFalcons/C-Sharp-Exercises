using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Love_Twenty_Four;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Love_Twenty_Four_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor33()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("33");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForz()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("z");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor24()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTwentyFour(24, 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNo24s()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTwentyFour(7, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor10and14()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfSumIsTwentyFour(10, 14);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor10and15()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfSumIsTwentyFour(10, 15);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor7and31()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDifferenceIsTwentyFour(7, 31);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor7and32()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDifferenceIsTwentyFour(7, 32);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor4and6()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfProductIsTwentyFour(4, 6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor4and7()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfProductIsTwentyFour(4, 7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor48and2()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfQuotientIsTwentyFour(48, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor36and3()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfQuotientIsTwentyFour(48, 3);

            Assert.AreEqual(expected, actual);
        }
    }
}
