using System.Security.Cryptography;
using System.Text;

namespace Security;

public class Hashing
{
    internal string Hash(string sPassword)
    {
        byte[] nPassword = UTF8Encoding.UTF8.GetBytes(sPassword);
        string sHash = Convert.ToBase64String(SHA3_256.Create().ComputeHash(nPassword));
        return sHash;
    }
}