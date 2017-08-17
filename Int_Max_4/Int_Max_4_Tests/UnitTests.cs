using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Int_Max_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Int_Max_4_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor54()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("54");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForn()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("n");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns9For79108()
        {
            var expected = 10;

            var utility = new Utility();
            var actual = utility.GetMax(7, 9, 10, 8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns10ForNegative50Negative191014()
        {
            var expected = 14;

            var utility = new Utility();
            var actual = utility.GetMax(-50, -19, 10, 14);

            Assert.AreEqual(expected, actual);
        }
    }
}
