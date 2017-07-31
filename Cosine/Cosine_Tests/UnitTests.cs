using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cosine_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor9point45()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("9.45");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForcat()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("cat");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsPoint75For7()
        {
            var expected = .75;
            var utility = new Utility();
            var actual = utility.GetCosine(7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsNegativePoint91For9()
        {
            var expected = -.91;
            var utility = new Utility();
            var actual = utility.GetCosine(9);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsPoint53For45()
        {
            var expected = .53;
            var utility = new Utility();
            var actual = utility.GetCosine(45);

            Assert.AreEqual(expected, actual);
        }
    }
}
