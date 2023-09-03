namespace Prototype
{
    class Audio : IComponent
    {
        public IComponent Clone()
        {
            return new Audio();
        }

        public void Print()
        {

        }
    }
}