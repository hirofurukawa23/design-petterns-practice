using System;

namespace Strategy_pattern
{
    public class WinningStrategy : IStrategy
    {
        private bool _won = false;
        private Hand _prevHand;
        private Random _random;
        public WinningStrategy(int seed)
        {
            _random = new Random(seed);
        }
        public Hand NextHand()
        {
            if(!_won)
            {
                _prevHand = Hand.GetHand(_random.Next(3));
            }
            return _prevHand;
        }

        public void Study(bool win)
        {
            _won = win;
        }
    }
}
