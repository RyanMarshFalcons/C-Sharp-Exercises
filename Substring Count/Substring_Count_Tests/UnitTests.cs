using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Substring_Count;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Substring_Count_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForEmptyString()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForQ()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("Q");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForTheSubstringBeingLonger()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfSubstringIsLonger("boot", "boots");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForTheSubstringBeinShorter()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfSubstringIsLonger("boot", "boo");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3ForSubstringAppearing3Times()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.GetCount("ABABCBCBA", "A", false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2ForSubstringAppearing2Times()
        {
            var expected = 2;

            var utility = new Utility();
            var actual = utility.GetCount("Ryan is awesome because Ryan is cool!!!", "Ryan", false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0ForSubstringNotAppearingAtAll()
        {
            var expected = 0;

            var utility = new Utility();
            var actual = utility.GetCount("Monkey", "Chimpanzee", true);

            Assert.AreEqual(expected, actual);
        }
    }
}
