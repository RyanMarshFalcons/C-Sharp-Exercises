using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Answer_Phone_Messages;

namespace Answer_Phone
{
    public class Utility
    {
        public bool YesOrNo()
        {
            var IsValidInput = false;
            var input = "";
            while (IsValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfyOrn(input) == false)
                {
                    Message.NotyOrn();
                }
                else
                {
                    IsValidInput = true;
                }
            }
            if (input == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckIfyOrn(string input)
        {
            if ((input == "y") || (input == "n"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AnswerPhone(bool familyOrFriend, bool busy, bool asleep)
        {
            if (asleep || (busy && !familyOrFriend))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void DisplayResults(bool answerPhone)
        {
            if (answerPhone)
            {
                Message.DoAnswerPhone();
            }
            else
            {
                Message.DontAnswerPhone();
            }
        }
    }
}
