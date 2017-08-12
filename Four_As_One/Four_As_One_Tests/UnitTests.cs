using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Four_As_One;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Four_As_One_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor18()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("18");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFord()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("d");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns1819202122For34567()
        {
            var expected = new int[] { 18, 19, 20, 21, 22 };

            var utility = new Utility();
            var actual = utility.GetSumsOfNums(new int[] { 3, 4, 5, 6, 7 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns1618202224For13579()
        {
            var expected = new int[] { 16, 18, 20, 22, 24 };

            var utility = new Utility();
            var actual = utility.GetSumsOfNums(new int[] { 1, 3, 5, 7, 9 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor246820And2032343638()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.FourAsOnePossible(new int[] { 2, 4, 6, 8, 20 }, new int[] { 20, 32, 34, 36, 38 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor246821And2033353739()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.FourAsOnePossible(new int[] { 2, 4, 6, 8, 21 }, new int[] { 20, 33, 35, 37, 39 });

            Assert.AreEqual(expected, actual);
        }
    }
}
