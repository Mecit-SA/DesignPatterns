namespace Visitor
{
    abstract class Segment
    {
        public abstract void Apply(IOperation operation);
    }
}