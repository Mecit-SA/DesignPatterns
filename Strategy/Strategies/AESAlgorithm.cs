namespace Strategy
{
    /// <summary>
    /// Concrete Strategy
    /// </summary>
    class AESAlgorithm : IEncryptionAlgorithm
    {
        public string Encrypt(string message)
        {
            Console.WriteLine("Encrypting message using AES algorithm...");
            return "Encrypted message";
        }
    }
}