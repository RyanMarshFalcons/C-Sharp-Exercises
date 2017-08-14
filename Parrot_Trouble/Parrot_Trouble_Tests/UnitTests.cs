using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parrot_Trouble;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Parrot_Trouble_Tests
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
        public void ReturnsFalseFord()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("d");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForTrueTrueTrue()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfCausingTrouble(true, true, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForTrueTrueFalse()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfCausingTrouble(true, true, false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForTrueFalseTrue()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfCausingTrouble(true, false, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForFalseTrueTrue()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfCausingTrouble(false, true, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForFalseFalseTrue()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfCausingTrouble(false, false, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForFalseTrueFalse()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfCausingTrouble(false, true, false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForTrueFalseFalse()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfCausingTrouble(true, false, false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForFalseFalseFalse()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfCausingTrouble(false, false, false);

            Assert.AreEqual(expected, actual);
        }
    }
}
