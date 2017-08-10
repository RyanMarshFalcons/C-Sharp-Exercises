using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Speeding_Ticket;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Speeding_Ticket_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor17()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("17");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNotD()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns9For64()
        {
            var expected = 9;

            var utility = new Utility();
            var actual = utility.GetmphOver(64);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns30For85()
        {
            var expected = 30;

            var utility = new Utility();
            var actual = utility.GetmphOver(85);

            Assert.AreEqual(expected, actual);
        }
    }
}
