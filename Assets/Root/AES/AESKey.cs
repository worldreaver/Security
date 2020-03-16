namespace Worldreaver.Security
{
    public struct AESKey
    {
        /// <summary>
        /// ase key
        /// </summary>
        public byte[] Key { get; }

        /// <summary>
        /// ase IV
        /// </summary>
        public byte[] Iv { get; }

        public AESKey(byte[] key,
            byte[] iv)
        {
            Key = key;
            Iv = iv;
        }
    }
}