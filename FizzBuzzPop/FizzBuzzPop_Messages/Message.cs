using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzPop_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my FizzBuzzPop program where you will try to correctly answer what\ncomes next in the FizzBuzzPop sequence where numbers divisible by 3 are replacedwith the word Fizz, numbers divisible by 5 with the word Buzz, numbers divisibleby 7 with the word Pop, numbers divisible by both 3 and 5 with the word FizzBuzznumbers divisible by both 3 and 7 with the word FizzPop, numbers divisible by\nboth 5 and 7 with the word BuzzPop, and numbers divisible by 3, 5, and 7 with\nthe word FizzBuzzPop. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterGuess(int num)
        {
            Console.WriteLine($"The next number in the sequence is {num}. What do you think comes next:\nA) {num}\nB) Fizz\nC) Buzz\nD) Pop\nE) FizzBuzz\nF) FizzPop\nG) BuzzPop\nH) FizzBuzzPop");
        }

        public static void InvalidGuess(string input, int num)
        {
            Console.WriteLine($"\nSorry but {input} is not a valid guess. The next number in the sequence is {num}.\nWhat do you think comes next:\nA) {num}\nB) Fizz\nC) Buzz\nD) Pop\nE) FizzBuzz\nF) FizzPop\nG) BuzzPop\nH) FizzBuzzPop");
        }

        public static void AnsweredCorrectly(string answer, int num)
        {
            Console.WriteLine($"\nCongratulations you guessed that {answer} is the representation of the\nnumber {num} in the FizzBuzzPop sequence and you were correct!!! Press enter to\ncontinue.");
            Console.ReadLine();
        }

        public static void AnsweredIncorrectly(string guess, string answer, int num)
        {
            Console.WriteLine($"\nUnfortunately you guessed that {guess} is the representation of the number\n{num} in the FizzBuzzPop sequence when the correct answer was {answer}.\nPress enter to continue.");
            Console.ReadLine();
        }

        public static void ThankYou(int score)
        {
            Console.WriteLine($"You correctly guessed {score} numbers in the FizzBuzzPop sequence. Press enter\nto close the program.");
        }
    }
}
