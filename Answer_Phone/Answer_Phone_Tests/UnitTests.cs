using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Answer_Phone;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Answer_Phone_Tests
{
    [TestClass]
    public class UnitTests
    {
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

        [TestMethod]
        public void ReturnsTrueForTrueFalseFalse()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.AnswerPhone(true, false, false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForFalseFalseFalse()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.AnswerPhone(false, false, false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForTrueTrueFalse()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.AnswerPhone(true, true, false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFaleForFalseTrueFalse()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.AnswerPhone(false, true, false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForTrueTrueTrue()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.AnswerPhone(true, true, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForFalseTrueTrue()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.AnswerPhone(false, true, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForTrueFalseTrue()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.AnswerPhone(true, false, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForFalseFalseTrue()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.AnswerPhone(false, false, true);

            Assert.AreEqual(expected, actual);
        }
    }
}
