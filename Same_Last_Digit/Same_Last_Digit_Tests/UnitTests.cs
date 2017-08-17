using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Same_Last_Digit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Same_Last_Digit_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor13()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("13");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFori()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("i");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns5For464865()
        {
            var expected = 5;

            var utility = new Utility();
            var actual = utility.GetLastDigit(464865);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2ForNegative12()
        {
            var expected = 2;

            var utility = new Utility();
            var actual = utility.GetLastDigit(-12);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor88()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfSame(8, 8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor89()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfSame(8, 9);

            Assert.AreEqual(expected, actual);
        }
    }
}
