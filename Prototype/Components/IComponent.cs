namespace Prototype
{
    interface IComponent
    {
        IComponent Clone();
        void Print();
    }
}