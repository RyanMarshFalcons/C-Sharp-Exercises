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
        public void BadOutcomeFor3TeaCups3Biscuits3CandyBars()
        {
            var expected = "bad";

            var utility = new Utility();
            var actual = utility.CalculatePartyOutcome(3, 3, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BadOutcomeFor3TeaCups6Biscuits7CandyBars()
        {
            var expected = "bad";

            var utility = new Utility();
            var actual = utility.CalculatePartyOutcome(3, 6, 7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BadOutcomeFor11TeaCups7Biscuits3CandyBars()
        {
            var expected = "bad";

            var utility = new Utility();
            var actual = utility.CalculatePartyOutcome(11, 7, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GoodOutcomtFor10TeaCups5Biscuits5CandyBars()
        {
            var expected = "good";

            var utility = new Utility();
            var actual = utility.CalculatePartyOutcome(10, 5, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GoodOutcomeFor20TeaCups5Biscuits5CandyBars()
        {
            var expected = "good";

            var utility = new Utility();
            var actual = utility.CalculatePartyOutcome(20, 5, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GreatOutcomeFor10TeaCups7Biscuits15CandyBars()
        {
            var expected = "great";

            var utility = new Utility();
            var actual = utility.CalculatePartyOutcome(10, 7, 15);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GreatOutcomeFor12TeaCups10Biscuits50CandyBars()
        {
            var expected = "great";

            var utility = new Utility();
            var actual = utility.CalculatePartyOutcome(12, 10, 50);

            Assert.AreEqual(expected, actual);
        }
    }
}
