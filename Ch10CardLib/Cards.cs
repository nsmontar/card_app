using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ch10CardLib
{
    class Cards : List<Card>, ICloneable
    {
        ///<summary>
        /// Untility method for copying card instances into another Cards
        /// instance=used in Deck.Shuffle(). This implementation assumes that
        /// source and target collections are the same size.
        /// </summary>
        public void CopyTo(Cards targetCards)
        {
            for (int index = 0; index < this.Count; index++)
                targetCards[index] = this[index];
        }

        public object Clone()
        {
            Cards copiedCards = new Cards();
            foreach (Card sourceCard in this)
                copiedCards.Add((Card)sourceCard.Clone());
            return copiedCards;
        }
        
    }
}
