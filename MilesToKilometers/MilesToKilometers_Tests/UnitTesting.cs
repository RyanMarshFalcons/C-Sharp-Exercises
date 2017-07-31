using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilesToKilometers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MilesToKilometers_Tests
{
    [TestClass]
    public class UnitTesting
    {
        [TestMethod]
        public void ReturnsFalseForBoston()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Boston");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor78point142()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("78.142");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative12point75()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-12.75");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor12point75()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("12.75");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns8point05For5()
        {
            var expected = 8.05;

            var utility = new Utility();
            var actual = utility.GetKilometers(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns150point65For93point612()
        {
            var expected = 150.65;

            var utility = new Utility();
            var actual = utility.GetKilometers(93.612);

            Assert.AreEqual(expected, actual);
        }
    }
}
