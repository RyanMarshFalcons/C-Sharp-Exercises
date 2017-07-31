using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Subtraction;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Subtraction_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseFormouse()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("mouse");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor4point36()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("4.36");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns16For24And8()
        {
            var expected = 16;

            var utility = new Utility();
            var actual = utility.GetDifference(24, 8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns86For100And14()
        {
            var expected = 86;

            var utility = new Utility();
            var actual = utility.GetDifference(100, 14);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsNegative3point4For7point9And11point3()
        {
            var expected = -3.4;

            var utility = new Utility();
            var actual = utility.GetDifference(7.9, 11.3);

            Assert.AreEqual(expected, actual);
        }
    }
}
