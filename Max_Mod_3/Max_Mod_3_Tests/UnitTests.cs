using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max_Mod_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Max_Mod_3_Tests
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
        public void ReturnsFalseForn()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("n");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor23And23()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfEqual(23, 23);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor23And24()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfEqual(23, 24);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns5For5And4()
        {
            var expected = 5;

            var utility = new Utility();
            var actual = utility.DetermineMorePowerful(5, 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns4For7And4()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.DetermineMorePowerful(7, 4);

            Assert.AreEqual(expected, actual);
        }
    }
}
