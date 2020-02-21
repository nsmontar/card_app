using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch10CardLib;
using static System.Console;

namespace Ch10CardClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            myDeck.Shuffle();
            for (int i = 0; i < 52; i++)
            {
                Write(myDeck.GetCard(i).ToString());
                if (i != 51) Write(", ");
                else WriteLine();

            }
            bool flushFlag = false;
            Random rndGen = new Random();
            int[] deckIndexArray = new int[5];
            Card[] tempCardArray = new Card[5];
            Suit[] drawedSuits = new Suit[5];
            for (int i = 1; i <= 50; i++)
            {
                do
                {
                    for (int j = 0; j < deckIndexArray.Length; j++)
                        deckIndexArray[j] = rndGen.Next(51);
                } while (deckIndexArray.Distinct().Count() < deckIndexArray.Length);
                for (int j = 0; j < deckIndexArray.Length; j++)
                {
                    tempCardArray[j] = myDeck.GetCard(deckIndexArray[j]);
                    drawedSuits[j] = tempCardArray[j].suit;
                }
                if (drawedSuits.Distinct().Count() == 1)
                {
                    WriteLine($"\nFlush at {i}. draw!");
                    Array.ForEach(tempCardArray, WriteLine);
                    flushFlag = true;
                    break;
                }
            }
            if (!flushFlag)
                WriteLine("\nNo Flush!");


            Deck deck1 = new Deck();
            Deck deck2 = (Deck)deck1.Clone();
            WriteLine($"The first card in the original deck is: {deck1.GetCard(0)}");
            WriteLine($"The first card in the cloned deck is: {deck2.GetCard(0)}");
            deck1.Shuffle();
            WriteLine("Original deck shuffled.");
            WriteLine($"The first card in the original deck is: {deck1.GetCard(0)}");
            WriteLine($"The first card in the cloned deck is: {deck2.GetCard(0)}");
            ReadKey();
            

        }
    }
}
