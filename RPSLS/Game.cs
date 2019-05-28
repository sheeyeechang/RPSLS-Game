using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {
        //member variable (HAS A)//

        Players player1;
        Players player2;
        public int gameMode;

        //constructor (SPAWNER/DEFAULT)//
        public Game()
        {
            gameMode = 0;
        }

        //member methods (CAN DO)//
        public void RunGame()       
        {
            DisplayRules();
            PromptNumberOfPlayers();
            SetPlayers(gameMode);
            SetPlayerOneNames();
            SetPlayerTwoNames();

            while (DetermineWinner())
            {
                GameRoundLoop();
            }

            DetermineIfRestart();
        }

        public void GameRoundLoop()
        {
            MakeGesture();
            while (DetermineTie())
            {
                MakeGesture();
            }
            CompareGesture();
        }

        //display rules
        public void DisplayRules()
        {
            Console.WriteLine("RULES OF THE GAME:\nWelcome to the classic game: Rock Paper Scissors Lizard Spock." + "\n" + "\n" +
                "Scissors cuts Paper" + "\n" + "Paper covers Rock" + "\n" + "Rock crushes Lizard" + "\n" + "Lizard poisons Spock" + "\n" + "spock smashes scissors" + "\n" +
                "Scissors decapitates Lizard" + "\n" + "Lizard eats Paper" + "\n" + "Paper disproves Spock" + "\n" + "Spock vaporizes Rock" + "\n" + "\n" + "Best 2 out of 3 wins the game.");
        }
        //How many player
        public int GetNumberOfHumanPlayers()
        {
            Console.WriteLine("How many player: 1 or 2?");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            return numberOfPlayers;
        }
        //Set player
        public void SetPlayers(int numberOfPlayers)
        {
            if (numberOfPlayers == 1)
            {
                player1 = new Human();
                player2 = new AI();
                Console.WriteLine("This is a single player game!");
                Console.ReadLine();
            }
            else if (numberOfPlayers == 2)
            {
                player1 = new Human();
                player2 = new Human();
                Console.WriteLine("This is a multiplayer game!");
                Console.ReadLine();
            }
        }

        //prompt game mode user wants to play; Human vs AI or Human vs Human 
        public void PromptNumberOfPlayers()
        {
        gameMode = PromptInputNumber("Enter the game mode you would like to play: 1 = Human vs AI\t\t 2 = Human vs Human");                      
            if (gameMode != 1 && gameMode != 2)
            {
                Console.WriteLine("Invalid entry. Please enter 1 or 2:");
                PromptNumberOfPlayers();
            }

        }
        //method to validate user input is a number, and returns the input if it's true-- valide letter that not valid so need to enter number
        public int PromptInputNumber(string input)
        {
            int userInput = 0;
            do
            {
                Console.WriteLine(input);
                userInput = int.Parse(Console.ReadLine());
            }
            while (userInput == 0);
            return userInput;
        }

        //Set Player Names
        public void SetPlayerOneNames()
        {
            Console.WriteLine("Enter Player 1 name:");
            player1.name = Console.ReadLine();
            CheckPlayerOneName();
        }
        // Check Player One Name
        public void CheckPlayerOneName()
        {
            if (player1.name == string.Empty)
            {
                Console.WriteLine("Player 1 needs a name");
                Console.ReadLine();
                SetPlayerOneNames();
            }
        }
        public void SetPlayerTwoNames()
        { 
            Console.WriteLine("Enter Player 2 name:");
            player2.name = Console.ReadLine();
            CheckPlayerTwoName();
        }

        // Check Player Two Name
        public void CheckPlayerTwoName()
        {
            if (player2.name == string.Empty)
            {
                Console.WriteLine("Player 2 needs a name");
                Console.ReadLine();
                SetPlayerTwoNames();
            }
        }
        ////prompt for player choices
        //CHOOSE GESTURE
        public void MakeGesture()
        {
            Console.WriteLine("\nThe Game is starting!");
            Console.WriteLine("Player 1 choose a gesture: ");
            player1.ChooseGesture();
            Console.WriteLine("Player 2 choose a gesture: ");
            player2.ChooseGesture();
        }
        //Compare Guesture
        //returns winner of each round
        public void CompareGesture()
        {
            string playerGestures = player1.gesture + " vs " + player2.gesture;
            switch (playerGestures)
            {
                case ("rock vs scissors"):
                case ("scissors vs paper"):
                case ("paper vs rock"):
                case ("rock vs lizard"):
                case ("lizard vs spock"):
                case ("spock vs scissors"):
                case ("scissors vs lizard"):
                case ("lizard vs paper"):
                case ("paper vs spock"):
                case ("spock vs rock"):
                    Console.WriteLine(player1.name + " has won the round. To Continue: Press Enter");
                    Console.ReadLine();
                    player1.score++;
                    break;

                case ("scissors vs rock"):
                case ("paper vs scissors"):
                case ("rock vs paper"):
                case ("lizard vs rock"):
                case ("spock vs lizard"):
                case ("scissors vs spock"):
                case ("lizard vs scissors"):
                case ("paper vs lizard"):
                case ("spock vs paper"):
                case ("rock vs spock"):
                    Console.WriteLine(player2.name + " wins the round. To Continue: Press Enter");
                    Console.ReadLine();
                    player2.score++;
                    break;
            }

        }
        //Determine Winner
        public bool DetermineWinner()
        {
            if(player1.score > 1)
            {
                Console.WriteLine(player1.name + " is the winner! To Continue: Press Enter");
                Console.ReadLine();
                return false;
            }
            else if(player2.score > 1)
            {
                Console.WriteLine(player2.name + " is the winner! To Continue: Press Enter");
                Console.ReadLine();
                return false;
            }
            else
            {
                return true;
            }
        }
        //Determine if it's a tie
        public bool DetermineTie()
        {
            if (player1.gesture == player2.gesture)
            {
                Console.WriteLine("It's a tie! To Continue: Press Enter");
                Console.ReadLine();
                return true;
            }
            else
            {
                return false;
            }

        }
        public void DetermineIfRestart()
        {
            Console.WriteLine("Would you like to play again? Enter: 1 = Yes or 2 = No");
            string yesNo = Console.ReadLine().ToLower();

            switch (yesNo)
            {
                case "1":
                    RunGame();
                    break;
                case "2":
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    DetermineIfRestart();
                    break;
            }

        }
    }
}
