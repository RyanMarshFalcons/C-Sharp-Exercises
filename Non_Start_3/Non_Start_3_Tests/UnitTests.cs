using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Non_Start_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Non_Start_3_Tests
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
            var actual = utility.CheckIfTooShort("M");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnslowninroundircusForclowninaroundcircus()
        {
            var expected = "lowninroundircus";

            var utility = new Utility();
            var actual = utility.MakeNewString(new List<string> { "clownin", "around", "circus" });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnstoneoldotForstonecoldhot()
        {
            var expected = "toneoldot";

            var utility = new Utility();
            var actual = utility.MakeNewString(new List<string> { "stone", "cold", "hot" });

            Assert.AreEqual(expected, actual);
        }
    }
}
