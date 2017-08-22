using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC_There;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ABC_There_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForCD()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("CD");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForCDE()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("CDE");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns4ForabcasfjlasfjPeriodabcajajabcaljkaabc()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.GetCount("abcasfjlasfj.abcajajabcaljkaabcafsdhabc", "abc");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns5ForABCasfjABCsdasdaPeriodABCPeriodABCasfsasABCABCsfdjABCassjf()
        {
            var expected = 5;

            var utility = new Utility();
            var actual = utility.GetCount("ABCasfjABCsdasda.ABC.ABCasfsasABCABCsfdjABCassjf", "ABC");

            Assert.AreEqual(expected, actual);
        }
    }
}
