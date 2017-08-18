using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Short_Long_Short;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Short_Long_Short_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForEmptyString()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForJ()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("J");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnTrueForCatAndSee()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfSameLength("cat", "see");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnFalseForCatAndSeem()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfSameLength("cat", "seem");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRyanAwesomeRyanForRyanAwesome()
        {
            var expected = "RyanAwesomeRyan";

            var utility = new Utility();
            var actual = utility.MakeNewString("Ryan", "Awesome");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsbookslibrarybooksForlibrarybooks()
        {
            var expected = "bookslibrarybooks";

            var utility = new Utility();
            var actual = utility.MakeNewString("library", "books");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsscoresoccergoalscoreForsoccergoalscore()
        {
            var expected = "scoresoccer goalscore";

            var utility = new Utility();
            var actual = utility.MakeNewString("soccer goal", "score");

            Assert.AreEqual(expected, actual);
        }
    }
}
