using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quadruple_Characters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Quadruple_Characters_Tests
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
        public void ReturnsTrueForc()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("c");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRRRRuuuunnnnnnnneeeerrrrForRunner()
        {
            var expected = "RRRRuuuunnnnnnnneeeerrrr";

            var utility = new Utility();
            var actual = utility.CreateNewString("Runner");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnssssspppprrrriiiinnnnggggttttiiiimmmmeeeeForspringtime()
        {
            var expected = "sssspppprrrriiiinnnngggg    ttttiiiimmmmeeee";

            var utility = new Utility();
            var actual = utility.CreateNewString("spring time");

            Assert.AreEqual(expected, actual);
        }
    }
}
