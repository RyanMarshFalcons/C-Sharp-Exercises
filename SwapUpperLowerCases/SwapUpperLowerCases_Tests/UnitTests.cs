using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwapUpperLowerCases;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwapUpperLowerCases_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForEmptyString()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsToShort("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFora()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsToShort("a");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsAbCdEfG()
        {
            var expected = "AbCdEfG";

            var utility = new Utility();
            var actual = utility.SwapCases("aBcDeFg");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnssEEsPOTrUN()
        {
            var expected = "sEE sPOT rUN";

            var utility = new Utility();
            var actual = utility.SwapCases("See Spot Run");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsrANDomGiBBeriSHababABAB123()
        {
            var expected = "rANDom GiBBeriSH ababABAB123";

            var utility = new Utility();
            var actual = utility.SwapCases("RandOM gIbbERIsh ABABabab123");

            Assert.AreEqual(expected, actual);
        }
    }
}
