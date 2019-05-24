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

        //constructor (SPAWNER/DEFAULT)//
        public Game()
        {

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
            //Choose gesture
        public void MakeGesture(string gesture)
            {
                player1.ChooseGesture(gesture);
                player2.ChooseGesture(gesture);
            }
        

        //Display round winner 
        public int CalculateWinner(int player1, int player2)
        {
            switch (player1)
            {
                case 1:
                    Console.WriteLine($"\n{player1}: Rock\n{player2}: Scissor\n{player1} wins this round");
                    return 1;
                case 2:
                    Console.WriteLine($"\n{player1}: Rock\n{player2}: Paper\n{player2} Wins this round!");
                    return 1;
                case 3:
                    Console.WriteLine($"\n{player1}: Rock\n{player2}: Rock\nIt's a tie!");
                    return 0;
                case 4:
                    Console.WriteLine($"\n{player1}: Rock\n{player2}: Lizard\n{player1} wins this round");
                    return 1;
                case 5:
                    Console.WriteLine($"\n{player1}: Rock\n{player2}: Spock\n{player2} Wins this round");
                    return 1;
                default:
                    return 2;
            }
        }
        ////display points
        //public void DisplayPoints()
        //{
        //    Console.WriteLine($"\nScoreBoard:\t\t{player.player1Name}: {player.player1Points}\t{player.player2Name}: {player.player2Points}");
        //}

        ////returns winner of each round
        //public int DetermineWinner(int player1Pick)
        //{
        //    if (determineWinner == 1)
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

        ////returns winner of each round
        //public void RoundIncrementer()
        //{
        //    int round = 0;
        //    bool playGame = true;
        //    while (playGame)
        //    {
        //        if (round == 3)
        //        {
        //            playGame = false;
        //        }
        //        round++;
        //    }

        //}
        
        ////prompt the user to end game or play again
        //public int endGame()
        //{
        //    string winner;
        //    int endOfGame;
        //    int i = 0;
        //    if (player.player1Points == 3)
        //    {
        //        winner = player.player1Name;
        //    }
        //    else if (player.player2Points == 3 && gameMode == 2)
        //    {
        //        winner = player.player2Name;
        //    }
        //    else
        //    {
        //        winner = ai.player2Name;
        //    }
        //    Console.ForegroundColor = ConsoleColor.Magenta;
        //    Console.WriteLine($"\n\n{winner} is the winner!");
        //    Console.ResetColor();
        //    do
        //    {
        //        if (i > 0)
        //        {
        //            Console.WriteLine("Invalid entry.Try again.\n");
        //        }
        //        endOfGame = PromptInputNumber("Would you like to play again? 1= yes\t2= no", TestNumber);
        //        i++;
        //    } while (endOfGame == 0 || endOfGame > 2);
        //    return endOfGame;
        //}
        ////initial method that gets called to run the game
        public void RunGame()
        {
            //    int restart;
            //    do //loop to restart game
            //    {
            //        DisplayRules();
            //        PromptNumberOfPlayers();
            //        PromptNames(gameMode);
            //        while (player.player1Points < 3 && player.player2Points < 3)//loop to run rounds until a player gets 3 points
            //        {
            //            StartRound(gameMode);
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
