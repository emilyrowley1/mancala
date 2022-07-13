using System;

namespace Unit05.Game
{
    public class Director
    {
        public Director()
        {

        }

        public void runGame()
        {
            Board gameBoard = new Board();
            Player player1 = new Player(gameBoard, 1);
            Player player2 = new Player(gameBoard, 2);

            while (true)
            {
                player1.takeTurn();
                player2.takeTurn();
            }
        }
    }
}