using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Number_Count;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Number_Count_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Returnsbirdsofafeather()
        {
            var expected = new char[] { 'b', 'i', 'r', 'd', 's', ' ', 'o', 'f', ' ', 'a', ' ', 'f', 'e', 'a', 't', 'h', 'e', 'r' };

            var utility = new Utility();
            var actual = utility.ConvertToCharArray("birds of a feather");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returnssingingbird()
        {
            var expected = new char[] { 's', 'i', 'n', 'g', 'i', 'n', 'g', ' ', 'b', 'i', 'r', 'd' };

            var utility = new Utility();
            var actual = utility.ConvertToCharArray("singing bird");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns6For123GO123()
        {
            var expected = 6;

            var utility = new Utility();
            var actual = utility.CountNumbersInArray(new char[] { '1', '2', '3', ' ', 'G', 'O', '1', '2', '3' });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3For321blastoff()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.CountNumbersInArray(new char[] { '3', '2', '1', ' ', 'b', 'l', 'a', 's', 't', 'o', 'f', 'f' });

            Assert.AreEqual(expected, actual);
        }
    }
}
