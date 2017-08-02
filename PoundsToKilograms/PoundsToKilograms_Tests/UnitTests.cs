using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoundsToKilograms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PoundsToKilograms_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForMontana()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Montana");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor61point582()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("61.582");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative31point283()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-31.283");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor31point283()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("31.283");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2point27For5()
        {
            var expected = 2.27;

            var utility = new Utility();
            var actual = utility.GetKilograms(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns49point17For108point396()
        {
            var expected = 49.17;

            var utility = new Utility();
            var actual = utility.GetKilograms(108.396);

            Assert.AreEqual(expected, actual);
        }
    }
}
