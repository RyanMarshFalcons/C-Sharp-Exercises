using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzPopCrackle;
using FizzBuzzPopCrackle_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userGuessAsLetter = "";
            var userGuess = "";
            var correctAnswer = "";
            var score = 0;
            for (int num = 1; num < 1000000; num++)
            {
                userGuessAsLetter = utility.GetValidGuess(num);
                userGuess = utility.ConvertLetterToGuess(userGuessAsLetter, num);
                correctAnswer = utility.CalculateCorrectAnswer(num);
                if (userGuess == correctAnswer)
                {
                    Message.AnsweredCorrectly(userGuess, num);
                    score += 1;
                }
                else
                {
                    Message.AnsweredIncorrectly(userGuess, correctAnswer, num);
                    break;
                }
            }
            Message.ThankYou(score);
            Console.ReadLine();
        }
    }
}
