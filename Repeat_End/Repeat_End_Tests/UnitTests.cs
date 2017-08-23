using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repeat_End;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repeat_End_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForH()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("H");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForHi()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("Hi");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor15()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("15");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForI()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("I");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor44()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidNumber("4", 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor54()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidNumber("5", 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor03()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidNumber("0", 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsolderolderolderolderolderForcupholder5()
        {
            var expected = "olderolderolderolderolder";

            var utility = new Utility();
            var actual = utility.CreateNewString("cupholder", 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsyanyanyanForRyan3()
        {
            var expected = "yanyanyan";

            var utility = new Utility();
            var actual = utility.CreateNewString("Ryan", 3);

            Assert.AreEqual(expected, actual);
        }
    }
}
