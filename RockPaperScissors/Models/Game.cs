/*
Rock v. Scissors = Rock wins
Rock v. Paper = Paper wins
Paper v. Scissors = Scissors wins
*/

using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    public class Game
    {
        private string playerOne = "";
        private string playerTwo = "";

        public static void Main()
        {
            new Game().DisplayMenu();
        }

        public void DisplayMenu()
        {
            Console.WriteLine("*** Rock Paper Scissors Game ***");
            Console.WriteLine("Enter An Option: (P)lay / (Q)uit");
            string choice = Console.ReadLine();
            ReadChoice(choice);
        }

        public void ReadChoice(string choice)
        {
            if(choice.ToLower() == "p")
            {
                Console.WriteLine("Player 1: Enter Rock / Paper / Scissors");
                playerOne = Console.ReadLine();
                Console.WriteLine("Player 2: Enter Rock / Paper / Scissors");
                playerTwo = Console.ReadLine();
                PlayGame(playerOne, playerTwo);
            }
            else if(choice.ToLower() == "q")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("That option don't exist yo!");
                DisplayMenu();
            }
        }

        public void PlayGame(string player1, string player2)
        {
            string winner = FindWinner(player1, player2);
            Console.WriteLine("The winner is " + winner + "!");
            DisplayMenu();
        }

        public string FindWinner(string player1, string player2)
        {
            string winner = "";
            while(winner == "")
            {
                if(InputsMatch(player1, player2) != String.Empty)
                {
                    winner = InputsMatch(player1, player2);
                }
                else if(RockWins(player1, player2) != String.Empty)
                {
                    winner = RockWins(player1, player2);
                }
                else if(ScissorsWins(player1, player2) != String.Empty)
                {
                    winner = ScissorsWins(player1, player2);
                }
                else if(PaperWins(player1, player2) != String.Empty)
                {
                    winner = PaperWins(player1, player2);
                }
                else
                {
                    winner = "Don't be like Elly";
                }
            }

            return winner;

        }

        public string InputsMatch(string input1, string input2)
        {
            if(input1 == input2)
            {
                return "draw";
            }
            else
            {
                return String.Empty;
            }
        }

        public string RockWins(string input1, string input2)
        {
            if((input1 == "rock" && input2 == "scissors") || (input1 == "scissors" && input2 == "rock"))
            {
                return "rock";
            }
            else
            {
                return String.Empty;
            }
        }

        public string ScissorsWins(string input1, string input2)
        {
            if((input1 == "scissors" && input2 == "paper") || (input1 == "paper" && input2 == "scissors"))
            {
                return "scissors";
            }
            else
            {
                return String.Empty;
            }
        }

        public string PaperWins(string input1, string input2)
        {
            if((input1 == "paper" && input2 == "rock") || (input1 == "rock" && input2 == "paper"))
            {
                return "paper";
            }
            else
            {
                return String.Empty;
            }
        }

    }
}
