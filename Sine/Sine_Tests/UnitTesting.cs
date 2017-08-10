using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sine_Tests
{
    [TestClass]
    public class UnitTesting
    {
        [TestMethod]
        public void ReturnsTrueFor6point23()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("6.23");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNotstairs()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("stairs");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsPoint14For3()
        {
            var expected = .14;
            var utility = new Utility();
            var actual = utility.GetSine(3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsNegativePoint38For452()
        {
            var expected = -.38;
            var utility = new Utility();
            var actual = utility.GetSine(452);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsPoint75For1025()
        {
            var expected = .75;
            var utility = new Utility();
            var actual = utility.GetSine(1025);

            Assert.AreEqual(expected, actual);
        }
    }
}
