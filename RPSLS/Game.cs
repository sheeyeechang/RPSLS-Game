using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            ////counter to keep track of whether to restart game or exit game
            int restart;
            do //loop to restart game
            {
                DisplayRules();
                PromptNumberOfPlayers();
                SetPlayers(gameMode);
                PromptNames();

                while (player1.player1Points < 3 && player2.player2Points < 3)//loop to run rounds until a player gets 2 points
                {
                    StartRound(gameMode);
                    //CalculateWinner(player1.player1Name, player2.player2Name, gameMode);
                    //player1.CalculatePoints(DetermineWinner(player1.player1Pick));
                    DisplayPoints();
                }
                restart = endGame();
                player1.player1Points = 0;
                player2.player2Points = 0;
                Console.Clear();
                //loop to run game until user wants to exit
            } while (restart == 1);

            Environment.Exit(0);
        }

        //display rules
        public void DisplayRules()
        {
            Console.WriteLine("RULES OF THE GAME:\n Welcome to the classic game: Rock Paper Scissors Lizard Spock.\n First player to 2 points will wins the game.");
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
            }
            else if (numberOfPlayers == 2)
            {
                player1 = new Human();
                player2 = new Human();
            }
        }

        //prompt game mode user wants to play; playervsplayer or playervsAI    
        public void PromptNumberOfPlayers()
        {
            //int gameMode, i = 0;
            do
            {
                gameMode = PromptInputNumber("Enter the game mode you would like to play: 1 = Human vs AI\t\t 2 = Human vs Human");
                
            } while (gameMode != 1 && gameMode != 2);
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
        //prompt player names
        public void PromptNames()
        {
            if (gameMode == 1)
            {
                player1.PromptPlayerName(1);
                player2.PromptPlayerName(2);
            }
            else if (gameMode == 2)
            {
                player1.PromptPlayerName(1);
                player2.PromptPlayerName(2);
            }
        }
        ////prompt for player choices
        //CHOOSE GESTURE
        public void StartRound(int gameMode)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nThe Game is starting!\n1: Scissors\t2: Paper\t3: Rock\n4: Lizard\t5: Spock");
            Console.ResetColor();
            if (gameMode == 1)
            {
                player1.PlayerChoice(player1.player1Name);
                player2.PlayerChoice(player2.player2Name);
            }
            else if (gameMode == 2)
            {
                player1.PlayerChoice(player1.player1Name);
                player1.PlayerChoice(player1.player2Name);
            }
        }

        //returns winner of each round
        //public int DetermineWinner(int player1Pick)
        //{
        //    if (gameMode == 1)
        //    {
        //        switch (player1Pick)
        //        {
        //            case 1: return scissor.CalculateWinner(player1.player1Name, player2.player2Name, player2.player2Pick);
        //            case 2: return paper.CalculateWinner(player1.player1Name, player2.player2Name, player2.player2Pick);
        //            case 3: return rock.CalculateWinner(player1.player1Name, player2.player2Name, player2.player2Pick);
        //            case 4: return lizard.CalculateWinner(player1.player1Name, player2.player2Name, player2.player2Pick);
        //            case 5: return spock.CalculateWinner(player1.player1Name, player2.player2Name, player2.player2Pick);
        //            default:
        //                Console.WriteLine("Invalid entry. Try again.\n");
        //                return 3;
        //        }
        //    }
        //    else
        //        switch (player1Pick)
        //        {
        //            case 1: return scissor.CalculateWinner(player1.player1Name, player2.player2Name, player2.player2Pick);
        //            case 2: return paper.CalculateWinner(player1.player1Name, player2.player2Name, player2.player2Pick);
        //            case 3: return rock.CalculateWinner(player1.player1Name, player2.player2Name, player2.player2Pick);
        //            case 4: return lizard.CalculateWinner(player1.player1Name, player2.player2Name, player2.player2Pick);
        //            case 5: return spock.CalculateWinner(player1.player1Name, player2.player2Name, player2.player2Pick);
        //            default:
        //                Console.WriteLine("Invalid entry. Try again.\n");
        //                return 3;
        //        }
        //}
        //display points
        public void DisplayPoints()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nScoreBoard:\t\t{player1.player1Name}: {player1.player1Points}\t{player2.player2Name}: {player2.player2Points}");
            Console.ResetColor();
        }
        //prompt the user to end game or play again
        public int endGame()
        {
            string winner;
            int endOfGame;
            int i = 0;
            if (player1.player1Points == 2)
            {
                winner = player1.player1Name;
            }
            else if (player2.player2Points == 2 && gameMode == 2)
            {
                winner = player2.player2Name;
            }
            else
            {
                winner = player2.player2Name;
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\n\n{winner} is the winner!");
            Console.ResetColor();
            do
            {
                if (i > 0)
                {

                    Console.WriteLine("Invalid entry.Try again.\n");
                }
                endOfGame = PromptInputNumber("Would you like to play again? 1= yes\t2= no"); //TestNumber);
                i++;

            } while (endOfGame == 0 || endOfGame > 2);

            return endOfGame;
        }
    }
}
