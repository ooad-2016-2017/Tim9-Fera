using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace SmartSchoolSystem.Model
{
    class MakeHashFromString
    {
        public string GetHashedPassword(string password, string salt)
        {

            IBuffer input = CryptographicBuffer.ConvertStringToBinary(password + salt, BinaryStringEncoding.Utf8);
            var hashAlgorithm = HashAlgorithmProvider.OpenAlgorithm(HashAlgorithmNames.Sha256);
            var hash = hashAlgorithm.HashData(input);

            return CryptographicBuffer.EncodeToBase64String(hash);
        }

       




    }
}

