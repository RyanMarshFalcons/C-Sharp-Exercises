using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Square_Sequence;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Square_Sequence_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Returns16For4()
        {
            var expected = 16;

            var utility = new Utility();
            var actual = utility.GetNextNumber(4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns196For14()
        {
            var expected = 196;

            var utility = new Utility();
            var actual = utility.GetNextNumber(14);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns576For24()
        {
            var expected = 576;

            var utility = new Utility();
            var actual = utility.GetNextNumber(24);

            Assert.AreEqual(expected, actual);
        }
    }
}
