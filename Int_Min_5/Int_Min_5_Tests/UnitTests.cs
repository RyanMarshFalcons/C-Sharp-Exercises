using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Int_Min_5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Int_Min_5_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor84()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("84");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFore()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("e");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns9For7910112()
        {
            var expected = 2;

            var utility = new Utility();
            var actual = utility.GetMin(7, 9, 10, 11, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns1For4812113()
        {
            var expected = 1;

            var utility = new Utility();
            var actual = utility.GetMin(4, 8, 12, 1, 13);

            Assert.AreEqual(expected, actual);
        }
    }
}
