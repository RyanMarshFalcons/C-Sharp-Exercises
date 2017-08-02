using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FahrenheitToCelsius;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FahrenheitToCelsius_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForMaine()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Maine");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor74point216()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("74.216");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns32point22For90()
        {
            var expected = 32.22;

            var utility = new Utility();
            var actual = utility.GetCelsius(90);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns73point75For164point741()
        {
            var expected = 73.75;

            var utility = new Utility();
            var actual = utility.GetCelsius(164.741);

            Assert.AreEqual(expected, actual);
        }
    }
}
