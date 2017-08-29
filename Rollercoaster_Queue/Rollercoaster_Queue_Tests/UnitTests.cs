using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rollercoaster_Queue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rollercoaster_Queue_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForEmptyString()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForH()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("H");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor12point54()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("12.654");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForCashew()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("cashew");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor0point1()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("0.1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor0point0()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("0.0");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor300And200()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfRoomOnCar(300, 200);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor300And201()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfRoomOnCar(300, 201);

            Assert.AreEqual(expected, actual);
        }
    }
}
