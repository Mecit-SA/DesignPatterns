namespace Iterator
{
    internal interface IIterator
    {
        bool HasNext { get; }
        Product Current { get; }
        void Next();
    }
}