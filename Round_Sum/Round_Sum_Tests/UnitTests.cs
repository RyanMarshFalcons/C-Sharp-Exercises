using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Round_Sum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Round_Sum_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor68()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("68");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForm()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("n");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative1()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor0()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("0");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor1()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0For4()
        {
            var expected = 0;

            var utility = new Utility();
            var actual = utility.RoundToNearestTen(4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns10For5()
        {
            var expected = 10;

            var utility = new Utility();
            var actual = utility.RoundToNearestTen(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns120For123()
        {
            var expected = 120;

            var utility = new Utility();
            var actual = utility.RoundToNearestTen(123);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns180For177()
        {
            var expected = 180;

            var utility = new Utility();
            var actual = utility.RoundToNearestTen(177);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns60For102030()
        {
            var expected = 60;

            var utility = new Utility();
            var actual = utility.SumOfNums(10, 20, 30);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns310For4090180()
        {
            var expected = 310;

            var utility = new Utility();
            var actual = utility.SumOfNums(40, 90, 180);

            Assert.AreEqual(expected, actual);
        }
    }
}
