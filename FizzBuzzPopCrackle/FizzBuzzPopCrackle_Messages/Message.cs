using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzPopCrackle_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my FizzBuzzPopCrackle program where you will try to correctly answer what comes next in the FizzBuzzPopCrackle sequence where numbers divisible by 3 are replaced with Fizz, numbers divisible by 5 are replaced with Buzz, numbers\ndivisible by 7 are replaced with Pop, numbers divisible by 11 are replaced with crackle, numbers divisible by both 3 and 5 are replaced with FizzBuzz, numbers\ndivisible by both 3 and 7 are replaced with FizzPop, numbers divisible by both 3and 11 are replaced with FizzCrackle, numbers divisible by both 5 and 7 are\nreplaced with BuzzPop, numbers divisible by both both 5 and 11 are replaced withBuzzCrackle, numbers divisible by both 7 and 11 are replaced with PopCrackle,\nnumbers divisible by 3, 5, and 7 are replaced with FizzBuzzPop, numbers\ndivisible by 3, 5, and 11, are replaced with FizzPopCrackle, numbers divisible\nby 5, 7, and 11 are replaced with BuzzPopCrackle, and numbers divisible by 3, 5,7, and 11 are replaced with FizzBuzzPopCrackle. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterGuess(int num)
        {
            Console.WriteLine($"The next number in the sequence is {num}. What do you think {num} is:\nA) {num}\nB) Fizz\nC) Buzz\nD) Pop\nE) Crackle\nF) FizzBuzz\nG) FizzPop\nH) FizzCrackle\nI) BuzzPop\nJ) BuzzCrackle\nK) PopCrackle\nL) FizzBuzzPop\nM) FizzBuzzCrackle\nN) BuzzPopCrackle\nO) FizzBuzzPopCrackle");
        }

        public static void InvalidGuess(string input, int num)
        {
            Console.WriteLine($"\nSorry but {input} is not a valid guess. The next number in the\nsequence is {num}. What do you think {num} is:\nA) {num}\nB) Fizz\nC) Buzz\nD) Pop\nE) Crackle\nF) FizzBuzz\nG) FizzPop\nH) FizzCrackle\nI) BuzzPop\nJ) BuzzCrackle\nK) PopCrackle\nL) FizzBuzzPop\nM) FizzBuzzCrackle\nN) BuzzPopCrackle\nO) FizzBuzzPopCrackle");
        }

        public static void AnsweredCorrectly(string answer, int num)
        {
            Console.WriteLine($"\nCongratulations you guessed that {answer} is the representation of the\nnumber {num} in the FizzBuzzPopCrackle sequence and you were correct!!!\nPress enter to continue.");
            Console.ReadLine();
        }

        public static void AnsweredIncorrectly(string guess, string answer, int num)
        {
            Console.WriteLine($"\nUnfortunately you guessed that {guess} is the representation of the\nnumber {num} in the FizzBuzzPopCrackle sequence when the correct answer was\n{answer}. Press enter to continue.");
            Console.ReadLine();
        }

        public static void ThankYou(int score)
        {
            Console.WriteLine($"You correctly guessed {score} numbers in the FizzBuzzPopCrackle sequence. Press\nenter to close the program.");
        }
    }
}
