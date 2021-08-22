namespace TemplateMethod_pattern
{
    public abstract class AbstractDisplay
    {
        public abstract void Open();

        public abstract void Print();

        public abstract void Close();

        public void Display()
        {
            Open();
            for(var i = 0; i < 5; i++)
            {
                Print();
            }
            Close();
        }
    }
}
