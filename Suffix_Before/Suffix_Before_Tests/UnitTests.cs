using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Suffix_Before;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Suffix_Before_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForJ()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("J");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForJK()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("JK");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor33()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("33");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForN()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("N");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor88()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidNumber("8", 8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor98()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidNumber("9", 8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor06()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidNumber("0", 6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsrgersForBobsBurgers5()
        {
            var expected = "rgers";

            var utility = new Utility();
            var actual = utility.GetSuffix("Bob's Burgers", 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsanForRyan2()
        {
            var expected = "an";

            var utility = new Utility();
            var actual = utility.GetSuffix("Ryan", 2);

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
        public void ReturnsTrueForcupofspoonnoonlescupspoonspoon5()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckForMatch("cupofspoonnoonlescupspoon", "spoon", 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFormathtestpasspass4()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckForMatch("mathtestpass", "pass", 4);

            Assert.AreEqual(expected, actual);
        }
    }
}
