using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Same_First_Digit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Same_First_Digit_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor22()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("22");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForg()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("g");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns4For467865()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.GetFirstDigit(467865);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns1ForNegative12()
        {
            var expected = 1;

            var utility = new Utility();
            var actual = utility.GetFirstDigit(-12);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor77()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfSame(7, 7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor67()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfSame(6, 7);

            Assert.AreEqual(expected, actual);
        }
    }
}
