namespace FactoryMethod
{
    class ArabianScheduler : Scheduler
    {
        protected override ICalendar CreateCalendar()
        {
            return new IslamicCalendar();
        }
    }
}