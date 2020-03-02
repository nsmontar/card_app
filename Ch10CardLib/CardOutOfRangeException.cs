using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10CardLib
{
    public class CardOutOfRangeException : Exception
    {
        private Cards deckContents;
        public Cards DeckContents
        {
            get => deckContents;
        }
        public CardOutOfRangeException(Cards sourceDeckContents)
            : base("There are only 52 cards in the deck.")
        {
            deckContents = sourceDeckContents;
        }
    }
}
