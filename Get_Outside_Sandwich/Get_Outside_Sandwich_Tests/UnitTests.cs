using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Get_Outside_Sandwich;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Get_Outside_Sandwich_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForHollyWood()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("Holly Wood");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForHollyWoodExclamationPoint()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("Holly Wood!");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0Forbreadwinnerchickendinner()
        {
            var expected = 0;

            var utility = new Utility();
            var actual = utility.GetIndexOfFirstSlice("breadwinnerchickendinner");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns9ForMaryisthebreadwinner()
        {
            var expected = 9;

            var utility = new Utility();
            var actual = utility.GetIndexOfFirstSlice("maryisthebreadwinner");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0AgainForbreadwinnerchickendinner()
        {
            var expected = 0;

            var utility = new Utility();
            var actual = utility.GetIndexOfSecondSlice("breadwinnerchickendinner");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns20ForMaryisthebreadwinnerbreadwinner()
        {
            var expected = 20;

            var utility = new Utility();
            var actual = utility.GetIndexOfSecondSlice("Maryisthebreadwinnerbreadwinner");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns29Forlotsofbreadcheesebreadmeatbreadmayobreadstuff()
        {
            var expected = 35;

            var utility = new Utility();
            var actual = utility.GetIndexOfSecondSlice("lotsofbreadcheesebreadmeatbreadmayobreadstuff");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsmoreolivesFormorebreadcheesemeatmayopickleonionmusturdbreadolives()
        {
            var expected = "moreolives";

            var utility = new Utility();
            var actual = utility.CreateNewString("morebreadcheesemeatmayopickleonionmusturdbreadolives", 4, 41);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnswhitestuffForwhitebreadcheesebreadmeatmayobreadpickleonionbreadstuff()
        {
            var expected = "whitestuff";

            var utility = new Utility();
            var actual = utility.CreateNewString("whitebreadcheesebreadmeatmayobreadpickleonionbreadstuff", 5, 45);

            Assert.AreEqual(expected, actual);
        }
    }
}
