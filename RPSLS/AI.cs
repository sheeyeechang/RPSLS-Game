using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class AI : Players
    {
        //member variable (HAS A)//

        Random randomizeChoice;

        //constructor (SPAWNER/DEFAULT)//
        public AI()
        {
            randomizeChoice = new Random();
        }

        //member methods (CAN DO)//

        public override string ChooseGesture()
        {
            foreach (string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
            int gestureRoll = randomizeChoice.Next(5);
            switch (gestureRoll)
            {
                case 0:
                    gesture = "rock";
                    break;
                case 1:
                    gesture = "paper";
                    break;
                case 2:
                    gesture = "scissors";
                    break;
                case 3:
                    gesture = "lizard";
                    break;
                case 4:
                    gesture = "spock";
                    break;

            }
            Console.WriteLine("Player chose " + gesture + ". Press enter to continue.");
            Console.ReadLine();
            return gesture;
        }
    }
}
