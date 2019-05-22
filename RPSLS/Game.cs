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
        public string player1Name;
        public string player2Name;
        public double player1Points;
        public double player2Points;
        public string player1Pick;
        public string player2Pick;

        //contructor (SPAWNER/DEFAULT)//
        public Game()
        {
            this.player1Name = new Player1Name();
            this.player2Name = new Player2Name();
            this.player1Points = new Player1Points();
            this.player2Points = new Player2Points();
            this.player1Pick = new Player1Pick();
            this.player2Pick = new Player2Pick();

        }


        //member methods (CAN DO)//

        //display rules


        //prompt game mode user wants to play; playervsplayer or playervsAI

        //prompt player names

        //prompt for player choices


        //method to validate user input is a number


        //method to validate user input is a number, and returns the input if it's true


        //returns winner of each round


        //display points


        //prompt the user to end game or play again


        //initial method that gets called to run the game


        //loop to restart game

    }
}
