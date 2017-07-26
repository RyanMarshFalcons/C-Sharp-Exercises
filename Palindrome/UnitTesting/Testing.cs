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

            var manipulation = new Manipulation();
            var actual = manipulation.InputInReverse("Batman");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsracecar()
        {
            var expected = "racecar";

            var manipulation = new Manipulation();
            var actual = manipulation.InputInReverse("racecar");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsryanisacoolguy()
        {
            var expected = "ryanisacoolguy";

            var manipulation = new Manipulation();
            var actual = manipulation.AdjustString("Ryan, is: A cool guy!");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsabc123dontrainonmyparade()
        {
            var expected = "abc123dontrainonmyparade";

            var manipulation = new Manipulation();
            var actual = manipulation.AdjustString("AbC123Don'tRainonMYpaRaDe!!!!");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsTrue()
        {
            var expected = true;

            var manipulation = new Manipulation();
            var actual = manipulation.FindOutIfPalindrome("madam", "madam");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsFalse()
        {
            var expected = false;

            var manipulation = new Manipulation();
            var actual = manipulation.FindOutIfPalindrome("weasel", "lesaew");

            Assert.AreEqual(expected, actual);
        }
    }
}
