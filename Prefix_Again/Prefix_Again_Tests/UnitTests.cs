using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prefix_Again;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prefix_Again_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForI()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("I");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForIT()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("IT");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor26()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("26");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForM()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("M");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor77()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidNumber("7", 7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor87()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidNumber("8", 7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor05()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidNumber("0", 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsBobsForBobsBurgers5()
        {
            var expected = "Bob's";

            var utility = new Utility();
            var actual = utility.GetPrefix("Bob's Burgers", 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRyForRyan2()
        {
            var expected = "Ry";

            var utility = new Utility();
            var actual = utility.GetPrefix("Ryan", 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForautomobileauto4()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckForMatch("automobileauto", "auto", 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForcupofnoodlescupspoon4()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckForMatch("cupofnoonlescupspoon", "cup", 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFormathtestpassmath4()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckForMatch("mathtestpass", "math", 4);

            Assert.AreEqual(expected, actual);
        }
    }
}
