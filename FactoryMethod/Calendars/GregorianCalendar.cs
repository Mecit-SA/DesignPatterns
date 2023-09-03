namespace FactoryMethod
{
    class GregorianCalendar : ICalendar
    {
        public void AddEvent(Event e, DateTime date) {
            Console.WriteLine("Adding an event on the given date.");
        }
    }
}