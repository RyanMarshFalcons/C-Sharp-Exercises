using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insert_Character;
using Insert_Character_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetString();
            var userCharacter = utility.GetCharacter();
            var index = utility.GetIndex(userString.Length, userCharacter);
            var newString = utility.GetNewString(userString, index, userCharacter);
            Message.DisplayNewString(newString);
            Console.ReadLine();
        }
    }
}
