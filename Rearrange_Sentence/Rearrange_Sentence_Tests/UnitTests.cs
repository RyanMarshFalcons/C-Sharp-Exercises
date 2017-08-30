using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rearrange_Sentence;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rearrange_Sentence_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForRyanisa()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsToShort("Ryan is a");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForRyanisan()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsToShort("Ryan is an");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemovesPunctuationFromSusiemyfriendShesfromSaintAndrewstoo()
        {
            var expected = "Susie my friend She's from Saint-Andrews too";

            var utility = new Utility();
            var actual = utility.RemovePunctuation("Susie, my friend. She's from Saint-Andrews too!!!");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemovesPunctuationFromOyyoutherewhatsyerbusnesere()
        {
            var expected = "Oy you there What's yer bus'nes 'ere";

            var utility = new Utility();
            var actual = utility.RemovePunctuation("Oy, you there! What's yer bus'nes 'ere?");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MakesAListFromRyanisacoolguy()
        {
            var expected = new List<string>() { "Ryan", "is", "a", "cool", "guy" };

            var utility = new Utility();
            var actual = utility.MakeListOfWords("Ryan is a cool guy");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MakesAListFromItwasadarkandstormyWintersnight()
        {
            var expected = new List<string>() { "It", "was", "a", "dark", "and", "stormy", "Winter's", "night" };

            var utility = new Utility();
            var actual = utility.MakeListOfWords("It was a dark and stormy Winter's night");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MakesASentenceFromcoolaRyanguyis()
        {
            var expected = "Cool a Ryan guy is.";

            var utility = new Utility();
            var actual = utility.FormNewSentence(new List<string>() { "cool", "a", "Ryan", "guy", "is" });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MakesASentenceFromdarkanightstormyItWintersandwas()
        {
            var expected = "Dark a night stormy It Winter's and was.";

            var utility = new Utility();
            var actual = utility.FormNewSentence(new List<string>() { "dark", "a", "night", "stormy", "It", "Winter's", "and", "was"});

            Assert.AreEqual(expected, actual);
        }
    }
}
