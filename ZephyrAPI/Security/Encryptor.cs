using System.Text;

namespace ZephyrAPI.Security
{
    public sealed class Encryptor : IEncryptor
    {
        private static byte[] _key;
        private static byte[] _pwd;

        private Encryptor()
        {
            _key = new ASCIIEncoding().GetBytes("AAECAwQFBgcICQoLDA0ODw==");
            _pwd = new ASCIIEncoding().GetBytes("DELlSecIvPaSWord");
        }

        public static Encryptor Instance => NestedEncryptor._instance;

        public string Encrypt(string value)
        {
            return "";
        }
        public string Decrypt(string value) { return ""; }
            private class NestedEncryptor
        {
            public static readonly Encryptor _instance = new Encryptor();

            static NestedEncryptor() { }
        }
    }
}
