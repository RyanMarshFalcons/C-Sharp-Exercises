using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max_Mod_N;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Max_Mod_N_Tests
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
        public void ReturnsTrueForNegative1()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNotZero("-1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor1()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNotZero("1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor0()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNotZero("0");

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
        public void Returns15For10154()
        {
            var expected = 15;

            var utility = new Utility();
            var actual = utility.DetermineMorePowerful(10, 15, 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns10For10155()
        {
            var expected = 10;

            var utility = new Utility();
            var actual = utility.DetermineMorePowerful(10, 15, 5);

            Assert.AreEqual(expected, actual);
        }
    }
}
