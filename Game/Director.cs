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

            gameBoard.displayBoard();

            // int p = getInputs(1);
            player1.takeTurn();
            gameBoard.displayBoard();

            player2.takeTurn();
            gameBoard.displayBoard();
        }
    }
}