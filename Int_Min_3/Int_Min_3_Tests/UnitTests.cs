using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Int_Min_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Int_Min_3_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor43()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("43");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForl()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("l");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns7For798()
        {
            var expected = 7;

            var utility = new Utility();
            var actual = utility.GetMin(7, 9, 8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsNegative9ForNegative1Negative910()
        {
            var expected = -9;

            var utility = new Utility();
            var actual = utility.GetMin(-1, -9, 10);

            Assert.AreEqual(expected, actual);
        }
    }
}
