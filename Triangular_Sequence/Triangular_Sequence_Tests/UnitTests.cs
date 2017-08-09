using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangular_Sequence;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Triangular_Sequence_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Returns15For5()
        {
            var expected = 15;

            var utility = new Utility();
            var actual = utility.GetNextNumber(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns78For12()
        {
            var expected = 78;

            var utility = new Utility();
            var actual = utility.GetNextNumber(12);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns276For23()
        {
            var expected = 276;

            var utility = new Utility();
            var actual = utility.GetNextNumber(23);

            Assert.AreEqual(expected, actual);
        }
    }
}
