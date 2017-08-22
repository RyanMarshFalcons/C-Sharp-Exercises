using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MN_Balance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MN_Balance_Tests
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
        public void ReturnsTrueForF()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns7ForMMasdMjdfjdsMsdfsdhMsdhkMdfM()
        {
            var expected = 7;

            var utility = new Utility();
            var actual = utility.GetCount("MMasdMjdfjdsMsdfsdhMsdhkMdfM", "M");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns9Foradsfnnnasdfsdannnasdffdsannnasdffdsa()
        {
            var expected = 9;

            var utility = new Utility();
            var actual = utility.GetCount("adsfnnnasdfsdannnasdffdsannnasdffdsa", "n");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor5519()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfBalance(5, 5, 1, 9);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor31712()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfBalance(3, 1, 7, 12);

            Assert.AreEqual(expected, actual);
        }
    }
}
