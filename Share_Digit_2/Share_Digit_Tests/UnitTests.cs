using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Share_Digit_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Share_Digit_Tests
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
        public void ReturnsFalseFore()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("e");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor50()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfBetween10And99("50");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor5()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfBetween10And99("5");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns74For74()
        {
            var expected = new int[] { 7, 4 };

            var utility = new Utility();
            var actual = utility.GetDigits(74);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns38For38()
        {
            var expected = new int[] { 3, 8 };

            var utility = new Utility();
            var actual = utility.GetDigits(38);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns60For60()
        {
            var expected = new int[] { 6, 0 };

            var utility = new Utility();
            var actual = utility.GetDigits(60);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor27And75()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.MatchingDigits(new int[] { 2, 7 }, new int[] { 7, 5 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor43And36()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.MatchingDigits(new int[] { 4, 3 }, new int[] { 3, 6 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor27And36()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.MatchingDigits(new int[] { 2, 7 }, new int[] { 3, 6 });

            Assert.AreEqual(expected, actual);
        }
    }
}
