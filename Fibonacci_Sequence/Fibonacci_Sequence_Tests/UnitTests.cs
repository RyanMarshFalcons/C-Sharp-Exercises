using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fibonacci_Sequence;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci_Sequence_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Returns8For011235()
        {
            var expected = 8;

            var utility = new Utility();
            var actual = utility.GetNextNumber(new List<int>() { 0, 1, 1, 2, 3, 5 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns8For011235813()
        {
            var expected = 21;

            var utility = new Utility();
            var actual = utility.GetNextNumber(new List<int>() { 0, 1, 1, 2, 3, 5, 8, 13 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns8For0112358132134()
        {
            var expected = 55;

            var utility = new Utility();
            var actual = utility.GetNextNumber(new List<int>() { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 });

            Assert.AreEqual(expected, actual);
        }
    }
}
