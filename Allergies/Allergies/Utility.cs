using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Allergies_Messages;

namespace Allergies
{
    public class Utility
    {
        public int GetValidAllergyScore()
        {
            Message.RequestAllergyScore();
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
                    if (CheckIfNegative(input))
                    {
                        Message.ScoreCannotBeNegative();
                    }
                    else if (CheckIfMoreThan255(input))
                    {
                        Message.ScoreCannotBeGreaterThan255();
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

        public bool CheckIfNegative(string input)
        {
            return int.Parse(input) < 0;
        }

        public bool CheckIfMoreThan255(string input)
        {
            return int.Parse(input) > 255;
        }

        public List<string> DetermineListOfAllergies(int allergyScore)
        {
            var allergyValues = new Dictionary<int, string>()
            {
                { 128, "cats"},
                { 64, "pollen"},
                { 32, "chocolate"},
                { 16, "tomatoes"},
                { 8, "strawberries"},
                { 4, "shellfish"},
                { 2, "peanuts"},
                { 1, "eggs"}
            };
            var listOfAllergies = new List<string>();
            foreach (var allergy in allergyValues)
            {
                if (allergy.Key <= allergyScore)
                {
                    listOfAllergies.Add(allergy.Value);
                    allergyScore -= allergy.Key;
                }
            }
            return listOfAllergies;
        }
    }
}
