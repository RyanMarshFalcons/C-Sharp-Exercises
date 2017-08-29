using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stack_Of_Plates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Stack_Of_Plates_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForA()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForB()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForC()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForD()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForE()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForF()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForG()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForH()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("H");

            Assert.AreEqual(expected, actual);
        }

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
        public void ReturnsFalseFort()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("t");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsBlueForA()
        {
            var expected = "Blue";

            var utility = new Utility();
            var actual = utility.ConvertLetterToColor("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRedForB()
        {
            var expected = "Red";

            var utility = new Utility();
            var actual = utility.ConvertLetterToColor("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsGreenForC()
        {
            var expected = "Green";

            var utility = new Utility();
            var actual = utility.ConvertLetterToColor("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsYellowForD()
        {
            var expected = "Yellow";

            var utility = new Utility();
            var actual = utility.ConvertLetterToColor("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsPurpleForE()
        {
            var expected = "Purple";

            var utility = new Utility();
            var actual = utility.ConvertLetterToColor("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsPinkForF()
        {
            var expected = "Pink";

            var utility = new Utility();
            var actual = utility.ConvertLetterToColor("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsOrangeForG()
        {
            var expected = "Orange";

            var utility = new Utility();
            var actual = utility.ConvertLetterToColor("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor1()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfFound(1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNegative1()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfFound(-1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3ForA()
        {
            var expected = 3;

            var utility = new Utility();
            var plateStack = new Stack<string>();
            plateStack.Push("A");
            plateStack.Push("B");
            plateStack.Push("C");
            var actual = utility.RetrievePlate(plateStack, "A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2ForB()
        {
            var expected = 2;

            var utility = new Utility();
            var plateStack = new Stack<string>();
            plateStack.Push("B");
            plateStack.Push("E");
            plateStack.Push("B");
            plateStack.Push("G");
            plateStack.Push("B");
            plateStack.Push("G");
            var actual = utility.RetrievePlate(plateStack, "B");

            Assert.AreEqual(expected, actual);
        }
    }
}
