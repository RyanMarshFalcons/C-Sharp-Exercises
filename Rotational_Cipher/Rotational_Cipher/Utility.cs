using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rotational_Cipher_Messages;

namespace Rotational_Cipher
{
    public class Utility
    {
        public string GetValidMessage()
        {
            var userInput = "";
            var validEntry = false;
            Message.RequestUserString();
            while (!validEntry)
            {
                userInput = Console.ReadLine();
                if (CheckIfTooShort(userInput))
                {
                    Message.TooShort();
                }
                else if (CheckIfContainsAnyLetters(userInput) == false)
                {
                    Message.HasNoLetters();
                }
                else
                {
                    validEntry = true;
                }
            }
            return userInput;
        }

        public bool CheckIfTooShort(string input)
        {
            return input.Length < 1;
        }

        public bool CheckIfContainsAnyLetters(string input)
        {
            return input.Any(x => char.IsLetter(x));
        }

        public int GetValidRotation()
        {
            Message.InputNumber();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input);
                }
                else
                {
                    if (CheckIfOutOfRange(input))
                    {
                        Message.OutOfRange(input);
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return int.Parse(input);
        }

        public bool CheckIfInt(string input)
        {
            var num = 0;
            return int.TryParse(input, out num);
        }

        public bool CheckIfOutOfRange(string input)
        {
            return int.Parse(input) < 1 || int.Parse(input) > 25;
        }

        public string EncryptMessage(string userMessage, int rotationAmount)
        {
            var userStringArray = userMessage.ToCharArray();
            var originalLetter = ' ';
            var newLetter = ' ';
            for (int i = 0; i < userStringArray.Length; i++)
            {
                if (Char.IsLetter(userStringArray[i]))
                {
                    originalLetter = userStringArray[i];
                    newLetter = (Char)(originalLetter + rotationAmount);
                    if (Char.IsLower(userStringArray[i]))
                    {
                        if (newLetter > 'z')
                        {
                            newLetter = (Char)(originalLetter + rotationAmount - 26);
                        }
                    }
                    else
                    {
                        if (newLetter > 'Z')
                        {
                            newLetter = (Char)(originalLetter + rotationAmount - 26);
                        }
                    }
                    userStringArray[i] = newLetter;
                }
            }
            return new string(userStringArray);
        }
    }
}
