namespace Bridge_pattern
{
    public class CountDisplay : Display
    {
        public CountDisplay(DisplayImpl impl) : base(impl)
        {
        }

        public void MultiDisplay(int times)
        {
            Open();
            for(var i = 0; i < times; i++)
            {
                Print();
            }
            Close();
        }
    }
}
