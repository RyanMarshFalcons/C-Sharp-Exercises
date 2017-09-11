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
            var actual = utility.IsTooShort("a");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForab()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsTooShort("ab");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForPeterPan()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.ContainsAWord("Peter Pan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor1Peter2Pan()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.ContainsAWord("1Peter 2Pan");

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

        [TestMethod]
        public void ReturnsTrueFory()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("y");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForn()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("n");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForo()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("o");

            Assert.AreEqual(expected, actual);
        }
    }
}
