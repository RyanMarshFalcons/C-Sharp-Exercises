using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Make_Bricks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Make_Bricks_Tests
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
        public void ReturnsFalseForl()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("l");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor0inches()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("0");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor1inch()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNegative1brick()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidNum("-1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor0bricks()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidNum("0");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor18222()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPossible(18, 2, 2, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor18222()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPossible(18, 1, 2, 2);

            Assert.AreEqual(expected, actual);
        }
    }
}
