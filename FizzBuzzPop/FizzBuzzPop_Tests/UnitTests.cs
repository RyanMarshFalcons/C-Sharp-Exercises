using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzPop;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzPop_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForA()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForB()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForC()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForD()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForE()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForF()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForG()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForH()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("H");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForI()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("I");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2ForA2()
        {
            var expected = "2";

            var utility = new Utility();
            var actual = utility.ConvertLetterToGuess("A", 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFizzForB3()
        {
            var expected = "Fizz";

            var utility = new Utility();
            var actual = utility.ConvertLetterToGuess("B", 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsBuzzForC5()
        {
            var expected = "Buzz";

            var utility = new Utility();
            var actual = utility.ConvertLetterToGuess("C", 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsPopForD7()
        {
            var expected = "Pop";

            var utility = new Utility();
            var actual = utility.ConvertLetterToGuess("D", 7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFizzBuzzForE15()
        {
            var expected = "FizzBuzz";

            var utility = new Utility();
            var actual = utility.ConvertLetterToGuess("E", 15);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFizzPopForF21()
        {
            var expected = "FizzPop";

            var utility = new Utility();
            var actual = utility.ConvertLetterToGuess("F", 21);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsBuzzPopForG35()
        {
            var expected = "BuzzPop";

            var utility = new Utility();
            var actual = utility.ConvertLetterToGuess("G", 35);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFizzBuzzPopForH105()
        {
            var expected = "FizzBuzzPop";

            var utility = new Utility();
            var actual = utility.ConvertLetterToGuess("H", 105);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFizzFor6()
        {
            var expected = "Fizz";

            var utility = new Utility();
            var actual = utility.CalculateCorrectAnswer(6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsBuzzFor10()
        {
            var expected = "Buzz";

            var utility = new Utility();
            var actual = utility.CalculateCorrectAnswer(10);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsPopFor14()
        {
            var expected = "Pop";

            var utility = new Utility();
            var actual = utility.CalculateCorrectAnswer(14);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFizzBuzzFor30()
        {
            var expected = "FizzBuzz";

            var utility = new Utility();
            var actual = utility.CalculateCorrectAnswer(30);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFizzPopFor42()
        {
            var expected = "FizzPop";

            var utility = new Utility();
            var actual = utility.CalculateCorrectAnswer(42);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsBuzzPopFor70()
        {
            var expected = "BuzzPop";

            var utility = new Utility();
            var actual = utility.CalculateCorrectAnswer(70);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFizzBuzzPopFor210()
        {
            var expected = "FizzBuzzPop";

            var utility = new Utility();
            var actual = utility.CalculateCorrectAnswer(210);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor3()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsFizz(3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor4()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsFizz(4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor5()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsBuzz(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor6()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsBuzz(6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor7()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsPop(7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor8()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsPop(8);

            Assert.AreEqual(expected, actual);
        }
    }
}
