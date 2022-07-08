using System;

namespace Unit05.Game
{
    public class Director
    {
        public Director()
        {

        }

        public int getInputs(int player)
        {
            while (true)
            {
                Console.Write($"Player {player}: ");
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid Input");
                }
            };
        }

        public void runGame()
        {
            Board gameBoard = new Board();
            Player player1 = new Player(gameBoard, 1);
            Player player2 = new Player(gameBoard, 1);

            gameBoard.displayBoard();

            // int p = getInputs(1);
            player1.makeMove(2);
            gameBoard.displayBoard();

            player2.makeMove(8);
            gameBoard.displayBoard();
        }
    }
}