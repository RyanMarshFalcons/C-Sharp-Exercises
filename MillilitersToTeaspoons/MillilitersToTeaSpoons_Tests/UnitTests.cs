using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MillilitersToTeaspoons;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MillilitersToTeaSpoons_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForGeorgia()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Georgia");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor63point18()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("63.18");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative7point124()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-7.124");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor7point124()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("7.124");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3point45For17()
        {
            var expected = 3.45;

            var utility = new Utility();
            var actual = utility.GetTeaspoons(17);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns12point83For63point249()
        {
            var expected = 12.83;

            var utility = new Utility();
            var actual = utility.GetTeaspoons(63.249);

            Assert.AreEqual(expected, actual);
        }
    }
}
