using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Del_del;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Del_del_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForhi()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("hi");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForhis()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("his");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsNegative1ForRyan()
        {
            var expected = -1;

            var utility = new Utility();
            var actual = utility.FindIndex("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0Fordelete()
        {
            var expected = 0;

            var utility = new Utility();
            var actual = utility.FindIndex("delete");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns9FordsubmarineDeljibberish()
        {
            var expected = 9;

            var utility = new Utility();
            var actual = utility.FindIndex("submarineDeljibberish");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns4ForblahDelblahdelblah()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.FindIndex("blahDelblahdelblah");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsBillyForBillydelCrystal5()
        {
            var expected = "Billy";

            var utility = new Utility();
            var actual = utility.DeleteFromdelDelOnward("BillydelCrystal", 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsStarWarsForStarWarsDelJarJar()
        {
            var expected = "Star Wars";

            var utility = new Utility();
            var actual = utility.DeleteFromdelDelOnward("Star WarsDelJarJar", 9);

            Assert.AreEqual(expected, actual);
        }
    }
}
