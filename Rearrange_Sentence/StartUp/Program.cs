using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rearrange_Sentence;
using Rearrange_Sentence_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utililty = new Utility();
            var userString = utililty.GetValidString();
            var modifiedUserString = utililty.RemovePunctuation(userString);
            var words = utililty.MakeListOfWords(modifiedUserString);
            var randomizedWords = utililty.RandomizeWords(words);
            var newSentence = utililty.FormNewSentence(randomizedWords);
            Message.DisplayNewSentence(newSentence);
            Console.ReadLine();
        }
    }
}
