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
        public int numbers;
  
        //constructor (SPAWNER/DEFAULT)//
        public Game()
        {

            gameMode = 0;

        }

        //member methods (CAN DO)//

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

        //method to validate user input is a number
        //public void TestNumber(string input)
        //{
        //    int num = 0;
        //    try
        //    {
        //        num = int.Parse(input);
        //        numbers = Math.Abs(num);
        //    }catch(Exception e)
        //    {
        //        numbers = 0;
        //    }            
        //}

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
                //try
                //{
                //    input = int.Parse(userInput);
                //}
                //catch
                //{
                //    return PromptInputNumber(input);
                //}
        }
        //prompt player names
        public void PromptNames()
        {
            if (gameMode == 1)
            {
                player1.PromptPlayerName(1);
            }
            else if (gameMode == 2)
            {
                player1.PromptPlayerName(1);
                player2.PromptPlayerName(2);

            }
        }
        ////CHOOSE GESTURE
        public void MakeGesture()
        {
            player1.ChooseGesture();
            player2.ChooseGesture();
        }

        //prompt for player choices
        public void StartRound(int gameMode)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nThe Game is starting!\n1: Scissors\t2: Paper\t3: Rock\n4: Lizard\t5: Spock");
            Console.ResetColor();
            if (gameMode == 1)
            {
                player1.PlayerChoice(player1.player1Name);
                //player2.PlayerChoice(player2.player2Name);
            }
            else if (gameMode == 2)
            {
                player1.PlayerChoice(player1.player1Name);
                player2.PlayerChoice(player2.player2Name);
            }
        }

        //returns winner of each round
        //public int DetermineWinner(int player1Pick)
        //{
        //    if (gameMode == 1)
        //    {
        //        switch (player1Pick)
        //        {
        //            case 1: return scissor.CalculateWinner(player.player1Name, ai.player2Name, ai.player2Pick);
        //            case 2: return paper.CalculateWinner(player.player1Name, ai.player2Name, ai.player2Pick);
        //            case 3: return rock.CalculateWinner(player.player1Name, ai.player2Name, ai.player2Pick);
        //            case 4: return lizard.CalculateWinner(player.player1Name, ai.player2Name, ai.player2Pick);
        //            case 5: return spock.CalculateWinner(player.player1Name, ai.player2Name, ai.player2Pick);
        //            default:
        //                Console.WriteLine("Invalid entry. Try again.\n");
        //                return 3;
        //        }
        //    }
        //    else
        //        switch (player1Pick)
        //        {
        //            case 1: return scissor.CalculateWinner(player.player1Name, player.player2Name, player.player2Pick);
        //            case 2: return paper.CalculateWinner(player.player1Name, player.player2Name, player.player2Pick);
        //            case 3: return rock.CalculateWinner(player.player1Name, player.player2Name, player.player2Pick);
        //            case 4: return lizard.CalculateWinner(player.player1Name, player.player2Name, player.player2Pick);
        //            case 5: return spock.CalculateWinner(player.player1Name, player.player2Name, player.player2Pick);
        //            default:
        //                Console.WriteLine("Invalid entry. Try again.\n");
        //                return 3;
        //        }
        //}


        ////display points
        //public void DisplayPoints()
        //{
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    Console.WriteLine($"\nScoreBoard:\t\t{player.player1Name}: {player.player1Points}\t{player.player2Name}: {player.player2Points}");
        //    Console.ResetColor();
        //}
        ////initial method that gets called to run the game
        public void RunGame()
        {
            //    int restart;
            //    do //loop to restart game
            //    {
            DisplayRules();
            PromptNumberOfPlayers();
            SetPlayers(gameMode);
            PromptNames();
            MakeGesture();


            while (player1.player1Points < 3 && player2.player2Points < 3)//loop to run rounds until a player gets 2 points
            {
                StartRound(gameMode);
                //            player.CalculatePoints(DetermineWinner(player.player1Pick));
                //            DisplayPoints();
                //        }
                //        restart = endGame();
                //        player.player1Points = 0;
                //        player.player2Points = 0;
                //        Console.Clear();
                //    } while (restart == 1);
                //    Environment.Exit(0);
            }
        }
    }
}
