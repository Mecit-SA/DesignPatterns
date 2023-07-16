namespace State
{
    /// <summary>
    /// Concrete state
    /// </summary>
    class DrivingMode : ITravelMode
    {
        public object GetETA()
        {
            Console.WriteLine("Calculating ETA for Driving Mode");
            return 1;
        }

        public object GetDirection()
        {
            Console.WriteLine("Getting Direction for Driving Mode");
            return 1;
        }
    }
}