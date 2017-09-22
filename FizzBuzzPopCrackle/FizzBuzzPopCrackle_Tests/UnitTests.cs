using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzPopCrackle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzPopCrackle_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void AIsAValidGuess()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BIsAValidGuess()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CIsAValidGuess()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DIsAValidGuess()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EIsAValidGuess()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FIsAValidGuess()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GIsAValidGuess()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HIsAValidGuess()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("H");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IIsAValidGuess()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("I");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void JIsAValidGuess()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("J");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KIsAValidGuess()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("K");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LIsAValidGuess()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("L");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MIsAValidGuess()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("M");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NIsAValidGuess()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("N");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OIsAValidGuess()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("O");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PIsNotAValidGuess()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidGuess("P");

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
        public void ReturnsCrackleForE11()
        {
            var expected = "Crackle";

            var utility = new Utility();
            var actual = utility.ConvertLetterToGuess("E", 11);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFizzBuzzForF15()
        {
            var expected = "FizzBuzz";

            var utility = new Utility();
            var actual = utility.ConvertLetterToGuess("F", 15);

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void ReturnsFizzPopForG21()
        {
            var expected = "FizzPop";

            var utility = new Utility();
            var actual = utility.ConvertLetterToGuess("G", 21);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFizzCrackleForH33()
        {
            var expected = "FizzCrackle";

            var utility = new Utility();
            var actual = utility.ConvertLetterToGuess("H", 33);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsBuzzPopForI35()
        {
            var expected = "BuzzPop";

            var utility = new Utility();
            var actual = utility.ConvertLetterToGuess("I", 35);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsBuzzCrackleForJ55()
        {
            var expected = "BuzzCrackle";

            var utility = new Utility();
            var actual = utility.ConvertLetterToGuess("J", 55);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsPopCrackleForK77()
        {
            var expected = "PopCrackle";

            var utility = new Utility();
            var actual = utility.ConvertLetterToGuess("K", 77);

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void ReturnsFizzBuzzPopForL105()
        {
            var expected = "FizzBuzzPop";

            var utility = new Utility();
            var actual = utility.ConvertLetterToGuess("L", 105);

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
        public void Returns1For1()
        {
            var expected = "1";

            var utility = new Utility();
            var actual = utility.CalculateCorrectAnswer(1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2For2()
        {
            var expected = "2";

            var utility = new Utility();
            var actual = utility.CalculateCorrectAnswer(2);

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
        public void ReturnsCrackleFor22()
        {
            var expected = "Crackle";

            var utility = new Utility();
            var actual = utility.CalculateCorrectAnswer(22);

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
        public void ReturnsFizzCrackleFor66()
        {
            var expected = "FizzCrackle";

            var utility = new Utility();
            var actual = utility.CalculateCorrectAnswer(66);

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
        public void ReturnsBuzzCrackleFor110()
        {
            var expected = "BuzzCrackle";

            var utility = new Utility();
            var actual = utility.CalculateCorrectAnswer(110);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsPopCrackleFor154()
        {
            var expected = "PopCrackle";

            var utility = new Utility();
            var actual = utility.CalculateCorrectAnswer(154);

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
        public void ReturnsFizzBuzzCrackleFor330()
        {
            var expected = "FizzBuzzCrackle";

            var utility = new Utility();
            var actual = utility.CalculateCorrectAnswer(330);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsBuzzPopCrackleFor770()
        {
            var expected = "BuzzPopCrackle";

            var utility = new Utility();
            var actual = utility.CalculateCorrectAnswer(770);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFizzBuzzPopCrackleFor2310()
        {
            var expected = "FizzBuzzPopCrackle";

            var utility = new Utility();
            var actual = utility.CalculateCorrectAnswer(2310);

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

        [TestMethod]
        public void ReturnsTrueFor11()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsCrackle(11);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor12()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsCrackle(12);

            Assert.AreEqual(expected, actual);
        }
    }
}
