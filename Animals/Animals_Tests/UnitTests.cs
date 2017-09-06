using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Animals_Tests
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
        public void ReturnsTrueForH()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("H");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForI()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("I");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForJ()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("J");

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
        public void ReturnsFalseFors()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("s");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsCatForA()
        {
            var expected = TypeOfAnimal.Cat;

            var utility = new Utility();
            var actual = utility.ConvertLetterToAnimalType("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsCowForB()
        {
            var expected = TypeOfAnimal.Cow;

            var utility = new Utility();
            var actual = utility.ConvertLetterToAnimalType("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsCrocodileForC()
        {
            var expected = TypeOfAnimal.Crocodile;

            var utility = new Utility();
            var actual = utility.ConvertLetterToAnimalType("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsDogForD()
        {
            var expected = TypeOfAnimal.Dog;

            var utility = new Utility();
            var actual = utility.ConvertLetterToAnimalType("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsGoldfishForE()
        {
            var expected = TypeOfAnimal.Goldfish;

            var utility = new Utility();
            var actual = utility.ConvertLetterToAnimalType("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsGooseForF()
        {
            var expected = TypeOfAnimal.Goose;

            var utility = new Utility();
            var actual = utility.ConvertLetterToAnimalType("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsParrotForG()
        {
            var expected = TypeOfAnimal.Parrot;

            var utility = new Utility();
            var actual = utility.ConvertLetterToAnimalType("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsToadfishForH()
        {
            var expected = TypeOfAnimal.Toadfish;

            var utility = new Utility();
            var actual = utility.ConvertLetterToAnimalType("H");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTurtleForI()
        {
            var expected = TypeOfAnimal.Turtle;

            var utility = new Utility();
            var actual = utility.ConvertLetterToAnimalType("I");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForEmptyString()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsTooShort("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForc()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsTooShort("c");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor5()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("5");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForFive()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("Five");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative7()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-7");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor7()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("7");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueAgainForA()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGender("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueAgainForB()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGender("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForC()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidGender("C");

            Assert.AreEqual(expected, actual);
        }
    }
}
