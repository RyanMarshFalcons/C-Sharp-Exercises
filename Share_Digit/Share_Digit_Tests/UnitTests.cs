using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Share_Digit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Share_Digit_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor724()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("724");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForf()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("f");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor501()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfBetween100And999("501");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor51()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfBetween100And999("51");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns743For743()
        {
            var expected = new int[] { 7, 4, 3 };

            var utility = new Utility();
            var actual = utility.GetDigits(743);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns381For381()
        {
            var expected = new int[] { 3, 8, 1 };

            var utility = new Utility();
            var actual = utility.GetDigits(381);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns602For602()
        {
            var expected = new int[] { 6, 0, 2 };

            var utility = new Utility();
            var actual = utility.GetDigits(602);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor378And752()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.MatchingDigits(new int[] { 3, 7, 8 }, new int[] { 7, 5, 2 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor436And361()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.MatchingDigits(new int[] { 4, 3, 6 }, new int[] { 3, 6, 1 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor275And369()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.MatchingDigits(new int[] { 2, 7, 5 }, new int[] { 3, 6, 9 });

            Assert.AreEqual(expected, actual);
        }
    }
}
