using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queen_Attack_Messages;

namespace Queen_Attack
{
    public class Utility
    {
        public enum Share { Row, Column, Diagonal, Nothing};
        public int GetValidPosition(string color, string rightBottom)
        {
            Message.InputNumber(color, rightBottom);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input, color, rightBottom);
                }
                else
                {
                    if (CheckIfPositive(input) == false)
                    {
                        Message.MustBePositive(color, rightBottom);
                    }
                    else if (CheckIfTooHigh(input))
                    {
                        Message.IsTooHigh(color, rightBottom);
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

        public bool CheckIfPositive(string input)
        {
            return int.Parse(input) > 0;
        }

        public bool CheckIfTooHigh(string input)
        {
            return int.Parse(input) > 8;
        }

        public bool AreSamePosition(Queen blackQueen, Queen whiteQueen)
        {
            return blackQueen.Column == whiteQueen.Column && blackQueen.Row == whiteQueen.Row;
        }
        public Share DetermineRelationship(Queen blackQueen, Queen whiteQueen)
        {
            if (AreSameRow(blackQueen, whiteQueen))
            {
                return Share.Row;
            }
            else if (AreSameColumn(blackQueen, whiteQueen))
            {
                return Share.Column;
            }
            else if (AreSameDiagonal(blackQueen, whiteQueen))
            {
                return Share.Diagonal;
            }
            else
            {
                return Share.Nothing;
            }
        }

        public bool AreSameRow(Queen blackQueen, Queen whiteQueen)
        {
            return blackQueen.Row == whiteQueen.Row;
        }

        public bool AreSameColumn(Queen blackQueen, Queen whiteQueen)
        {
            return blackQueen.Column == whiteQueen.Column;
        }

        public bool AreSameDiagonal(Queen blackQueen, Queen whiteQueen)
        {
            return Math.Abs(blackQueen.Column - whiteQueen.Column) == Math.Abs(blackQueen.Row - whiteQueen.Row);
        }

        public void DisplayResults(Queen blackQueen, Queen whiteQueen, Share share)
        {
            switch (share)
            {
                case Share.Row:
                    Message.ShareSameRow(blackQueen.Row);
                    break;
                case Share.Column:
                    Message.ShareSameColumn(blackQueen.Column);
                    break;
                case Share.Diagonal:
                    Message.ShareSameDiagonal(Math.Abs(blackQueen.Row - whiteQueen.Row));
                    break;
                case Share.Nothing:
                    Message.CannotAttack();
                    break;
                default:
                    break;
            }
        }
    }
}