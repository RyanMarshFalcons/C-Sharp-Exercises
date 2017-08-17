using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String_Shortest_5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String_Shortest_5_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Returns1For12345()
        {
            var expected = 1;

            var utility = new Utility();
            var actual = utility.GetShortestLength(new int[] { 1, 2, 3, 4, 5 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns8For1015843()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.GetShortestLength(new int[] { 10, 15, 8, 4, 3 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns78For15978127256318()
        {
            var expected = 78;

            var utility = new Utility();
            var actual = utility.GetShortestLength(new int[] { 159, 78, 127, 256, 318 });

            Assert.AreEqual(expected, actual);
        }
    }
}
