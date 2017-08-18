using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max_1_1000;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Max_1_1000_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor785()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("785");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForq()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("q");

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
        public void ReturnsTrueFor500()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfHasPower(500);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor1000()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfHasPower(1000);

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
        public void ReturnsFalseFor1001()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfHasPower(1001);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFoNegative500()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfHasPower(-500);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor523523()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfEqual(523, 523);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor523524()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfEqual(523, 524);

            Assert.AreEqual(expected, actual);
        }
    }
}
