using System;

namespace Unit05.Game
{
    public class Player
    {
        Dictionary<int, Pocket> pockets;
        int player_num;
        public Player(Board board, int player_num)
        { 
            pockets = board.pockets;
            this.player_num = player_num;
        }

        public void makeMove(int pocket)
        // Makes a move for the player
        {
            int marbles = pockets[pocket].marble_count;

            for (int i = pocket + 1; marbles > 0; i++)
            {
                pockets[i].marble_count ++;
                
                if (i == 13) 
                {
                    i = -1;
                }   
                
                marbles --; 
            }

            pockets[pocket].marble_count = 0;
        }

    }
}