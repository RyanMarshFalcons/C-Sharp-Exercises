using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract_Sequence;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tesseract_Tests
{

    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Returns256For4()
        {
            var expected = 256;

            var utility = new Utility();
            var actual = utility.GetNextNumber(4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns38416For14()
        {
            var expected = 38416;

            var utility = new Utility();
            var actual = utility.GetNextNumber(14);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns331776For24()
        {
            var expected = 331776;

            var utility = new Utility();
            var actual = utility.GetNextNumber(24);

            Assert.AreEqual(expected, actual);
        }
    }
}
