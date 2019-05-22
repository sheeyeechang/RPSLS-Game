using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Players
    {
        //member variable (HAS A)//
        public string players;
        public string human;
        public string ai;
        public string rock;
        public string paper;
        public string scissors;
        public string lizrd;
        public string scope;

    }



    //contructor (SPAWNER/DEFAULT)//
    public Players()
    {

    }
    {
        this.players = new Players();
        this.human = new Human();
        this.ai = new Ai();
        this.rock = new Rock();
        this.paper = new Paper();
        this.scissors = new Scissors();
        this.lizrd = new Lizards();
        this.scope = new UriIdnScope();
    }


    //member methods (CAN DO)//

    //prompt player name


    //prompt player choice

    //calculate points for each player

    //display points

    //method to validate user input is a number


    //method to validate user input is a number, and returns the input if it's true


    //method to validate user input is a number or letter


    //method to validate user input is a number or letter, and returns the input if it's true




}
