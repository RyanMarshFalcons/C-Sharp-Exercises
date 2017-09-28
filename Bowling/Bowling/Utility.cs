using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bowling_Messages;

namespace Bowling
{
    public class Utility
    {

        public Frame GetFrame(int frameNumber)
        {
            var frame = new Frame();
            frame.FirstRoll = GetValidRoll("first", frameNumber, 0);
            if (frame.FirstRoll != 10)
            {
                frame.SecondRoll = GetValidRoll("second", frameNumber, frame.FirstRoll);
            }
            return frame;
        }

        public int ExtraRoll(string firstSecond)
        {
            return GetValidRoll(firstSecond + " bonus", 11, 0);
        }
        
        public int GetValidRoll(string firstSecond, int frameNumber, int pinsAlreadyKnockedDown)
        {
            Message.InputNumber(firstSecond, frameNumber);
            var isValidInput = false;
            var input = "";
            while (!isValidInput)
            {
                input = Console.ReadLine();
                if (!CheckIfInt(input))
                {
                    Message.NotANumber(input, firstSecond, frameNumber);
                }
                else
                {
                    if (CheckIfOutOfRange(input))
                    {
                        Message.OutOfRange(input, firstSecond, frameNumber);
                    }
                    else if (!CheckIfEnoughPinsLeft(input, pinsAlreadyKnockedDown))
                    {
                        Message.NotEnoughPinsLeft(input, pinsAlreadyKnockedDown, frameNumber);
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

        public bool CheckIfOutOfRange(string input)
        {
            return int.Parse(input) < 0 || int.Parse(input) > 10;
        }

        public bool CheckIfEnoughPinsLeft(string input, int pinsAlreadyKnockedDown)
        {
            return int.Parse(input) <= 10 - pinsAlreadyKnockedDown;
        }

        public int CalculateScore(List<Frame> frames)
        {
            var score = 0;
            for (int i = 0; i < 9; i++)
            {
                score += frames[i].FirstRoll + frames[i].SecondRoll;
                if (frames[i].WasSpare() || frames[i].WasStrike())
                {
                    score += frames[i + 1].FirstRoll;
                }
                if (frames[i].WasStrike())
                {
                    if (!frames[i + 1].WasStrike())
                    {
                        score += frames[i + 1].SecondRoll;
                    }
                    else
                    {
                        score += frames[i + 2].FirstRoll;
                    }
                }
            }
            score += frames[9].FirstRoll + frames[9].SecondRoll;
            if (frames[9].WasSpare() || frames[9].WasStrike())
            {
                score += frames[10].FirstRoll;
                if (frames[9].WasStrike())
                {
                    score += frames[10].SecondRoll;
                }
            }
            return score;
        }

    }
}
