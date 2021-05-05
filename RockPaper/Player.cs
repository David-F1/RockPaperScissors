using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaper
{
    class Player
    {
       private string name;
       private Outcome Move;

        public Player(string Name)
        {
            this.name = Name;
           // this.Move = move;
        }

        public string getPlayerName()
        {
            return name;
        }

        public Outcome getPlayerMove()
        {
            return Move;
        }

        public void setPlayerMove(Outcome move)
        {
            this.Move = move;
        }

        
    }
}
