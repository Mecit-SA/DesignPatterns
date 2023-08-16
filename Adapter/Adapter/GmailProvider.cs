namespace Adapter
{
    /// <summary>
    /// Adapter
    /// </summary>
    class GmailProvider : IEmailProvider
    {
        private readonly GmailClient _client = new GmailClient();

        public void DownloadEmails()
        {
            _client.Connect();
            _client.GetEmails();
            _client.Disconnect();
        }
    }
}