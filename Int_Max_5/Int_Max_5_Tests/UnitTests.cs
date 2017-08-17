using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Int_Max_5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Int_Max_5_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor45()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("45");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForo()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("o");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns9For7910118()
        {
            var expected = 11;

            var utility = new Utility();
            var actual = utility.GetMax(7, 9, 10, 11, 8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns10ForNegative50Negative19101418()
        {
            var expected = 18;

            var utility = new Utility();
            var actual = utility.GetMax(-50, -19, 10, 14, 18);

            Assert.AreEqual(expected, actual);
        }
    }
}
