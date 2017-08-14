using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max_Mod_5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Max_Mod_5_Tests
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
        public void ReturnsFalseForm()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("m");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor24And24()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfEqual(24, 24);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor23And25()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfEqual(23, 25);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns5For5And3()
        {
            var expected = 5;

            var utility = new Utility();
            var actual = utility.DetermineMorePowerful(5, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns16For16And21()
        {
            var expected = 16;

            var utility = new Utility();
            var actual = utility.DetermineMorePowerful(16, 21);

            Assert.AreEqual(expected, actual);
        }
    }
}
