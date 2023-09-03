namespace Prototype
{
    class Clip : IComponent
    {
        public IComponent Clone()
        {
            return new Clip();
        }

        public void Print()
        {

        }
    }
}