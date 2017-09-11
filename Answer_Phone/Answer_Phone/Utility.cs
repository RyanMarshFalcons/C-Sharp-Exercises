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
            return input == "y";
        }

        public bool CheckIfyOrn(string input)
        {
            return input == "y" || input == "n"; 
        }

        public bool AnswerPhone(bool familyOrFriend, bool busy, bool asleep)
        {
            return !asleep && (!busy || familyOrFriend);
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
