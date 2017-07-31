using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Addition;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Addition_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForhouse()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("house");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor7point38()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("2.79");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns21For14And7()
        {
            var expected = 21;

            var utility = new Utility();
            var actual = utility.GetSum(14, 7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns44For33And11()
        {
            var expected = 44;

            var utility = new Utility();
            var actual = utility.GetSum(33, 11);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns10point25ForNegative2point5And12point75()
        {
            var expected = 10.25;

            var utility = new Utility();
            var actual = utility.GetSum(-2.5, 12.75);

            Assert.AreEqual(expected, actual);
        }
    }
}
