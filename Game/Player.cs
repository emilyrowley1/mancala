using System;

namespace Unit05.Game
{
    public class Player
    {
        Dictionary<int, Pocket> pockets;
        int player_num;
        int[] player_pockets = {1, 2, 3, 4, 5, 6};
        Board board;

        public Player(Board board, int player_num)
        { 
            this.board = board;
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
            board.displayBoard();
        
            int move_num = getMove(player_num);

            // If the pocket is empty the player needs to select another pocket
            while (pockets[move_num].marble_count == 0)
            {
                move_num = getMove(player_num);
            }

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
            
            // places marbles in the following pockets
            for (i = pocket; marbles >= 0; i++)
            {
                pockets[i].marble_count ++;
                Console.WriteLine($"pocket {i} has {pockets[i].marble_count} marbles");
                
                if (i == 13) 
                {
                    i = -1;
                }   
                
                marbles --; 
            }

            // Turing i into the index of pocket that the last marble landed in
            if (i == 0)
            {
                i = 13;
            }
            else
            {
                i = i-1;
            }

            if (pockets[i].marble_count == 1 && (i != 0 || i != 7))
            {
                landsInEmptyPocket(i, player_num);
            }
            
            pockets[pocket].marble_count = 0;
            
            if (i == 0 || i == 7)
            {
                takeTurn();
            }
        }

        private void landsInEmptyPocket(int pocketNum, int player_num)
        {
            int oppositePocket;
            int endPocket;

            switch (pocketNum)
            {
                case 1:
                    oppositePocket = 13;
                    break;
                case 2:
                    oppositePocket = 12;
                    break;
                case 3:
                    oppositePocket = 11;
                    break;
                case 4:
                    oppositePocket = 10;
                    break;
                case 5:
                    oppositePocket = 9;
                    break;
                case 6:
                    oppositePocket = 8;
                    break;
                case 13:
                    oppositePocket = 1;
                    break;
                case 12:
                    oppositePocket = 2;
                    break;
                case 11:
                    oppositePocket = 3;
                    break;
                case 10:
                    oppositePocket = 4;
                    break;
                case 9:
                    oppositePocket = 5;
                    break;
                case 8:
                    oppositePocket = 6;
                    break;
                default:
                    oppositePocket = 0;
                    break;
            }

            if (player_num == 1)
            {
                endPocket = 7;
            }
            else
            {
                endPocket = 0;
            }

            // getting the marble count of the opposite pocket and moving them to the end pocket
            int marblesInPocket = pockets[oppositePocket].marble_count;
            pockets[endPocket].marble_count += marblesInPocket;
            pockets[oppositePocket].marble_count = 0;
        }



        
    }
}