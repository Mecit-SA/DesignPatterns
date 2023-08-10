namespace Visitor
{
    class FormatSegment : Segment
    {
        public override void Apply(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}