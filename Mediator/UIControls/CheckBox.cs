namespace Mediator
{
    class CheckBox : UIControl
    {
        private bool _isChecked;

        public bool IsChecked
        {
            get => _isChecked;
            set
            {
                _isChecked = value;
                NotifyObservers();
            }
        }
    }
}