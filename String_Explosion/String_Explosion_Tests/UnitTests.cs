using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String_Explosion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String_Explosion_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForMy()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("My");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForHit()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("Min");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForMine()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("Mine");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRRuRunRunnRunneRunnerForRunner()
        {
            var expected = "RRuRunRunnRunneRunner";

            var utility = new Utility();
            var actual = utility.CreateNewString("Runner");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnssspsprsprisprinspringspringspringtspringtispringtimspringtimeForspringtime()
        {
            var expected = "sspsprsprisprinspringspring spring tspring tispring timspring time";

            var utility = new Utility();
            var actual = utility.CreateNewString("spring time");

            Assert.AreEqual(expected, actual);
        }
    }
}
