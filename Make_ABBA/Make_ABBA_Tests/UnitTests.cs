using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Make_ABBA;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Make_ABBA_Tests
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
        public void ReturnsFalseForE()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRyanAwesomeAwesomeRyanForRyanAwesome()
        {
            var expected = "RyanAwesomeAwesomeRyan";

            var utility = new Utility();
            var actual = utility.MakeNewString("Ryan", "Awesome");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnslibrarybooksbookslibraryForlibrary()
        {
            var expected = "librarybooksbookslibrary";

            var utility = new Utility();
            var actual = utility.MakeNewString("library", "books");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnGoallllllexclamationpointsoccersoccerGoallllllexclamationpointForGoallllllexclamationpointsoccer()
        {
            var expected = "Goallllll!soccersoccerGoallllll!";

            var utility = new Utility();
            var actual = utility.MakeNewString("Goallllll!", "soccer");

            Assert.AreEqual(expected, actual);
        }
    }
}
