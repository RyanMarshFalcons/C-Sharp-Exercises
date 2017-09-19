using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queen_Attack;
using Queen_Attack_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var blackQueen = new Queen();
            blackQueen.Column = utility.GetValidPosition("Black", "right");
            blackQueen.Row = utility.GetValidPosition("Black", "bottom");
            var whiteQueen = new Queen();
            do
            {
                whiteQueen.Column = utility.GetValidPosition("White", "right");
                whiteQueen.Row = utility.GetValidPosition("White", "bottom");
                if (utility.AreSamePosition(blackQueen, whiteQueen))
                {
                    Message.SquareAlreadyOccupied(blackQueen.Column, blackQueen.Row);
                }
            } while (utility.AreSamePosition(blackQueen, whiteQueen));
            var share = utility.DetermineRelationship(blackQueen, whiteQueen);
            utility.DisplayResults(blackQueen, whiteQueen, share);
            Console.ReadLine();
        }
    }
}
