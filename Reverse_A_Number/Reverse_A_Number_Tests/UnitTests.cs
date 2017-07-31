﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reverse_A_Number;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reverse_A_Number_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void returnsFalseforT()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("T");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsTrueFor5()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("16");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returns8642For2468()
        {
            var expected = "8642";

            var utility = new Utility();
            var actual = utility.InputInReverse("2468");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returns521776For677125()
        {
            var expected = "521776";

            var utility = new Utility();
            var actual = utility.InputInReverse("677125");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returns30180For08103()
        {
            var expected = "30180";

            var utility = new Utility();
            var actual = utility.InputInReverse("08103");

            Assert.AreEqual(expected, actual);
        }
    }
}