using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sock_Merchant
{
    public class SockTracker
    {
        public List<Color> MatchingPairs { get; set; }

        public List<Color> UnmatchedSocks { get; set; }

        public int TotalNumberOfSocks()
        {
            return MatchingPairs.Count * 2 + UnmatchedSocks.Count;
        }
    }
}
