using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Long_Short_Long;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Long_Short_Long_Tests
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
        public void ReturnsFalseForK()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("K");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnTrueForCatAndDog()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfSameLength("cat", "dog");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnFalseForCatAndBird()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfSameLength("cat", "bird");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsAwesomeRyanAwesomeForRyanAwesome()
        {
            var expected = "AwesomeRyanAwesome";

            var utility = new Utility();
            var actual = utility.MakeNewString("Ryan", "Awesome");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnslibrarybookslibraryForlibrarybooks()
        {
            var expected = "librarybookslibrary";

            var utility = new Utility();
            var actual = utility.MakeNewString("library", "books");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnssoccergoalscorescoresoccergoalForsoccergoalscore()
        {
            var expected = "soccer goalscoresoccer goal";

            var utility = new Utility();
            var actual = utility.MakeNewString("soccer goal", "score");

            Assert.AreEqual(expected, actual);
        }
    }
}
