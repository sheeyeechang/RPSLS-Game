﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Players
    {
        //member variable (HAS A)//
        public int score;
        public string gesture;
        public List<string> gestures;
        public string player1Name;
        public string player2Name;
        public int player1Points;
        public int player2Points;
        public int player1Pick;
        public int player2Pick;
        public int gameMode;


        //constructor (SPAWNER/DEFAULT)//
        public Players()
        {
            gestures = new List<string>();
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
        }

        //    //member methods (CAN DO)//

        //    //prompt player names
        //    public string PlayerName(string word)
        //    {
        //        Console.WriteLine($"Enter a player name:{word}");
        //        string name = Console.ReadLine();
        //        return name;
        //    }
        //prompt player name
        //Method that validates user input is a letter or number, and returns the input if it's true
        public string PromptInputLetters(string name)
        {
            string playerName = "";
            do
            {
                Console.WriteLine(name);
                playerName = Console.ReadLine();
            }
            while (playerName.Length < 1);
            return playerName;
        }


        public virtual void PromptPlayerName(int playerNumber)
        {
            if (playerNumber == 1)
            {
                player1Name = PromptInputLetters($"\nEnter a Player {playerNumber} name: ");
            }
            else
                player2Name = PromptInputLetters($"\nEnter a Player {playerNumber} name: ");

        }

        //    //Set player name
        //    public void SetPlayerName(string name)
        //    {
        //        if (name == 1)
        //        {
        //            name = new Human();
        //            name = new AI();
        //        }
        //        else if (playerName == 2)
        //        {
        //            player1Name = new Human();
        //            player2Name = new Human();
        //        }
        //    }


        //method to validate user input is a number, and returns the input if it's true
        public int PromptInputNumber(string input)
        {
            string userInput;
            do
            {
                Console.WriteLine(input);
                userInput = Console.ReadLine();
            }
            while (userInput == null);
            try
            {
                int gameMode = int.Parse(userInput);
            }
            catch
            {
                return PromptInputNumber(input);

            }
            return gameMode;
        }

        //CHOOSE GESTURE
        public abstract string ChooseGesture();

        ////prompts player choice/Compare gesture/determine roun winner
        public void PlayerChoice(string playerName)
        {
            int choice, i = 0;
            do
            {
                if (i < 0)
                {
                    Console.WriteLine("Invalid entry.Try again.\n");
                }
                choice = PromptInputNumber($"{playerName}, please enter your choice: ");
                i++;
            } while (choice == 1 || choice < 6);
            if (playerName == player1Name)
            {
                player1Pick = choice;
            }
            else if (playerName == player2Name)
            {
                player2Pick = choice;
            }
        }
        //    //calculate points for each player
        public void CalculatePoints(int points)
        {
            if (points == 1)
            {
                player1Points++;
            }
            else if (points == 2)
            {
                player2Points++;
            }
        }
        //Method calculates who wins
        public int CalculateWinner(string player1Name, string player2Name, int player1Pick)
        {
            switch (player1Pick)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n{player1Name}: Rock\n{player2Name}: Scissor\n{player1Name} wins this round");
                    Console.ResetColor();
                    return 1;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{player1Name}: Rock\n{player2Name}: Paper\n{player2Name} Wins this round!");
                    Console.ResetColor();
                    return 1;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\n{player1Name}: Rock\n{player2Name}: Rock\nIt's a tie!");
                    Console.ResetColor();
                    return 0;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n{player1Name}: Rock\n{player2Name}: Lizard\n{player1Name} wins this round");
                    Console.ResetColor();
                    return 1;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{player1Name}: Rock\n{player2Name}: Spock\n{player2Name} Wins this round");
                    Console.ResetColor();
                    return 1;
                default:
                    return 0;
            }
        }
    }
}



    
