using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lazy_Caterer_Sequence;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lazy_Caterer_Sequence_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Returns16For5()
        {
            var expected = 16;

            var utility = new Utility();
            var actual = utility.GetNextNumber(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns79For12()
        {
            var expected = 79;

            var utility = new Utility();
            var actual = utility.GetNextNumber(12);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns277For23()
        {
            var expected = 277;

            var utility = new Utility();
            var actual = utility.GetNextNumber(23);

            Assert.AreEqual(expected, actual);
        }
    }
}
