using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Remove_Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Remove_Character_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor11()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("11");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForz()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("z");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative6()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-6");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor6()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("6");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor34()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfIndexExists("3", 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor33()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfIndexExists("3", 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrainreckForTrainwreck5()
        {
            var expected = "Trainreck";

            var utility = new Utility();
            var actual = utility.GetNewString("Trainwreck", 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRyanisaoolguyForRyanisacoolguy10()
        {
            var expected = "Ryan is a ool guy";

            var utility = new Utility();
            var actual = utility.GetNewString("Ryan is a cool guy", 10);

            Assert.AreEqual(expected, actual);
        }
    }
}
