using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GallonsToLiters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GallonsToLiters_Tests
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
        public void ReturnsTrueFor87point456()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("87.456");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative71point289()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-71.289");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor71point289()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("71.289");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns22point71For6()
        {
            var expected = 22.71;

            var utility = new Utility();
            var actual = utility.GetLiters(6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns353point02For93point258()
        {
            var expected = 353.02;

            var utility = new Utility();
            var actual = utility.GetLiters(93.258);

            Assert.AreEqual(expected, actual);
        }
    }
}
