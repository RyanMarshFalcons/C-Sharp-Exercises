using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String_Shortest_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String_Shortest_4_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Returns1For1234()
        {
            var expected = 1;

            var utility = new Utility();
            var actual = utility.GetShortestLength(new int[] { 1, 2, 3, 4 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns8For101586()
        {
            var expected = 6;

            var utility = new Utility();
            var actual = utility.GetShortestLength(new int[] { 10, 15, 8, 6 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns127For159198127135()
        {
            var expected = 127;

            var utility = new Utility();
            var actual = utility.GetShortestLength(new int[] { 159, 198, 127, 135 });

            Assert.AreEqual(expected, actual);
        }
    }
}
