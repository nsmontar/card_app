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
            // Display introduction.
            WriteLine("BenjaminCards: a new and exciting card game.");
            WriteLine("To win you must have 7 cards of the same suit in your hand.");
            WriteLine();
            // Prompt for number of players
            bool inputOK = false;
            int numPlayers = -1;
            do
            {
                WriteLine("How many players (2-7)?");
                string input = ReadLine();
                try
                {
                    // Attempt to convert input into a valid number of players
                    numPlayers = Convert.ToInt32(input);
                    if (numPlayers >= 2 && numPlayers <= 7)
                        inputOK = true;
                }
                catch
                {
                    // Ignore failed conversion, just keep prompting
                }
            } while (!inputOK);
            // Initialize array of Player objects
            Player[] players = new Player[numPlayers];
            for (int i = 0; i < players.Length; i++)
            {
                WriteLine($"Please enter name of Player {i + 1}");
                players[i] = new Player(ReadLine());
            }
            // Start game
            Game myGame = new Game();
            myGame.SetPlayers(players);
            int WhoWon = myGame.PlayGame();
            // Display winning player.
            WriteLine($"{players[WhoWon].Name} has won the game!");
            ReadKey();
        }
    }
}
