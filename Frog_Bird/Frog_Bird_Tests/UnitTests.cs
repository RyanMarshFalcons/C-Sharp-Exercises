using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frog_Bird;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Frog_Bird_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForABC()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("ABC");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForABCD()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("ABCD");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3Forhadbirdadasdfbirdadsbirdadfv()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.GetCount("hadbirdadasdfbirdafrogdsbirdadfv", "bird");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3Forfrogasdfjfrogaweruhwefrogasdje3aefrogasdclkjh()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.GetCount("birdfrogasdfjfrogaweruhwefrogasdje3aefrogasdclkjh", "frog");

            Assert.AreEqual(expected, actual);
        }
    }
}
