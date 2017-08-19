using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Non_Start_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Non_Start_2_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForEmptyString()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForL()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("L");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnslowninroundForclowninaround()
        {
            var expected = "lowninround";

            var utility = new Utility();
            var actual = utility.MakeNewString(new List<string> { "clownin", "around" });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnstoneoldForstonecold()
        {
            var expected = "toneold";

            var utility = new Utility();
            var actual = utility.MakeNewString(new List<string> { "stone", "cold" });

            Assert.AreEqual(expected, actual);
        }
    }
}
