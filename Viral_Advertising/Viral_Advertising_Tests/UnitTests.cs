using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viral_Advertising;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Viral_Advertising_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void LIsNotAnInteger()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("L");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FortyTwoIsAnInteger()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("42");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZeroIsNotAtLeastTwo()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfAtLeastTwo("0");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneIsNotAtLeastTwo()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfAtLeastTwo("1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoIsAtLeastTwo()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfAtLeastTwo("2");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ThreeoIsAtLeastTwo()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfAtLeastTwo("3");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoIsNotAtLeastFour()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfAtLeastFour("2");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ThreeIsNotAtLeastFour()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfAtLeastFour("3");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FourIsAtLeastFour()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfAtLeastFour("4");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveIsAtLeastFour()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfAtLeastFour("5");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FourInitialPeopleTwoDaysEqualsFiveTotalLikes()
        {
            var expected = 5;

            var utility = new Utility();
            var actual = utility.CaluclateTotalLikes(4, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveInitialPeopleThreeDaysEqualsNineTotalLikes()
        {
            var expected = 9;

            var utility = new Utility();
            var actual = utility.CaluclateTotalLikes(5, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EightInitialPeopleFiveDaysEqualsFiftyOneTotalLikes()
        {
            var expected = 51;

            var utility = new Utility();
            var actual = utility.CaluclateTotalLikes(8, 5);

            Assert.AreEqual(expected, actual);
        }
    }
}
