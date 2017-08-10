using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tangent;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tangent_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForNegative8point71()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("-8.71");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForhouse()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("house");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsNegative3Point38For5()
        {
            var expected = -3.38;
            var utility = new Utility();
            var actual = utility.GetTangent(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsNegativePoint42For75()
        {
            var expected = -.42;
            var utility = new Utility();
            var actual = utility.GetTangent(75);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2Point35ForNegativeOneThousandOne()
        {
            var expected = 2.35;
            var utility = new Utility();
            var actual = utility.GetTangent(-1001);

            Assert.AreEqual(expected, actual);
        }
    }
}
