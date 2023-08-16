namespace Adapter
{
    class EmailClient
    {
        private readonly ICollection<IEmailProvider> _providers = new List<IEmailProvider>();

        public void AddProvider(IEmailProvider provider) => _providers.Add(provider);

        public void DownloadEmails()
        {
            foreach (var provider in _providers)
                provider.DownloadEmails();
        }
    }
}