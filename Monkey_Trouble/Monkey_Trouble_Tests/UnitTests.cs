using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monkey_Trouble;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Monkey_Trouble_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFory()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("y");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForn()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("n");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForb()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("b");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForTrueTrue()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.AreInTrouble(true, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForFalseFalse()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.AreInTrouble(false, false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForTrueFalse()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.AreInTrouble(true, false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForFalseTrue()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.AreInTrouble(false, true);

            Assert.AreEqual(expected, actual);
        }
    }
}
