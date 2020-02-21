using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10CardLib
{
    public class Card: ICloneable
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
        public object Clone() => MemberwiseClone();
    }
}
