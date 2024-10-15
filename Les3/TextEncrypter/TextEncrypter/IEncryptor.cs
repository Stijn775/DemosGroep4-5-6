using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEncrypter
{
    interface IEncryptor
    {
        string Encrypt(string toEncrypt);
        string Decrypt(string toDecrypt);

    }
}
