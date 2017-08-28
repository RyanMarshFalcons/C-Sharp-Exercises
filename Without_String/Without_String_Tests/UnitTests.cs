using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Without_String;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Without_String_Tests
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
        public void ReturnsFalseForf()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsTooShort("f");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRanisareallcoolguForRyanisareallycoolguyAndy()
        {
            var expected = "Ran is a reall cool gu";

            var utility = new Utility();
            var actual = utility.RemoveInstancesFromBase("Ryan is a really cool guy", "y");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnspeopleplacesthingsFormostpeoplemostplacesmostthingsAndmost()
        {
            var expected = " people,  places,  things";

            var utility = new Utility();
            var actual = utility.RemoveInstancesFromBase("most people, most places, most things", "most");

            Assert.AreEqual(expected, actual);
        }
    }
}
