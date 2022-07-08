using System;

namespace Unit05.Game
{
    public class Pocket
    {
        public int marble_count = 0;
        public Pocket(int amount=4)
        { 
            fillPocket(amount);
        }

        private void fillPocket(int amount)
        {
            marble_count = amount;
        }
    }
}
