using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company_Roster_Messages;

namespace Company_Roster
{
    public enum TypeOfPerson { Customer, Employee, Manager };
    public class Utility
    {
        public string GetValidPersonSelection()
        {
            Message.SelectPersonType();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfValidSelection(input) == false)
                {
                    Message.NotAValidSelection(input);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return input;
        }

        public bool CheckIfValidSelection(string input)
        {
            return input == "A" || input == "B" || input == "C";
        }
        public bool AskToContinue()
        {
            var IsValidInput = false;
            var input = "";
            Message.AddAnotherPerson();
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

        public TypeOfPerson ConvertLetterToPersonType(string selection)
        {
            switch (selection)
            {
                case "A":
                    return TypeOfPerson.Customer;
                    break;
                case "B":
                    return TypeOfPerson.Employee;
                    break;
                case "C":
                default:
                    return TypeOfPerson.Manager;
                    break;
            }
        }

        public Person MakeNewPerson(TypeOfPerson personType)
        {
            switch (personType)
            {
                case TypeOfPerson.Customer:
                    return new Customer();
                    break;
                case TypeOfPerson.Employee:
                    return new Employee();
                    break;
                case TypeOfPerson.Manager:
                default:
                    return new Manager();
                    break;
            }
        }

        public string GetName(string personType, string firstLast)
        {
            var userInput = "";
            Message.AskName(personType, firstLast);
            var validInput = false;
            while (validInput == false)
            {
                userInput = Console.ReadLine();
                if (NameIsTooShort(userInput))
                {
                    Message.NameNotLongEnough(personType, firstLast);
                }
                else
                {
                    validInput = true;
                }
            }
            return userInput;
        }

        public bool NameIsTooShort(string input)
        {
            return input.Length < 1;
        }

        public string GetEmail(string name)
        {
            var userInput = "";
            Message.AskEmail(name);
            var validInput = false;
            while (validInput == false)
            {
                userInput = Console.ReadLine();
                if (EmailIsTooShort(userInput))
                {
                    Message.EmailNotLongEnough(name);
                }
                else
                {
                    if (ContainsAtAndDot(userInput) == false)
                    {
                        Message.EmailLacksAtAndDot(name);
                    }
                    else
                    {
                        validInput = true;
                    }
                }
            }
            return userInput;
        }

        public bool EmailIsTooShort(string input)
        {
            return input.Length < 7;
        }

        public bool ContainsAtAndDot(string input)
        {
            var containsAt = false;
            var containsDot = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '@')
                {
                    containsAt = true;
                }
                if (input[i] == '.')
                {
                    containsDot = true;
                }
            }
            return containsAt == true && containsDot == true;
        }

        public string GetAddress(string name, string homeBillingShipping)
        {
            var userInput = "";
            Message.AskAddress(name, homeBillingShipping);
            var validInput = false;
            while (validInput == false)
            {
                userInput = Console.ReadLine();
                if (AdressIsTooShort(userInput))
                {
                    Message.AdressNotLongEnough(name, homeBillingShipping);
                }
                else
                {
                    if (HasNumbers(userInput) == false)
                    {
                        Message.AdressLacksNumbers(name, homeBillingShipping);
                    }
                    else
                    {
                        validInput = true;
                    }
                }
            }
            return userInput;
        }

        public bool AdressIsTooShort(string input)
        {
            return input.Length < 10;
        }

        public bool HasNumbers(string input)
        {
            var foundNumber = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsNumber(input[i]))
                {
                    foundNumber = true;
                }
            }
            return foundNumber;
        }




    }
}
