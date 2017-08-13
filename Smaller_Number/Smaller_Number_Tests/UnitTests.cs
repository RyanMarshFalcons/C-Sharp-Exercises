using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smaller_Number;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Smaller_Number_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor49()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("49");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForr()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("r");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor12And12()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfEqual(12, 12);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor13And12()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfEqual(13, 12);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns4For7And4()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.GetSmallerNumber(7, 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsNegative13ForNegative13And3()
        {
            var expected = -13;

            var utility = new Utility();
            var actual = utility.GetSmallerNumber(-13, 3);

            Assert.AreEqual(expected, actual);
        }
    }
}
