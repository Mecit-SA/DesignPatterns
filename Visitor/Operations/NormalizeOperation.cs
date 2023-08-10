namespace Visitor
{
    class NormalizeOperation : IOperation
    {
        public void Apply(FactSegment segment)
        {
            Console.WriteLine("Normalize Fact Segment");
        }

        public void Apply(FormatSegment segment)
        {
            Console.WriteLine("Normalize Format Segment");
        }
    }
}