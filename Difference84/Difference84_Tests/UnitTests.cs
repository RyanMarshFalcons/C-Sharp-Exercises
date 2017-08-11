using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Difference84;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Difference84_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor16()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("16");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForu()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("u");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor85()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.GreaterThan84(85);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor75()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.GreaterThan84(75);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns12For90()
        {
            var expected = 12;

            var utility = new Utility();
            var actual = utility.DifferenceTo84(90, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns14For70()
        {
            var expected = 14;

            var utility = new Utility();
            var actual = utility.DifferenceTo84(70, false);

            Assert.AreEqual(expected, actual);
        }
    }
}
