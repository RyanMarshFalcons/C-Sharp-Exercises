using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rollercoaster_Queue_Messages;

namespace Rollercoaster_Queue
{
    public class Utility
    {
        public string GetName(int personNumber)
        {
            var userInput = "";
            var validEntry = false;
            Message.RequestName(personNumber);
            while (!validEntry)
            {
                userInput = Console.ReadLine();
                if (CheckIfTooShort(userInput))
                {
                    Message.NotAValidName(personNumber);
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

        public double GetValidWeight(string name)
        {
            Message.RequestWeight(name);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfDouble(input) == false)
                {
                    Message.NotANumber(input, name);
                }
                else
                {
                    if (CheckIfPositive(input) == false)
                    {
                        Message.NotAvalidWeight(name);
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return double.Parse(input);
        }

        public bool CheckIfDouble(string input)
        {
            var num = 0.0;
            return double.TryParse(input, out num);
        }

        public bool CheckIfPositive(string input)
        {
            return double.Parse(input) > 0;
        }

        public bool CheckIfRoomOnCar(double placeholder, double personsWeight)
        {
            return placeholder + personsWeight <= 500;
        }
    }
}
