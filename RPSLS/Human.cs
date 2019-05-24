using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Players
    {
        //member variable (HAS A)//

        //constructor (SPAWNER/DEFAULT)//
        public Human()
        {

        }

        ////member methods (CAN DO)//
        ////Prompts player names
        //public override void PlayerName(string word)
        //{
        //    base.PlayerName(word);
        //}
        ////Set player name
        //public override void SetPlayerName(string name)
        //{
        //    base.SetPlayerName(name);
        //}
        ////Choose Gesture
        public override string ChooseGesture()
        {
            Console.WriteLine("Enter a gesture: Rock or Paper or Scissors or Lizard or Spock");
            string gesture = Console.ReadLine();
            switch (gesture)
            {
                case "Rock":
                    return gesture;
                case "Paper":
                    return gesture;
                case "Scissors":
                    return gesture;
                case "Lizard":
                    return gesture;
                case "Scope":
                    return gesture;
                default:
                    return ChooseGesture();
            }
        }

        //public override void PlayerChoice(string playerName)
        //{
        //    base.PlayerChoice(playerName);
        //}

        //public override void CalculatePoints(int points)
        //{
        //    base.CalculatePoints(points);
        //}
    }
}
