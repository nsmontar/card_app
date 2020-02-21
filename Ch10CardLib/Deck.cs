using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11CardLib
{
    public class Deck
    {
        private Cards cards = new Cards();
        public Deck()
        {
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    cards.Add(new Card((Rank)rankVal, (Suit)suitVal));
                }
            }
        }
        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
            {
                return cards[cardNum];
            }
            else
            {
                throw new ArgumentOutOfRangeException("cardNum", cardNum,
                    "Value must be between 0 and 51.");
            }
            
        }
        public void Shuffle()
        {
            Cards newDeck = new Cards();
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();
            int sourceCard = 0;
            for (int i = 0; i < 52; i++)
            {
                bool foundCard = false;
                while (!foundCard)
                {
                    sourceCard = sourceGen.Next(52);
                    if (assigned[sourceCard] == false)
                        foundCard = true;
                }
                assigned[sourceCard] = true;
                newDeck.Add(cards[sourceCard]);
            }
            newDeck.CopyTo(cards);
        }
    }
}
