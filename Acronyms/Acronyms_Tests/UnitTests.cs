using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acronyms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acronyms_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFora()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsToShort("a");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForab()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsToShort("ab");

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ReturnsKFC()
        {
            var expected = "KFC";

            var utility = new Utility();
            var actual = utility.ConvertToAcronym("kentucky fried chicken");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRISBHB()
        {
            var expected = "RISBHB";

            var utility = new Utility();
            var actual = utility.ConvertToAcronym("Ryan's international successful big huge business");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsCBOL()
        {
            var expected = "CBOL";

            var utility = new Utility();
            var actual = utility.ConvertToAcronym("common business oriented language");

            Assert.AreEqual(expected, actual);
        }
    }
}
