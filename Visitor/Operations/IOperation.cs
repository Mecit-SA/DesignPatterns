namespace Visitor
{
    interface IOperation
    {
        void Apply(FactSegment segment);
        void Apply(FormatSegment segment);
    }
}