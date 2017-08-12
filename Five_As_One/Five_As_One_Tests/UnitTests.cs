using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Five_As_One;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Five_As_One_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor11()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("11");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFort()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("t");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns252627282930For345678()
        {
            var expected = new int[] { 25, 26, 27, 28, 29, 30 };

            var utility = new Utility();
            var actual = utility.GetSumsOfNums(new int[] { 3, 4, 5, 6, 7, 8 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns303234363840For24681012()
        {
            var expected = new int[] { 30, 32, 34, 36, 38, 40 };

            var utility = new Utility();
            var actual = utility.GetSumsOfNums(new int[] { 2, 4, 6, 8, 10, 12 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor1234515And152930313233()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.FiveAsOnePossible(new int[] { 1, 2, 3, 4, 5, 15 }, new int[] { 15, 25, 26, 27, 28, 29});

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor24681031And305153555759()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.FiveAsOnePossible(new int[] { 2, 4, 6, 8, 10, 31 }, new int[] { 30, 51, 53, 55, 57, 59});

            Assert.AreEqual(expected, actual);
        }
    }
}
