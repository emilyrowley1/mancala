using System;

namespace Unit05.Game
{
    public class Board
    {
        public Dictionary<int, Pocket> pockets = new Dictionary<int, Pocket>();
        public Board()
        { 
            // creating all of the pockets
            for (int i = 0; i <= 13; i++)
            {
                if (i == 0 || i == 7)
                {
                    Pocket pocket = new Pocket(0);
                    pockets.Add(i, pocket);
                }
                else
                {
                    Pocket pocket = new Pocket();
                    pockets.Add(i, pocket);
                }
            } 
        }

        public void displayBoard()
        // Displays the current game board
        {
            Console.WriteLine();
            Console.WriteLine($"  {pockets[1].marble_count} {pockets[2].marble_count} {pockets[3].marble_count} | {pockets[4].marble_count} {pockets[5].marble_count} {pockets[6].marble_count} ");
            Console.WriteLine($"{pockets[0].marble_count} ------------- {pockets[7].marble_count}");
            Console.WriteLine($"  {pockets[13].marble_count} {pockets[12].marble_count} {pockets[11].marble_count} | {pockets[10].marble_count} {pockets[9].marble_count} {pockets[8].marble_count} ");
            Console.WriteLine($"__________________");

        } 

    }
}