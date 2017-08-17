using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String_Longest_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String_Longest_4_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Returns3For1234()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.GetLongestLength(new int[] { 1, 2, 3, 4 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns15For101786()
        {
            var expected = 17;

            var utility = new Utility();
            var actual = utility.GetLongestLength(new int[] { 10, 17, 8, 6 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns168For16898127153()
        {
            var expected = 168;

            var utility = new Utility();
            var actual = utility.GetLongestLength(new int[] { 168, 98, 127, 153 });

            Assert.AreEqual(expected, actual);
        }
    }
}
