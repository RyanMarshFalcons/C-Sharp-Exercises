using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Palindrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class Testing
    {
        [TestMethod]
        public void returnsnamtaB()
        {
            var expected = "namtaB";

            var utility = new Utility();
            var actual = utility.InputInReverse("Batman");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsracecar()
        {
            var expected = "racecar";

            var utility = new Utility();
            var actual = utility.InputInReverse("racecar");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsryanisacoolguy()
        {
            var expected = "ryanisacoolguy";

            var utility = new Utility();
            var actual = utility.AdjustString("Ryan, is: A cool guy!");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsabc123dontrainonmyparade()
        {
            var expected = "abc123dontrainonmyparade";

            var utility = new Utility();
            var actual = utility.AdjustString("AbC123Don'tRainonMYpaRaDe!!!!");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsTrue()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.FindOutIfPalindrome("madam", "madam");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsFalse()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.FindOutIfPalindrome("weasel", "lesaew");

            Assert.AreEqual(expected, actual);
        }
    }
}
