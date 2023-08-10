namespace Visitor
{
    class ReduseNoiseOperation : IOperation
    {
        public void Apply(FactSegment segment)
        {
            Console.WriteLine("Reduce Noise Of Fact Segment");
        }

        public void Apply(FormatSegment segment)
        {
            Console.WriteLine("Reduce Noise Of Format Segment");
        }
    }
}