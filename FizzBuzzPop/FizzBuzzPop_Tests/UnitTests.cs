using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzPop;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzPop_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFizzFor6()
        {
            var expected = "Fizz";

            var utility = new Utility();
            var actual = utility.EvaluateNumber(6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsBuzzFor10()
        {
            var expected = "Buzz";

            var utility = new Utility();
            var actual = utility.EvaluateNumber(10);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsPopFor14()
        {
            var expected = "Pop";

            var utility = new Utility();
            var actual = utility.EvaluateNumber(14);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFizzBuzzFor30()
        {
            var expected = "FizzBuzz";

            var utility = new Utility();
            var actual = utility.EvaluateNumber(30);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFizzPopFor42()
        {
            var expected = "FizzPop";

            var utility = new Utility();
            var actual = utility.EvaluateNumber(42);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsBuzzPopFor70()
        {
            var expected = "BuzzPop";

            var utility = new Utility();
            var actual = utility.EvaluateNumber(70);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFizzBuzzPopFor210()
        {
            var expected = "FizzBuzzPop";

            var utility = new Utility();
            var actual = utility.EvaluateNumber(210);

            Assert.AreEqual(expected, actual);
        }
    }
}
