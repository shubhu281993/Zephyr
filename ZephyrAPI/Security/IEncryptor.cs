using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZephyrAPI.Security
{
    public interface IEncryptor
    {
        string Encrypt(string value);
        string Decrypt(string value);
    }
}
