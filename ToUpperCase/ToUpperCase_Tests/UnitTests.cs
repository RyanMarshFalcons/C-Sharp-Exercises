using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToUpperCase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ToUpperCase_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void returnsALLGOODTHINGS()
        {
            var expected = "ALL GOOD THINGS";

            var utility = new Utility();
            var actual = utility.ToUpperCase("all good things");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsCANYOUHEARMENOW()
        {
            var expected = "CAN YOU HEAR ME NOW";

            var utility = new Utility();
            var actual = utility.ToUpperCase("can YOU Hear me noW");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsANDTHATSTHEBOTTOMLINE()
        {
            var expected = "AND THAT'S THE BOTTOM LINE";

            var utility = new Utility();
            var actual = utility.ToUpperCase("And that's The BOTTOM line");

            Assert.AreEqual(expected, actual);
        }
    }
}
