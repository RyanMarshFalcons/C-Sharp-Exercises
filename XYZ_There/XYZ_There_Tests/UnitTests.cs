using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZ_There;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XYZ_There_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForBC()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("BC");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForBCD()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("BCD");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns4ForxyzasfjlasfjPeriodxyzajajxyzaljkaxyz()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.GetCount("xyzasfjlasfj.xyzajajxyzaljkaxyzafsdhxyz", "xyz");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns5ForXYZasfjXYZsdasdaPeriodXYZPeriodXYZasfsasXYZXYZsfdjXYZassjf()
        {
            var expected = 5;

            var utility = new Utility();
            var actual = utility.GetCount("XYZasfjXYZsdasda.XYZ.XYZasfsasXYZXYZsfdjXYZassjf", "XYZ");

            Assert.AreEqual(expected, actual);
        }
    }
}
