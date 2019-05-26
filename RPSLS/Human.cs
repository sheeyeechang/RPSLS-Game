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

        //member methods (CAN DO)//
        
        ////Prompts player names
        public override void PromptPlayerName(int playerNumber)
        {
            base.PromptPlayerName(playerNumber);
        }

        ////prompts player choice
        ///CHOOSE GESTURE
        public override void PlayerChoice(string PlayerName)        
        {
            base.PlayerChoice(playerName);
        }

        //calculate points for each player
        public override void CalculatePoints(int points)
        {
            base.CalculatePoints(points);
        }
    }
}
