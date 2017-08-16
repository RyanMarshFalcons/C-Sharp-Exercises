using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Del_del_Messages;

namespace Del_del
{
    public class Utility
    {
        public string GetString ()
        {
            var userInput = "";
            var validEntry = false;
            Message.RequestUserInput();
            while (!validEntry)
            {
                userInput = Console.ReadLine();
                if (CheckIfTooShort(userInput))
                {
                    Message.AtLeastThreeCharacters();
                }
                else
                {
                    validEntry = true;
                }
            }
            return userInput;
        }

        public bool CheckIfTooShort (string input)
        {
            return input.Length < 3;
        }

        public int FindIndex (string userString)
        {
            var delAt = userString.IndexOf("del");
            var DelAt = userString.IndexOf("Del");
            if ((delAt == -1) && (DelAt == -1))
            {
                return -1;
            }
            else if ((delAt == -1) && (DelAt != -1))
            {
                return DelAt;
            }
            else if ((delAt != -1) && (DelAt == -1))
            {
                return delAt;
            }
            else if (delAt < DelAt)
            {
                return delAt;
            }
            else
            {
                return DelAt;
            }
        }
        
        public string DeleteFromdelDelOnward (string userString, int index)
        {
            if (index == 0)
            {
                return "an empty string";
            }
            else
            {
                return userString.Substring(0, userString.Length - (userString.Length - index));
            }
        }    
    }
}
