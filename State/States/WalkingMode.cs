namespace State
{
    /// <summary>
    /// Concrete state
    /// </summary>
    class WalkingMode : ITravelMode
    {
        public object GetETA() 
        {
            Console.WriteLine("Calculating ETA for Walking Mode");
            return 2;
        }

        public object GetDirection()
        {
            Console.WriteLine("Getting Direction for Walking Mode");
            return 2;
        }
    }
}