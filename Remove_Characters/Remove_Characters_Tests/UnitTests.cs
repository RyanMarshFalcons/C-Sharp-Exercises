using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Remove_Characters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Remove_Characters_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForEmptyString()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsTooShort("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForh()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsTooShort("h");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFori()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsASingleCharacter("i");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForij()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsASingleCharacter("ij");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsWaerboleForWaterbottlet()
        {
            var expected = "Waer bole";

            var utility = new Utility();
            var actual = utility.RemoveCharacter("Water bottle", 't');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsSoakuptheunForSoakupthesuns()
        {
            var expected = "Soak up the un";

            var utility = new Utility();
            var actual = utility.RemoveCharacter("Soak up the sun", 's');

            Assert.AreEqual(expected, actual);
        }

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
        public void ReturnsFalseForz()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("z");

            Assert.AreEqual(expected, actual);
        }
    }
}
