using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Name_Meaning;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Name_Meaning_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForEmptyString()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsTooShort("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFora()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsTooShort("a");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForRobert()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.ContainsALetter("Robert");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForR1()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.ContainsALetter("R1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor12Jibberish()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.ContainsALetter("12.,{})(*&^%$#@!");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRYANMARSHForRyanMarshwithsybols()
        {
            var expected = "RYANMARSH";

            var utility = new Utility();
            var actual = utility.GetJustLetters("Rya'n! M-arsh?");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsCANELLOForCanellowithsybols()
        {
            var expected = "CANELLO";

            var utility = new Utility();
            var actual = utility.GetJustLetters("Ca-ne!!l!l??o9");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRespectfulYouthfulAdventurousNobleForRYAN()
        {
            var expected = new List<string>() { "Respectful", "Youthful", "Adventurous", "Noble" };

            var utility = new Utility();
            var actual = utility.GetDescription("RYAN", utility.GetAdjectiveDictionary());

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsJoyfulIntelligentMaganimousBenevolentOutgoingForJIMBO()
        {
            var expected = new List<string>() { "Joyful", "Intelligent", "Magananimous", "Benevolent", "Outgoing"};

            var utility = new Utility();
            var actual = utility.GetDescription("JIMBO", utility.GetAdjectiveDictionary());

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
