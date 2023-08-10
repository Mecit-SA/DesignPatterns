namespace Visitor
{
    class AddReverbOperation : IOperation
    {
        public void Apply(FactSegment segment)
        {
            Console.WriteLine("Add Reverb To Fact Segment");
        }

        public void Apply(FormatSegment segment)
        {
            Console.WriteLine("Add Reverb To Format Segment");
        }
    }
}