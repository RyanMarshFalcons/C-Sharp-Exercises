using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String_Longest_5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String_Longest_5_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Returns3For12345()
        {
            var expected = 5;

            var utility = new Utility();
            var actual = utility.GetLongestLength(new int[] { 1, 2, 3, 4, 5 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns16For2168715()
        {
            var expected = 16;

            var utility = new Utility();
            var actual = utility.GetLongestLength(new int[] { 2, 16, 8, 7, 15 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns203For1599812720345()
        {
            var expected = 203;

            var utility = new Utility();
            var actual = utility.GetLongestLength(new int[] { 159, 98, 127, 203, 45 });

            Assert.AreEqual(expected, actual);
        }
    }
}
