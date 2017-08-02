using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OuncesToGrams;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OuncesToGrams_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForLouisiana()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Louisiana");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor88point452()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("88.452");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative2point158()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-2.158");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor2point158()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("2.158");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns85point05For3()
        {
            var expected = 85.05;

            var utility = new Utility();
            var actual = utility.GetGrams(3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns509point75For17point981()
        {
            var expected = 509.75;

            var utility = new Utility();
            var actual = utility.GetGrams(17.981);

            Assert.AreEqual(expected, actual);
        }
    }
}
