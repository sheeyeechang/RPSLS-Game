using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public abstract class Players
    {
        //member variable (HAS A)//
        public string name;
        public int score;
        public string gesture;
        public List<string> gestures;

        public int gameMode;

        //constructor (SPAWNER/DEFAULT)//
        public Players()
        {
            gestures = new List<string>();
            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Add("scissors");
            gestures.Add("lizard");
            gestures.Add("spock");

            gameMode = 0;
        }

        //member methods (CAN DO)//

        ////prompts player choice/Compare gesture/determine roun winner
        //CHOOSE GESTURE
        public abstract string ChooseGesture();

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
        ////Method that validates user input is a letter or number, and returns the input if it's true
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
    }
}



    
