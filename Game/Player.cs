using System;

namespace Unit05.Game
{
    public class Player
    {
        Dictionary<int, Pocket> pockets;
        int player_num;
        int[] player_pockets = {1, 2, 3, 4, 5, 6};

        public Player(Board board, int player_num)
        { 
            pockets = board.pockets;
            this.player_num = player_num;
            if (player_num == 2)
            {
                player_pockets[0] = 8;
                player_pockets[1] = 9;
                player_pockets[2] = 10;
                player_pockets[3] = 11;
                player_pockets[4] = 12;
                player_pockets[5] = 13;

            }
        }

        public void takeTurn()
        {
            int move_num = getMove(player_num);
            makeMove(move_num);
        }

        public int getMove(int player)
        {
            while (true)
            {
                Console.Write($"Player {player}: ");
                string s_move = Console.ReadLine();
                try
                {
                    int move = int.Parse(s_move);

                    if (move > 0 && move < 7)
                    {
                        if (player_num == 2)
                        {
                            switch (move)
                            {
                                case 1:
                                    return 13;
                                case 2:
                                    return 12;
                                case 3:
                                    return 11;
                                case 4:
                                    return 10;
                                case 5:
                                    return 9;
                                case 6:
                                    return 8;
                                default:
                                    return 0;
                            }
                        }
                        return move;
                    }
                    else
                    {
                        Console.WriteLine("Choose a number between 1 and 6.");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid Input");
                }
            };
        }

        public void makeMove(int pocket)
        // Makes a move for the player
        {
            int i;
            int marbles = pockets[pocket].marble_count;

            for (i = pocket; marbles >= 0; i++)
            {
                pockets[i].marble_count ++;
                
                if (i == 13) 
                {
                    i = -1;
                }   
                
                marbles --; 
            }
            
            Console.WriteLine(i - 1);

            pockets[pocket].marble_count = 0;
        }

    }
}