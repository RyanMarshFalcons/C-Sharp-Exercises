using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Golf_ScoreCard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Golf_ScoreCard_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalsefor3point5()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("3.5");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor35()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("35");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor7()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsPositive("7");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNegative7()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsPositive("-7");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns4For11()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.GetParForHole(11);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns4For12()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.GetParForHole(12);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns5For13()
        {
            var expected = 5;

            var utility = new Utility();
            var actual = utility.GetParForHole(13);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns80For8overPar()
        {
            var expected = 80;

            var utility = new Utility();
            var actual = utility.GetTotalScore(new List<int>() { 3, 5, 4, 6, 4, 5, 6, 4, 3, 4, 3, 6, 4, 4, 6, 4, 4, 5 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns64For8underPar()
        {
            var expected = 64;

            var utility = new Utility();
            var actual = utility.GetTotalScore(new List<int>() { 5, 2, 4, 3, 4, 3, 4, 3, 4, 3, 4, 3, 4, 3, 4, 3, 4, 4 });

            Assert.AreEqual(expected, actual);
        }
    }
}
