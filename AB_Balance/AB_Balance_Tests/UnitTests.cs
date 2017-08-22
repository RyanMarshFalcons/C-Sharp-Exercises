using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AB_Balance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AB_Balance_Tests
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
        public void ReturnsTrueForE()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3ForasdAjdfjdsAsdfsdhsdhkAdf()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.GetCount("asdAjdfjdsAsdfsdhsdhkAdf", "A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns10Forbbbbbasdfsadsdbbbbbasdffsdafsd()
        {
            var expected = 10;

            var utility = new Utility();
            var actual = utility.GetCount("bbbbbasdfsadsdbbbbbasdffsdafsd", "b");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor4215()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfBalance(4, 2, 1, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor3178()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfBalance(3, 1, 7, 8);

            Assert.AreEqual(expected, actual);
        }
    }
}
