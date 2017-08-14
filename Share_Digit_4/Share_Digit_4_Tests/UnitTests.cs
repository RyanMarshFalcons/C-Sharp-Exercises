using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Share_Digit_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Share_Digit_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor7245()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("7245");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForh()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("h");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor5012()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfBetween1000And9999("5012");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor512()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfBetween1000And9999("512");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns7437For7437()
        {
            var expected = new int[] { 7, 4, 3, 7 };

            var utility = new Utility();
            var actual = utility.GetDigits(7437);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3816For3816()
        {
            var expected = new int[] { 3, 8, 1, 6 };

            var utility = new Utility();
            var actual = utility.GetDigits(3816);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns6029For6029()
        {
            var expected = new int[] { 6, 0, 2, 9 };

            var utility = new Utility();
            var actual = utility.GetDigits(6029);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor3784And7529()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.MatchingDigits(new int[] { 3, 7, 8, 4 }, new int[] { 7, 5, 2, 9 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor4367And3612()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.MatchingDigits(new int[] { 4, 3, 6, 7 }, new int[] { 3, 6, 1, 2 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor2758And3691()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.MatchingDigits(new int[] { 2, 7, 5, 8 }, new int[] { 3, 6, 9, 1 });

            Assert.AreEqual(expected, actual);
        }
    }
}
