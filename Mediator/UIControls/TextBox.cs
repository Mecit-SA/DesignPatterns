namespace Mediator
{
    class TextBox : UIControl
    {
        private string _content = string.Empty;

        public string Content { 
            get => _content; 
            set
            {
                _content = value;
                NotifyObservers();
            }
        }
    }
}