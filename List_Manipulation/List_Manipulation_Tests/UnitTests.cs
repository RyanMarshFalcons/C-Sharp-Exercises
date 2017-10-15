using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using List_Manipulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace List_Manipulation_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void EmptyStringIsTooShortAString()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsTooShort("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneCharacterIsLongEnoughForAString()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsTooShort("X");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AIsAValidManipulationLetterSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BIsAValidManipulationLetterSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CIsAValidManipulationLetterSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DIsAValidManipulationLetterSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EIsAValidManipulationLetterSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FIsAValidManipulationLetterSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GIsAValidManipulationLetterSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HIsAValidManipulationLetterSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("H");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IIsAValidManipulationLetterSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("I");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void JIsAnInvalidManipulationLetterSelection()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("J");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsAddLetterToBeginningForA()
        {
            var expected = Manipulation.Add_Letter_To_Beginning;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsAddLetterToEndForB()
        {
            var expected = Manipulation.Add_Letter_To_End;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsCapitalizeLettersForC()
        {
            var expected = Manipulation.Capitalize_Letters;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsDeleteShortStringsForD()
        {
            var expected = Manipulation.Delete_Short_Strings;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsDeleteLongStringsForE()
        {
            var expected = Manipulation.Delete_Long_Strings;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsAddNumberToBeginningForF()
        {
            var expected = Manipulation.Add_Number_To_Beginning;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsAddNumberToEndForG()
        {
            var expected = Manipulation.Add_Number_To_End;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsAddDollarSignToBeginningForH()
        {
            var expected = Manipulation.Add_Dollar_Sign_To_Beginning;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("H");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsAddExclamationPointToEndForI()
        {
            var expected = Manipulation.Add_Exclamation_Point_To_End;

            var utility = new Utility();
            var actual = utility.ConvertLetterToManipulation("I");

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
        public void ReturnsFalseForr()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("r");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SevenIsNotALetter()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLetter("7");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NoIsNotALetter()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLetter("No");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NIsALetter()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLetter("N");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LIsNotANumber()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNumber("L");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuestionMarkIsNotANumber()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNumber("?");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NineIsANumber()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNumber("9");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QIsNotAValidLength()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidLength("Q");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZeroIsNotAValidLength()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidLength("0");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneIsAValidLength()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidLength("1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddsAToBeginningOfEachStringInList()
        {
            var expected = new List<string>() { "ARyan", "Ais", "Aawesome" };

            var utility = new Utility();
            var actual = utility.AddToBeginning(new List<string>() { "Ryan", "is", "awesome"}, "A");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Adds5ToBeginningOfEachStringInList()
        {
            var expected = new List<string>() { "5Ryan", "5is", "5awesome" };

            var utility = new Utility();
            var actual = utility.AddToBeginning(new List<string>() { "Ryan", "is", "awesome" }, "5");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddsDollarSignToBeginningOfEachStringInList()
        {
            var expected = new List<string>() { "$Ryan", "$is", "$awesome" };

            var utility = new Utility();
            var actual = utility.AddToBeginning(new List<string>() { "Ryan", "is", "awesome" }, "$");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddsAToEndOfEachStringInList()
        {
            var expected = new List<string>() { "RyanA", "isA", "awesomeA" };

            var utility = new Utility();
            var actual = utility.AddToEnd(new List<string>() { "Ryan", "is", "awesome" }, "A");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Adds5ToEndOfEachStringInList()
        {
            var expected = new List<string>() { "Ryan5", "is5", "awesome5" };

            var utility = new Utility();
            var actual = utility.AddToEnd(new List<string>() { "Ryan", "is", "awesome" }, "5");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddsExclamationPointToEndOfEachStringInList()
        {
            var expected = new List<string>() { "Ryan!", "is!", "awesome!" };

            var utility = new Utility();
            var actual = utility.AddToEnd(new List<string>() { "Ryan", "is", "awesome" }, "!");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CapitalizesAllTheLettersOfEachStringInList()
        {
            var expected = new List<string>() { "RYAN", "IS", "AWESOME!" };

            var utility = new Utility();
            var actual = utility.CapitalizeLetters(new List<string>() { "Ryan", "is", "awesome!" });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemovesStringShorterThan3CharactersFromList()
        {
            var expected = new List<string>() { "Ryan", "awesome", "guy" };

            var utility = new Utility();
            var actual = utility.RemoveShortStrings(new List<string>() { "Ryan", "is", "an", "awesome", "guy" }, 3);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemovesStringLongerThan3CharactersFromList()
        {
            var expected = new List<string>() { "is", "an", "guy" };

            var utility = new Utility();
            var actual = utility.RemoveLongStrings(new List<string>() { "Ryan", "is", "an", "awesome", "guy" }, 3);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
