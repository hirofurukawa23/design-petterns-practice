namespace Visitor_pattern
{
    public interface IElement
    {
        void Accept(Visitor v);
    }
}
