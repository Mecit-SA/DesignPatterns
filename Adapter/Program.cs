using Adapter;

var emailClient = new EmailClient();
emailClient.AddProvider(new GmailProvider());

emailClient.DownloadEmails();