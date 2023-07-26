namespace Strategy
{
    /// <summary>
    /// Context
    /// </summary>
    class ChatClient
    {
        private readonly IEncryptionAlgorithm _encryptionAlgorithm;

        public ChatClient(IEncryptionAlgorithm encryptionAlgorithm)
        {
            _encryptionAlgorithm = encryptionAlgorithm;
        }

        public void Send(string message)
        {
            _ = _encryptionAlgorithm.Encrypt(message);
            Console.WriteLine("Sending message...");
        }
    }
}