namespace Visitor
{
    class FactSegment : Segment
    {
        public override void Apply(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}