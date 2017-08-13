using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Larger_Number;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Larger_Number_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor50()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("50");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFori()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("i");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor13And13()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfEqual(13, 13);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor13And14()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfEqual(13, 14);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns7For7And4()
        {
            var expected = 7;

            var utility = new Utility();
            var actual = utility.GetLargerNumber(7, 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3ForNegative13And3()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.GetLargerNumber(-13, 3);

            Assert.AreEqual(expected, actual);
        }
    }
}
