using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Answer_Phone;
using Answer_Phone_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            Message.FamilyAndFriends();
            var familyOrFriend = utility.YesOrNo();
            Message.Busy();
            var busy = utility.YesOrNo();
            Message.Asleep();
            var sleeping = utility.YesOrNo();
            var answerPhone = utility.AnswerPhone(familyOrFriend, busy, sleeping);
            utility.DisplayResults(answerPhone);
            Console.ReadLine();
        }
    }
}
