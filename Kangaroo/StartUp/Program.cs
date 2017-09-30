using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kangaroo;
using Kangaroo_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var firstKangarooStartingPoint = utility.GetStartingDistance("first", 0);
            var secondKangarooStartingPoint = utility.GetStartingDistance("second", firstKangarooStartingPoint);
            var firstKangarooJumpDistance = utility.GetDistancePerJump("first");
            var secondKangarooJumpDistance = utility.GetDistancePerJump("second");
            var numJumps = utility.NumJumpsToReachSameSpot(firstKangarooStartingPoint, firstKangarooJumpDistance, secondKangarooStartingPoint, secondKangarooJumpDistance);
            if (numJumps == -1)
            {
                Message.WillNeverLandOnSameSpot();
            }
            else
            {
                var sameSpotDistance = utility.CalculateSameSpotDistance(firstKangarooStartingPoint, firstKangarooJumpDistance, numJumps);
                Message.DisplayHowManyJumps(numJumps, sameSpotDistance);
            }

            Console.ReadLine();
        }
    }
}
