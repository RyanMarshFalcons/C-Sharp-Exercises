using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cubed;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cubed_Tests
{
    [TestClass]
    public class UnitTesting
    {
        [TestMethod]
        public void ReturnsTrueForInt()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("9");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNotInt()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("g");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsNegative8ForNegative2()
        {
            var expected = -8;

            var utility = new Utility();
            var actual = utility.GetNumberCubed(-2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsNegative125For5()
        {
            var expected = 125;

            var utility = new Utility();
            var actual = utility.GetNumberCubed(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsNegative64For4()
        {
            var expected = 64;

            var utility = new Utility();
            var actual = utility.GetNumberCubed(4);

            Assert.AreEqual(expected, actual);
        }
    }
}