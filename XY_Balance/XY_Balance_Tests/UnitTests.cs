using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XY_Balance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XY_Balance_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForEmptyString()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForF()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3ForasdXjdfjdsXsdfsdhsdhkXdd()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.GetCount("asdXjdfjdsXsdfsdhsdhkXdd", "X");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns10Foryyyyyasdfsadsdyyyyyasdffsdafsdklklkl()
        {
            var expected = 10;

            var utility = new Utility();
            var actual = utility.GetCount("yyyyyasdfsadsdyyyyyasdffsdafsdklklkl", "y");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor4216()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfBalance(4, 3, 1, 6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor3179()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfBalance(3, 1, 7, 9);

            Assert.AreEqual(expected, actual);
        }
    }
}
