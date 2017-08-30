using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Index_N_Characters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Index_N_Characters_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForEmptyString()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForO()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("O");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0ForM()
        {
            var expected = 0;

            var utility = new Utility();
            var actual = utility.GetMaxIndex("M");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns8ForMiniscule()
        {
            var expected = 8;

            var utility = new Utility();
            var actual = utility.GetMaxIndex("miniscule");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor10()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("10");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForP()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("P");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNegative14()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IndexIsInRange("-1", 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor54()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IndexIsInRange("5", 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor14()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IndexIsInRange("1", 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns7ForWashington3()
        {
            var expected = 7;

            var utility = new Utility();
            var actual = utility.GetMaxNumChars("Washington", 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns5ForArizona2()
        {
            var expected = 5;

            var utility = new Utility();
            var actual = utility.GetMaxNumChars("Arizona", 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor03()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.NumCharsIsInRange("0", 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor43()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.NumCharsIsInRange("4", 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor34()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.NumCharsIsInRange("3", 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnscoolForRyanisacoolguy104()
        {
            var expected = "cool";

            var utility = new Utility();
            var actual = utility.CreateNewString("Ryan is a cool guy", 10, 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnstouFortouchdowndance510()
        {
            var expected = "down dance";

            var utility = new Utility();
            var actual = utility.CreateNewString("touchdown dance", 5, 10);

            Assert.AreEqual(expected, actual);
        }
    }
}
