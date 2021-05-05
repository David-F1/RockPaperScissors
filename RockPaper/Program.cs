using System;

namespace RockPaper
{
    class Program
    {

        

        static void Main(string[] args)
        {
            //Program start

            //instanciate objects

            Player PA = new Player("Dav");
            Player PB = new Player("Fotsing");

            Game game = new Game(PA, PB);


            //variables declaration
            
            Random rand = new Random();
            int index1 = rand.Next(3);
            int index2 = rand.Next(3);
            int T = 0;

            Console.WriteLine("Welcome to Rock - Paper - Scissors Game ");
            Console.WriteLine("\n");


            for (int i=0; i<100; ++i)
            {
                //playerA  moves
                if (index1 == 0)
                {
                    game.PlayerAmoves(Outcome.rock);
                }
                else if (index1 == 1)
                {
                    game.PlayerAmoves(Outcome.paper);
                }
                else if (index1 == 2)
                {
                    game.PlayerAmoves(Outcome.scisso);
                }

                //playerB moves
                if(index2 == 0)
                {
                    game.playerBmoves(Outcome.rock);
                }
                else if(index2 == 1)
                {
                    game.playerBmoves(Outcome.paper);
                }
                else if(index2 == 2)
                {
                    game.playerBmoves(Outcome.scisso);
                }

                game.MoveResult();

                index1 = rand.Next(3);
                index2 = rand.Next(3);
            }


            game.getNumWins();
            Console.ReadLine();
        }
    }
}
