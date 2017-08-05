using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringSum_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Returns2468()
        {
            var expected = new List<int>() { 2, 4, 6, 8 };

            var utility = new Utility();
            var actual = utility.ExtractNumberCharacters("abc2def4ghi6jk8mno");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns13779()
        {
            var expected = new List<int>() { 1, 3, 7, 7, 9 };

            var utility = new Utility();
            var actual = utility.ExtractNumberCharacters("gibb1erish3and77stuff9");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns20()
        {
            var expected = 20;

            var utility = new Utility();
            var actual = utility.GetSum(new List<int>() { 2, 4, 6, 8 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns27()
        {
            var expected = 27;

            var utility = new Utility();
            var actual = utility.GetSum(new List<int>() { 1, 3, 7, 7, 9 });

            Assert.AreEqual(expected, actual);
        }
    }
}
