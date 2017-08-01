using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InchesToCentimeters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InchesToCentimeters_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForKentucky()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Kentucky");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor76point42()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("76.42");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative51point78()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-51.78");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor51point78()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("51.78");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns43point18For17()
        {
            var expected = 43.18;

            var utility = new Utility();
            var actual = utility.GetCentimeters(17);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns208point93For82point256()
        {
            var expected = 208.93;

            var utility = new Utility();
            var actual = utility.GetCentimeters(82.256);

            Assert.AreEqual(expected, actual);
        }
    }
}
