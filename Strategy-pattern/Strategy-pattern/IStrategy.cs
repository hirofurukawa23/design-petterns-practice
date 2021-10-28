namespace Strategy_pattern
{
    public interface IStrategy
    {
        Hand NextHand();
        void Study(bool win);
    }
}
