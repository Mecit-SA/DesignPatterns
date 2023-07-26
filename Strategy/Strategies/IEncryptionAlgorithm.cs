namespace Strategy
{
    /// <summary>
    /// Strategy
    /// </summary>
    interface IEncryptionAlgorithm
    {
        string Encrypt(string message);
    }
}