using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anagrams;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagrams_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Returnsabcdefg()
        {
            var expected = "abcdefg";

            var utility = new Utility();
            var actual = utility.InputSorted("fgdebac");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns123456789()
        {
            var expected = "123456789";

            var utility = new Utility();
            var actual = utility.InputSorted("864297531");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRaaaaillnnrssty()
        {
            var expected = "   Raaaaillnnrssty";

            var utility = new Utility();
            var actual = utility.InputSorted("Ryan is an allstar");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returnsalovelywalkincentralpark()
        {
            var expected = "alovelywalkincentralpark";

            var utility = new Utility();
            var actual = utility.AdjustString("A lovely walk in Central Park.");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returnsonetwoskiptomylou()
        {
            var expected = "onetwoskiptomylou";

            var utility = new Utility();
            var actual = utility.AdjustString("One, two: skip to my Lou!");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returnstrue()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.FindOutIfAnagram("lollipop", "lollipop");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returnsfalse()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.FindOutIfAnagram("chocolate", "vanilla");

            Assert.AreEqual(expected, actual);
        }
    }
}
