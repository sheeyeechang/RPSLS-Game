using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Human : Players
    {
        //member variable (HAS A)//

        //constructor (SPAWNER/DEFAULT)//
        public Human()
        {

        }

        //member methods (CAN DO)//

        ////Prompts player names
        //public override void PromptPlayerName(int playerNumber)
        //{
        //    base.PromptPlayerName(playerNumber);
        //}

        ////prompts player choice
        ///CHOOSE GESTURE
        public override string ChooseGesture()
        {
            foreach (string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
            gesture = Console.ReadLine().ToLower();
            if (gesture == "rock" || gesture == "paper" || gesture == "scissors" || gesture == "lizard" || gesture == "spock")
            {
                Console.WriteLine("Player chose " + gesture + ". Press enter to continue.");
                Console.ReadLine();
                return gesture;
            }
            else
            {
                Console.WriteLine("Invalid input! Choose from:");
                return ChooseGesture();
            }
        }
    }
}
