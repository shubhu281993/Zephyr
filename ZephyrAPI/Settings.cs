using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZephyrAPI.Security;

namespace ZephyrAPI
{
    public class Settings
    {

        #region MongoDB
        private string _mongoDBConnection;
        public string MONGODB_CONNECTION
        {
            get => _mongoDBConnection;
            set { if(!string.IsNullOrEmpty(value)) _mongoDBConnection = Encrypter.Instance.Decrypt(value)}
        }
        #endregion
    }
}
