using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KilometersToMiles;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KilometersToMiles_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForArizona()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Arizona");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor128point453()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("128.453");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative3()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-3");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor3()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("3");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3point01For4point85()
        {
            var expected = 3.01;

            var utility = new Utility();
            var actual = utility.GetMiles(4.85);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns54point53For87point7253()
        {
            var expected = 54.53;

            var utility = new Utility();
            var actual = utility.GetMiles(87.7523);

            Assert.AreEqual(expected, actual);
        }
    }
}
