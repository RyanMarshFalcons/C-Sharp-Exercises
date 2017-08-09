using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cube_Sequence;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cube_Sequence_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Returns64For4()
        {
            var expected = 64;

            var utility = new Utility();
            var actual = utility.GetNextNumber(4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2744For14()
        {
            var expected = 2744;

            var utility = new Utility();
            var actual = utility.GetNextNumber(14);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns13824For24()
        {
            var expected = 13824;

            var utility = new Utility();
            var actual = utility.GetNextNumber(24);

            Assert.AreEqual(expected, actual);
        }
    }
}
