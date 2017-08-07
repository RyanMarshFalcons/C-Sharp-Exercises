using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electoral_College;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Electoral_College_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor1()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIf1or2("1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor2()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIf1or2("2");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor3()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIf1or2("3");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns74ForWestCoast()
        {
            var expected = 74;

            var utility = new Utility();
            var actual = utility.SumOfVotes(new List<int>() { 55, 7, 12 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns88ForSouthEast()
        {
            var expected = 88;

            var utility = new Utility();
            var actual = utility.SumOfVotes(new List<int>() { 9, 16, 29, 11, 9, 6, 8 });

            Assert.AreEqual(expected, actual);
        }
    }
}
