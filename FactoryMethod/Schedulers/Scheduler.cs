namespace FactoryMethod
{
    class Scheduler
    {
        private readonly ICalendar _calendar;

        public Scheduler()
        {
            _calendar = CreateCalendar();
        }

        public void Schedule(Event e) {
            var today = new DateTime();
            _calendar.AddEvent(e, today);
        }

        protected virtual ICalendar CreateCalendar()
        {
            return new GregorianCalendar();
        }
    }
}