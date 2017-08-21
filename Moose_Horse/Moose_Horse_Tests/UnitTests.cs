using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moose_Horse;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Moose_Horse_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForABCD()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("ABCD");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForABCDE()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("ABCDE");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3Forhadhorseadasdfhorseadshorseadfv()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.GetCount("hadhorseadasdfhorseamoosedshorseadfv", "horse");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3Formooseasdfjmooseaweruhwemooseasdje3aemooseasdclkjh()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.GetCount("horsemooseasdfjmooseaweruhwemooseasdje3aemooseasdclkjh", "moose");

            Assert.AreEqual(expected, actual);
        }
    }
}
