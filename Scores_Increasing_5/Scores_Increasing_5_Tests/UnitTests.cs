using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scores_Increasing_5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Scores_Increasing_5_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor21()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("21");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForv()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("v");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor11234()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfIncreasing(new int[] { 1, 1, 2, 3, 4 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor15234()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfIncreasing(new int[] { 1, 5, 2, 3, 4 });

            Assert.AreEqual(expected, actual);
        }
    }
}
