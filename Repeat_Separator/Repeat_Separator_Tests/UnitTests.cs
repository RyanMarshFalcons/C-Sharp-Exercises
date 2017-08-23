using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repeat_Separator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repeat_Separator_Tests
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
        public void ReturnsFalseForK()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("K");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative4()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("-4");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForL()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("L");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor2()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidNumber("2");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor1()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidNumber("1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRyanMarshRyanMarshRyanForRyanMarsh3()
        {
            var expected = "RyanMarshRyanMarshRyan";

            var utility = new Utility();
            var actual = utility.CreateNewString("Ryan", "Marsh", 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsbaseballbaseballbaseballbaseForbaseball4()
        {
            var expected = "baseballbaseballbaseballbase";

            var utility = new Utility();
            var actual = utility.CreateNewString("base", "ball", 4);

            Assert.AreEqual(expected, actual);
        }
    }
}
