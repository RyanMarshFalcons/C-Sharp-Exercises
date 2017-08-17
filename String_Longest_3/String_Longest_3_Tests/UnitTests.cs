using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String_Longest_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String_Longest_3_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Returns3For123()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.GetLongestLength(new int[] { 1, 2, 3 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns15For10158()
        {
            var expected = 15;

            var utility = new Utility();
            var actual = utility.GetLongestLength(new int[] { 10, 15, 8 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns159For15998127()
        {
            var expected = 159;

            var utility = new Utility();
            var actual = utility.GetLongestLength(new int[] { 159, 98, 127 });

            Assert.AreEqual(expected, actual);
        }
    }
}
