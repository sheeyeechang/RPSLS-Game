using System;
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
        public string name;


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


        //Choose gesture
        public abstract string ChooseGesture();

        //    //prompts player choice/Compare gesture/determine roun winner
        //    public void PlayerChoice(string playerName)
        //    {
        //        int choice, i = 0;
        //        do
        //        {
        //            if (i < 0)
        //            {
        //                Console.WriteLine("Invalid entry.Try again.\n");
        //            }
        //            choice = PromptInputNumber($"{playerName}, please enter your choice: ", TestNumber);
        //            i++;
        //        } while (choice == 0 || choice > 4);
        //        if (playerName == player1Name)
        //        {
        //            player1Pick = choice;
        //        }
        //        else if (playerName == player2Name)
        //        {
        //            player2Pick = choice;
        //        }
        //    }
        //    //calculate points for each player
        //    public void CalculatePoints(int points)
        //    {
        //        if (points == 1)
        //        {
        //            player1Points++;
        //        }
        //        else if (points == 2)
        //        {
        //            player2Points++;
        //        }
        //    }
        //    //method to validate user input is a number
        //    public bool TestNumber(string input)
        //    {
        //        bool testedInput = numbers.IsMatch(input);
        //        if (testedInput && input != "")
        //        {
        //            return (true);
        //        }
        //        else
        //            Console.WriteLine("Invalid entry. Try again.\n");
        //        return (false);
        //    }
        //    //method to validate user input is a number, and returns the input if it's true
        //    public int PromptInputNumber(string input, Func<string, bool> test)
        //    {
        //        string userInput;
        //        do
        //        {
        //            Console.WriteLine(input);
        //            userInput = Console.ReadLine();
        //        } while (!test(userInput));
        //        int gameMode = int.Parse(userInput);
        //        return gameMode;
        //    }
        //    //Method that validates user input is a letter or number, and returns the input if it's true
        //    public string PromptInputLetters(string name, Func<string, bool> testLetters)
        //    {
        //        string playerName;
        //        do
        //        {
        //            Console.Write(name);
        //            playerName = Console.ReadLine();
        //        } while (!testLetters(playerName));
        //        return playerName;
        //    }
        //    //Method that validates user input is a letter or number
        //    public bool TestLetters(string playerName)
        //    {
        //        bool testedInput = letters.IsMatch(playerName);
        //        if (testedInput && playerName != "")
        //        {
        //            return (true);
        //        }
        //        else
        //            return (false);
        //    }       
        //} 
    }
}



    
