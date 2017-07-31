using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multiplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Multiplication_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForJersey()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Jersey");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative17point736()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("-17.736");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns56For7And8()
        {
            var expected = 56;

            var utility = new Utility();
            var actual = utility.GetProduct(7, 8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns32For2And16()
        {
            var expected = 32;

            var utility = new Utility();
            var actual = utility.GetProduct(2, 16);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns18point74For3point895And4point812()
        {
            var expected = 18.74;

            var utility = new Utility();
            var actual = utility.GetProduct(3.895, 4.812);

            Assert.AreEqual(expected, actual);
        }
    }
}
