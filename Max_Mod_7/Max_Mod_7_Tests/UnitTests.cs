using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max_Mod_7;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Max_Mod_7_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor19()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("19");

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
        public void ReturnsTrueFor25And25()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfEqual(25, 25);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor25And24()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfEqual(25, 24);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns5For5And2()
        {
            var expected = 5;

            var utility = new Utility();
            var actual = utility.DetermineMorePowerful(5, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns4For11And4()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.DetermineMorePowerful(11, 4);

            Assert.AreEqual(expected, actual);
        }
    }
}
