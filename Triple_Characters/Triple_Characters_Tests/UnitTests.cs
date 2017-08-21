using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triple_Characters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Triple_Characters_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForEmptyString()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForb()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("b");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRRRuuunnnnnneeerrrForRunner()
        {
            var expected = "RRRuuunnnnnneeerrr";

            var utility = new Utility();
            var actual = utility.CreateNewString("Runner");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnssssppprrriiinnngggtttiiimmmeeeForspringtime()
        {
            var expected = "sssppprrriiinnnggg   tttiiimmmeee";

            var utility = new Utility();
            var actual = utility.CreateNewString("spring time");

            Assert.AreEqual(expected, actual);
        }
    }
}
