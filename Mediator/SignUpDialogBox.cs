namespace Mediator
{
    class SignUpDialogBox
    {
        private readonly TextBox _usernameTextBox = new();
        private readonly TextBox _passwordTextBox = new();
        private readonly CheckBox _termsCheckBox = new();
        private readonly Button _signUpButton = new();

        public SignUpDialogBox()
        {
            _usernameTextBox.Attach(new FormChangeHandler(this));
            _passwordTextBox.Attach(new FormChangeHandler(this));
            _termsCheckBox.Attach(new FormChangeHandler(this));
        }

        class FormChangeHandler : IEventHandler
        {
            private readonly SignUpDialogBox _dialogBox;

            public FormChangeHandler(SignUpDialogBox dialogBox)
            {
                _dialogBox = dialogBox;
            }

            public void Handle()
            {
                var username = _dialogBox._usernameTextBox.Content;
                var password = _dialogBox._passwordTextBox.Content;

                var textBoxesIsValid = !string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password);

                var termsAreAccepted = _dialogBox._termsCheckBox.IsChecked;

                _dialogBox._signUpButton.IsEnabled = textBoxesIsValid && termsAreAccepted;
            }
        }

        public void Simulate()
        {
            Console.WriteLine("Set username and check terms");
            _usernameTextBox.Content = "testuser";
            _termsCheckBox.IsChecked = true;

            Console.WriteLine("Then Button is Enabled : " + _signUpButton.IsEnabled);

            Console.WriteLine("Set Password");
            _passwordTextBox.Content = "Password";

            Console.WriteLine("Then Button is Enabled : " + _signUpButton.IsEnabled);

            Console.WriteLine("Clear Username");
            _usernameTextBox.Content = string.Empty;

            Console.WriteLine("Then Button is Enabled : " + _signUpButton.IsEnabled);
        }
    }
}