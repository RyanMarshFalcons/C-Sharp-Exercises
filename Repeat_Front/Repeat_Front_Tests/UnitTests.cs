using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repeat_Front;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repeat_Front_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForM()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("M");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForMy()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("My");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor11()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("11");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForJ()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("J");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor55()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidNumber("5", 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor65()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidNumber("6", 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor04()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidNumber("0", 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnscuphocuphocuphocuphocuphoForcupholder5()
        {
            var expected = "cuphocuphocuphocuphocupho";

            var utility = new Utility();
            var actual = utility.CreateNewString("cupholder", 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRyaRyaRyaForRyan3()
        {
            var expected = "RyaRyaRya";

            var utility = new Utility();
            var actual = utility.CreateNewString("Ryan", 3);

            Assert.AreEqual(expected, actual);
        }
    }
}
