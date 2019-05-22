using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI: Players //inherit methods and member variables from Players class
    {
    //member variable (HAS A)//

        public string randomizeChoice;

    }

    //contructor (SPAWNER/DEFAULT)//
    public AI()
    {
        this.randomizeChoice = new RandomChoice();
    }


    //member methods (CAN DO)//


    //prompt player name

    //prompt player choice

    //calculate points for each player

    //display points
}
