using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Int_Max_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Int_Max_3_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor78()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("78");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForr()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("r");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns9For798()
        {
            var expected = 9;

            var utility = new Utility();
            var actual = utility.GetMax(7, 9, 8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns10ForNegative50Negative1910()
        {
            var expected = 10;

            var utility = new Utility();
            var actual = utility.GetMax(-50, -19, 10);

            Assert.AreEqual(expected, actual);
        }
    }
}
