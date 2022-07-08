using Unit05.Game;


namespace Unit05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Player 1: top game, right hole, pockets #'s are left to right. \nPlayer 2: bottom pockets, left hole. Pockets numbered right to left.");
            
            Director director = new Director();
            director.runGame();
        }
    }
}

