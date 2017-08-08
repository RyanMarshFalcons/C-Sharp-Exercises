using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Remainder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Remainder_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor17()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("17");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForL()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("L");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns1For10And3()
        {
            var expected = 1;

            var utility = new Utility();
            var actual = utility.GetRemainder(10, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2or8And3()
        {
            var expected = 2;

            var utility = new Utility();
            var actual = utility.GetRemainder(8, 3);

            Assert.AreEqual(expected, actual);
        }
    }
}
