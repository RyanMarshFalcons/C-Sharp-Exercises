using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckForCharcter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckForCharacter_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Retruns1FortakemydogDougforawalk()
        {
            var expected = 1;

            var utility = new Utility();
            var actual = utility.SearchForCharacter("take my dog Doug for a walk", 'd');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Retruns4ForHaveaveryMerryChristmas()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.SearchForCharacter("Have a very Merry Christmas", 'r');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Retruns0ForNolowercasePshere()
        {
            var expected = 0;

            var utility = new Utility();
            var actual = utility.SearchForCharacter("No lowercase Ps here", 'p');

            Assert.AreEqual(expected, actual);
        }
    }
}
