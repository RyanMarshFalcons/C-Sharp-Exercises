using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max_Block;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Max_Block_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForEmptyString()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForG()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3Foraaabbccddeeaa()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.FindLongestBlock("aaabbccddeeaa");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns5Foraaabbeecceeeddeeeee()
        {
            var expected = 5;

            var utility = new Utility();
            var actual = utility.FindLongestBlock("aaabbeecceeeddeeeee");

            Assert.AreEqual(expected, actual);
        }
    }
}
