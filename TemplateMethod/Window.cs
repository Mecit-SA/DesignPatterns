namespace TemplateMethod
{
    abstract class Window
    {
        /// <summary>
        /// Template Method
        /// </summary>
        public void Close()
        {
            OnClosing();

            Console.WriteLine("Closing Window...");

            OnClosed();
        }

        protected virtual void OnClosing() { }

        protected virtual void OnClosed() { }
    }
}