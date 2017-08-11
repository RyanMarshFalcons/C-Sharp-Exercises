using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvenOdd;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace EvenOdd_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor12()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("12");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForq()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("q");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForEven()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfEven(4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForOdd()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfEven(5);

            Assert.AreEqual(expected, actual);
        }
    }
}
