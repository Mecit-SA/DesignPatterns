namespace TemplateMethod
{
    class TestWindow : Window
    {
        protected override void OnClosed()
        {
            Console.WriteLine("Show animation!");
        }
    }
}