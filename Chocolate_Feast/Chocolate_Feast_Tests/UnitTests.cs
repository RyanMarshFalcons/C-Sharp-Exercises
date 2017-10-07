using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chocolate_Feast;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chocolate_Feast_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void BIsNotAnInteger()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwentySevenIsAnInteger()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("27");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NegativeOneIsNotPositive()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("-1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZeroIsNotPositive()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("0");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneIsPositive()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoIsPositive()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("2");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HaveLessCashThanPriceOfAChocolateBar()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfHaveEnoughCash("4", 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HaveSameCashAsPriceOfAChocolateBar()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfHaveEnoughCash("4", 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HaveMoreCashThanPriceOfAChocolateBar()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfHaveEnoughCash("5", 4);

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
        public void ThreeIsAtLeastTwo()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfAtLeastTwo("3");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinimumValuesForEach()
        {
            var expected = 1;

            var utility = new Utility();
            var actual = utility.CalculateChocolatesEaten(1, 1, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NormalValuesForEach()
        {
            var expected = 5;

            var utility = new Utility();
            var actual = utility.CalculateChocolatesEaten(10, 3, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LargeValuesForEach()
        {
            var expected = 8;

            var utility = new Utility();
            var actual = utility.CalculateChocolatesEaten(200, 25, 10);

            Assert.AreEqual(expected, actual);
        }
    }
}
