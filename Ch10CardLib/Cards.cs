using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ch11CardLib
{
    class Cards : CollectionBase
    {
        public void Add(Card newCard)
            => List.Add(newCard);
        public void Remove(Card newCard)
            => List.Remove(newCard);
        public Card this[int cardIndex]
        {
            get => (Card)List[cardIndex];
            set => List[cardIndex] = value;
        }
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
        ///<summary>
        /// Check to see if the Cards collection contains a particular card.
        /// This calls the Contains() method of the ArrayList for the colletion,
        /// which you access through the InnerList property.
        /// </summary>
        public bool Contains(Card myCard)
            => InnerList.Contains(myCard);

    }
}
