namespace FactoryMethod
{
    internal class IslamicCalendar : ICalendar
    {
        public void AddEvent(Event e, DateTime date)
        {
            Console.WriteLine("Adding an event on the given date. (islamic calendar)");
        }
    }
}