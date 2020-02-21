using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11CardLib
{
    public class Card
    {
        public readonly Suit suit;
        public readonly Rank rank;
        public Card(Rank newRank, Suit newSuit)
        {
            rank = newRank;
            suit = newSuit;
        }
        public override string ToString()
            => $"The {rank} of {suit}s";
    }
}
