using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangular_Sequence;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rectangular_Sequence_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Returns30For5()
        {
            var expected = 30;

            var utility = new Utility();
            var actual = utility.GetNextNumber(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns156For12()
        {
            var expected = 156;

            var utility = new Utility();
            var actual = utility.GetNextNumber(12);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns552For23()
        {
            var expected = 552;

            var utility = new Utility();
            var actual = utility.GetNextNumber(23);

            Assert.AreEqual(expected, actual);
        }
    }
}
