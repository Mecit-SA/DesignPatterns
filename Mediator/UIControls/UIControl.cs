namespace Mediator
{
    abstract class UIControl
    {
        private readonly ICollection<IEventHandler> _eventHandlers = new List<IEventHandler>();

        public void Attach(IEventHandler observer) => _eventHandlers.Add(observer);

        protected void NotifyObservers() 
        {
            foreach (var handler in _eventHandlers)
                handler.Handle();
        }
    }

    interface IEventHandler
    {
        void Handle();
    }
}