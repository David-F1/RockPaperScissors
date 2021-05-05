using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaper
{
    class Game
    {
        private int A = 0; // number of wins of player A
        private int B = 0; // number of wins of player B
        private int D = 0; // the number of draws
        private Player playerA;
        private Player playerB;

        public Game(Player P1, Player P2)
        {
            playerA = P1;
            playerB = P2;
        }

        public void PlayerAmoves(Outcome outcome)
        {
            playerA.setPlayerMove(outcome);
        }

        public void playerBmoves(Outcome outcome)
        {
            playerB.setPlayerMove(outcome);
        }

        public void MoveResult()
        {
            Console.WriteLine("Player " + playerA.getPlayerName() + " :" + playerA.getPlayerMove());
            Console.WriteLine("Player " + playerB.getPlayerName() + " : " + playerB.getPlayerMove());

            if (playerA.getPlayerMove() == playerB.getPlayerMove())
            {
                Console.WriteLine("it is a draw ");
                D++;
            }
            else if ((playerA.getPlayerMove() == Outcome.paper && playerB.getPlayerMove() == Outcome.rock)||(playerA.getPlayerMove() == Outcome.rock && playerB.getPlayerMove()==Outcome.scisso)||(playerA.getPlayerMove()==Outcome.scisso && playerB.getPlayerMove() == Outcome.paper))
            {
                Console.WriteLine("Player " + playerA.getPlayerName() + " has won ");
                A++;

            }
            else if ((playerB.getPlayerMove() == Outcome.paper && playerA.getPlayerMove() == Outcome.rock) || (playerB.getPlayerMove() == Outcome.rock && playerA.getPlayerMove() == Outcome.scisso) || (playerB.getPlayerMove() == Outcome.scisso && playerA.getPlayerMove() == Outcome.paper))
            {
                Console.WriteLine("Player " + playerB.getPlayerName() + " has won ");
                B++;

            }


            Console.WriteLine("\n");

        }

        public void getNumWins()
        {
            Console.WriteLine(playerA.getPlayerName() + " has win " + A + " times");
            Console.WriteLine(playerB.getPlayerName() + " has win " + B + " times");
            Console.WriteLine("the was " + D + " draws");

        }


    }
}
