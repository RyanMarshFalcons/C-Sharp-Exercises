using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tea_Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tea_Party_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor7()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("7");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFork()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("k");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative4()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-4");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor4()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("4");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsBadFor3TeaCups3CandyBars()
        {
            var expected = "bad";

            var utility = new Utility();
            var actual = utility.CalculatePartyOutcome(3, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsBadFor3TeaCups6CandyBars()
        {
            var expected = "bad";

            var utility = new Utility();
            var actual = utility.CalculatePartyOutcome(3, 6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsBadFor6TeaCups3CandyBars()
        {
            var expected = "bad";

            var utility = new Utility();
            var actual = utility.CalculatePartyOutcome(6, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsGooddFor5TeaCups5CandyBars()
        {
            var expected = "good";

            var utility = new Utility();
            var actual = utility.CalculatePartyOutcome(5, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsGooddFor6TeaCups8CandyBars()
        {
            var expected = "good";

            var utility = new Utility();
            var actual = utility.CalculatePartyOutcome(6, 8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsGreatFor10TeaCups5CandyBars()
        {
            var expected = "great";

            var utility = new Utility();
            var actual = utility.CalculatePartyOutcome(10, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsGreatFor6TeaCups60CandyBars()
        {
            var expected = "great";

            var utility = new Utility();
            var actual = utility.CalculatePartyOutcome(6, 60);

            Assert.AreEqual(expected, actual);
        }
    }
}
