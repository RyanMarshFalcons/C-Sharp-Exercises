using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company_Roster_Messages;

namespace Company_Roster
{
    public enum TypeOfPerson { Customer, Employee };
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
                    Message.NotAValidPersonTypeSelection(input);
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
                default:
                    return TypeOfPerson.Employee;
                    break;
            }
        }

        public Person MakeNewPerson(TypeOfPerson personType)
        {
            switch (personType)
            {
                case TypeOfPerson.Customer:
                    var customer = new Customer();
                    customer.Person_Type = TypeOfPerson.Customer;
                    return customer;
                    break;
                case TypeOfPerson.Employee:
                default:
                    var employee = new Employee();
                    employee.Person_Type = TypeOfPerson.Employee;
                    return employee;
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

        public string GetPrefixSelection(string name)
        {
            var userInput = "";
            Message.AskPrefix(name);
            var validInput = false;
            while (validInput == false)
            {
                userInput = Console.ReadLine();
                if (IsValidPrefixSelection(userInput) == false)
                {
                    Message.InvalidPrefixSelection(userInput, name);
                }
                else
                {
                    validInput = true;
                }
            }
            return userInput;
        }

        public bool IsValidPrefixSelection(string input)
        {
            return input == "A" || input == "B" || input == "C" || input == "D";
        } 

        public Prefix ConvertLetterToPrefix(string prefixSelection)
        {
            switch (prefixSelection)
            {
                case "A":
                    return Prefix.Mr;
                    break;
                case "B":
                    return Prefix.Mrs;
                    break;
                case "C":
                    return Prefix.Ms;
                    break;
                case "D":
                default:
                    return Prefix.Miss;
                    break;
            }
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
            return input.Length < 15;
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

        public string GetPhoneNumber(string name)
        {
            var userInput = "";
            Message.AskPhoneNumber(name);
            var validInput = false;
            while (validInput == false)
            {
                userInput = Console.ReadLine();
                if (PhoneNumberIsTooShort(userInput))
                {
                    Message.PhoneNumberNotLongEnough(name);
                }
                else
                {
                    if (HasLetters(userInput))
                    {
                        Message.PhoneNumberHasLetters(name);
                    }
                    else
                    {
                        validInput = true;
                    }
                }
            }
            return userInput;
        }

        public bool PhoneNumberIsTooShort(string input)
        {
            return input.Length < 10;
        }

        public bool HasLetters(string input)
        {
            var foundLetter = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]))
                {
                    foundLetter = true;
                }
            }
            return foundLetter;
        }

        public int GetCreditCardNumber(string name)
        {
            var userInput = "";
            Message.AskCreditCardNumber(name);
            var validInput = false;
            while (validInput == false)
            {
                userInput = Console.ReadLine();
                if (CheckIfInt(userInput) == false)
                {
                    Message.CreditCardNotAllNumbers(name);
                }
                else
                {
                    if (CheckIfValidCreditCardLength(userInput))
                    {
                        Message.InvalidCreditCardLength(name);
                    }
                    else
                    {
                        validInput = true;
                    }
                }
            }
            return int.Parse(userInput);
        }

        public bool CheckIfInt(string input)
        {
            int result;
            return int.TryParse(input, out result);
        }

        public bool CheckIfValidCreditCardLength(string input)
        {
            return input.Length >= 13 && input.Length <= 16;
        }

        public string GetJobTitle(string name)
        {
            var userInput = "";
            Message.AskJobTitle(name);
            var validInput = false;
            while (validInput == false)
            {
                userInput = Console.ReadLine();
                if (JobTitleIsTooShort(userInput))
                {
                    Message.JobTitleTooShort(name);
                }
                else
                {
                    validInput = true;
                }
            }
            return userInput;
        }

        public bool JobTitleIsTooShort(string input)
        {
            return input.Length < 4;
        }

        public string GetDepartmentSelection(string name, string jobTitle)
        {
            var userInput = "";
            Message.AskDepartment(name, jobTitle);
            var validInput = false;
            while (validInput == false)
            {
                userInput = Console.ReadLine();
                if (IsValidDepartmentSelection(userInput) == false)
                {
                    Message.InvalidDepartmentSelection(userInput, name, jobTitle);
                }
                else
                {
                    validInput = true;
                }
            }
            return userInput;
        }

        public bool IsValidDepartmentSelection(string input)
        {
            return input == "A" || input == "B" || input == "C" || input == "D" || input == "E" || input == "F" || input == "G";
        }

        public Department ConvertLetterToDepartment(string departmentSelection)
        {
            switch (departmentSelection)
            {
                case "A":
                    return Department.Accounting;
                    break;
                case "B":
                    return Department.IT;
                    break;
                case "C":
                    return Department.Sales;
                    break;
                case "D":
                    return Department.Human_Resources;
                    break;
                case "E":
                    return Department.Customer_Service;
                    break;
                case "F":
                    return Department.Product_Development;
                    break;
                case "G":
                default:
                    return Department.Custodial;
                    break;
            }
        }

        public double GetSalary(string name, string jobTitle, Department department)
        {
            var userInput = "";
            Message.AskSalary(name, jobTitle, department.ToString());
            var validInput = false;
            while (validInput == false)
            {
                userInput = Console.ReadLine();
                if (CheckIfDouble(userInput) == false)
                {
                    Message.SalaryNotANumber(userInput, name, jobTitle, department.ToString());
                }
                else
                {
                    if (CheckIfValidSalary(userInput) == false)
                    {
                        Message.SalaryTooLow(name, jobTitle, department.ToString());
                    }
                    else
                    {
                        validInput = true;
                    }
                }
            }
            return double.Parse(userInput);
        }

        public bool CheckIfDouble(string input)
        {
            var result = 0.0;
            return double.TryParse(input, out result);
        }

        public bool CheckIfValidSalary(string input)
        {
            return double.Parse(input) > 15000;
        }

    }
}
