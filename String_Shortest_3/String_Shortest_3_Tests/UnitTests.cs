using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String_Shortest_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String_Shortest_3_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Returns1For123()
        {
            var expected = 1;

            var utility = new Utility();
            var actual = utility.GetShortestLength(new int[] { 1, 2, 3 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns8For10158()
        {
            var expected = 8;

            var utility = new Utility();
            var actual = utility.GetShortestLength(new int[] { 10, 15, 8 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns98For15998127()
        {
            var expected = 98;

            var utility = new Utility();
            var actual = utility.GetShortestLength(new int[] { 159, 98, 127 });

            Assert.AreEqual(expected, actual);
        }
    }
}
