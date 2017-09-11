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
        public void ReturnsTrueIfBothMonkeysSmiling()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.AreMonkeysSame(true, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueIfBothMonkeysNotSmiling()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.AreMonkeysSame(false, false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseIfOneMonkeySmiling()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.AreMonkeysSame(true, false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForMonkeysSameAreWearingYellowAndNotCaged()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.AreInTrouble(true, true, false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForMonkeysDifferentAreWearingYellowAndNotCaged()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.AreInTrouble(false, true, false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForMonkeysDifferentAreNotWearingYellowAndNotCaged()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.AreInTrouble(false, false, false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForMonkeysDifferentAreNotWearingYellowAndCaged()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.AreInTrouble(false, false, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForMonkeysDifferentAreWearingYellowAndCaged()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.AreInTrouble(false, true, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForMonkeysSameAreNotWearingYellowAndCaged()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.AreInTrouble(true, false, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForMonkeysSameAreWearingYellowAndCaged()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.AreInTrouble(true, true, true);

            Assert.AreEqual(expected, actual);
        }
    }
}
