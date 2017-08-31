using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Every_Nth_Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Every_Nth_Character_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForby()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("by");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForbye()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("bye");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor14()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("14");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForm()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("m");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor1Ryan()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfOutOfRange("1", "Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor4Ryan()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfOutOfRange("4", "Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor2Ryan()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfOutOfRange("2", "Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor3Ryan()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfOutOfRange("3", "Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsacForabc2()
        {
            var expected = "ac";

            var utility = new Utility();
            var actual = utility.FormStringFromEveryNthChar("abc", 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsBbTaForBobbyTheBrain3()
        {
            var expected = "BbT a";

            var utility = new Utility();
            var actual = utility.FormStringFromEveryNthChar("Bobby The Brain", 3);

            Assert.AreEqual(expected, actual);
        }
    }
}
