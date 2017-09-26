using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atbash_Cipher_Messages;

namespace Atbash_Cipher
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

        public string EncryptMessage(string userMessage)
        {
            var lowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
            var uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var index = 0;
            var userStringArray = userMessage.ToCharArray();
            for (int i = 0; i < userStringArray.Length; i++)
            {
                if (Char.IsLetter(userStringArray[i]))
                {
                    if (Char.IsLower(userStringArray[i]))
                    {
                        index = lowercaseLetters.IndexOf(userStringArray[i]);
                        userStringArray[i] = lowercaseLetters[25 - index];
                    }
                    else
                    {
                        index = uppercaseLetters.IndexOf(userStringArray[i]);
                        userStringArray[i] = uppercaseLetters[25 - index];
                    }
                }
            }
            return new string(userStringArray);
        }
    }
}
