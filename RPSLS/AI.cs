using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class AI : Players
    {
        //member variable (HAS A)//

        //constructor (SPAWNER/DEFAULT)//
        public AI()
        {

        }

        //    //member methods (CAN DO)//
        //    //sets player 2 name
        //    public override void PlayerName(string word)
        //    {
        //        player2Name = "Ai Mike";
        //    }
        //    //randomizes a number between 0 and 4; this will be AI choice
        public override string ChooseGesture()
        {
            Random randomizeChoice = new Random();
            gesture = randomizeChoice.Next(0, 4);
        }

        //    //calculate points for each player
        //    public override void CalculatePoints(int points)
        //    {
        //        base.CalculatePoints(points);
        //    }
    }
}
