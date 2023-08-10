namespace Visitor
{
    class WavFile
    {
        private readonly ICollection<Segment> _segments = new List<Segment>();

        public static WavFile Read(string fileName)
        {
            // Simulate reading a wav file and building the segments
            var wavFile = new WavFile();
            wavFile._segments.Add(new FormatSegment());
            wavFile._segments.Add(new FactSegment());
            wavFile._segments.Add(new FactSegment());
            wavFile._segments.Add(new FactSegment());

            return wavFile;
        }

        public void Execute(IOperation operation)
        {
            foreach (var segment in _segments)
                segment.Apply(operation);
        }
    }
}