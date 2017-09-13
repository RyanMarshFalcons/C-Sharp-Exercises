using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mix_String;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mix_String_Tests
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
        public void ReturnsTrueForG()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("G");

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
        public void ReturnsFalseForr()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("r");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3ForRyanTheGreat()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.GetShortestStringLength(new List<string>() { "Ryan", "The", "Great" });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns4ForCindyJaneMarsha()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.GetShortestStringLength(new List<string>() { "Cindy", "Marsha", "Jane" });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRTGyhraeeForRyanTheGreat()
        {
            var expected = "RTGyhraee";

            var utility = new Utility();
            var actual = utility.MixStringsTogether(new List<string>() { "Ryan", "The", "Great" }, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsCMJiaanrndseForCindyMarshaJane()
        {
            var expected = "CMJiaanrndse";

            var utility = new Utility();
            var actual = utility.MixStringsTogether(new List<string>() { "Cindy", "Marsha", "Jane" }, 4);

            Assert.AreEqual(expected, actual);
        }
    }
}
