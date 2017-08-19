using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Non_Start_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Non_Start_4_Tests
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
        public void ReturnsFalseForN()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("N");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnslowninroundircusigtopForclowninaroundcircusbigtop()
        {
            var expected = "lowninroundircusigtop";

            var utility = new Utility();
            var actual = utility.MakeNewString(new List<string> { "clownin", "around", "circus", "bigtop" });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnstoneoldotavaForstonecoldhotlava()
        {
            var expected = "toneoldotava";

            var utility = new Utility();
            var actual = utility.MakeNewString(new List<string> { "stone", "cold", "hot", "lava" });

            Assert.AreEqual(expected, actual);
        }
    }
}
