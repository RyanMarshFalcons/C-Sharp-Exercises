using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CelsiusToFahrenheit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CelsiusToFahrenheit_Tests
{
    [TestClass]
    public class UnitTesting
    {
        [TestMethod]
        public void ReturnsFalseForConnecticut()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Connecticut");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor14point295()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("14.295");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns64point4For18()
        {
            var expected = 64.4;

            var utility = new Utility();
            var actual = utility.GetFahrenheit(18);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns209point97For98point872()
        {
            var expected = 209.97;

            var utility = new Utility();
            var actual = utility.GetFahrenheit(98.872);

            Assert.AreEqual(expected, actual);
        }
    }
}
