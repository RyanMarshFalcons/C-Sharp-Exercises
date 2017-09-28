using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bowling;
using Bowling_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var frames = new List<Frame>();
            for (int i = 1; i < 11; i++)
            {
                frames.Add(utility.GetFrame(i));
            }
            if (frames[9].WasSpare() || frames[9].WasStrike())
            {
                frames.Add(new Frame() { FirstRoll = utility.ExtraRoll("first") });
                if (frames[9].WasStrike())
                {
                    frames[10].SecondRoll = utility.ExtraRoll("second");
                }
            }
            var score = utility.CalculateScore(frames);
            Message.DisplayScore(score);
            Console.ReadLine();
        }
    }
}
