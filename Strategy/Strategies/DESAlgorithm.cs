namespace Strategy
{
    /// <summary>
    /// Concrete Strategy
    /// </summary>
    class DESAlgorithm : IEncryptionAlgorithm
    {
        public string Encrypt(string message)
        {
            Console.WriteLine("Encrypting message using DES algorithm...");
            return "Encrypted message";
        }
    }
}