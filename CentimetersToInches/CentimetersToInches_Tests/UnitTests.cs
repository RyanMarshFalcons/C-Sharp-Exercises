using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentimetersToInches;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CentimetersToInches_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForAlaska()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Alaska");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor44point55()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("44.55");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative11point487()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-11.487");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor11point487()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("11.487");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3point15For8()
        {
            var expected = 3.15;

            var utility = new Utility();
            var actual = utility.GetInches(8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns40point38For102point564()
        {
            var expected = 40.38;

            var utility = new Utility();
            var actual = utility.GetInches(102.564);

            Assert.AreEqual(expected, actual);
        }
    }
}
