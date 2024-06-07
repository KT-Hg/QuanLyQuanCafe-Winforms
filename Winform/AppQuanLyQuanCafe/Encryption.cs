using AppQuanLyQuanCafe;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyQuanCafe
{
    public class Encryption
    {
        private static Encryption instance;

        public static Encryption Instance
        {
            get { if (instance == null) instance = new Encryption(); return Encryption.instance; }
            private set { Encryption.instance = value; }
        }

        private Encryption() { }

        public byte[] GenKey(string key)
        {
            byte[] keyByte;
            using (var deriveBytes = new Rfc2898DeriveBytes(key, salt: new byte[8], iterations: 10000, HashAlgorithmName.SHA256))
            {
                keyByte = deriveBytes.GetBytes(32); // 32 bytes tạo ra 256-bit khóa
            }
            return keyByte;
        }

        public string CalculateMD5(string input)
        {

            // Convert the password string to byte array
            byte[] inputBytes = Encoding.Unicode.GetBytes(input);

            // Create a new instance of MD5 algorithm
            using (MD5 md5 = MD5.Create())
            {
                // Compute the hash value of the password bytes
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to a hexadecimal string
                string hashedInput = BitConverter.ToString(hashBytes).Replace("-", "").ToUpper();

                // Print the hashed password
                return hashedInput;
            }
        }

        public string CalculateSHA1(string input)
        {

            // Convert the password string to byte array
            byte[] inputBytes = Encoding.Unicode.GetBytes(input);

            // Create a new instance of SHA1 algorithm
            using (SHA1 sha1 = SHA1.Create())
            {
                // Compute the hash value of the password bytes
                byte[] hashBytes = sha1.ComputeHash(inputBytes);

                // Convert the byte array to a hexadecimal string
                string hashedInput = BitConverter.ToString(hashBytes).Replace("-", "").ToUpper();

                // Print the hashed password
                return hashedInput;
            }
        }

        public byte[] EncryptAES(string data, byte[] key)
        {
            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = key;
                aesAlg.Mode = CipherMode.CBC; // You may want to choose other modes depending on your needs

                // Generate random IV
                aesAlg.GenerateIV();
                byte[] iv = aesAlg.IV;

                // Create encryptor
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, iv);

                // Create MemoryStream to store the encrypted bytes
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    // Write the IV first
                    msEncrypt.Write(iv, 0, iv.Length);

                    // Create CryptoStream and encrypt the data
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            // Write all data to the stream
                            swEncrypt.Write(data);
                        }
                    }

                    return msEncrypt.ToArray();
                }
            }
        }

        public string DecryptAES(byte[] encryptedData, byte[] key)
        {
            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = key;
                aesAlg.Mode = CipherMode.CBC; // You must use the same mode as in encryption

                // Get the IV from the beginning of the encrypted data
                byte[] iv = new byte[aesAlg.BlockSize / 8];
                Array.Copy(encryptedData, 0, iv, 0, iv.Length);
                aesAlg.IV = iv;

                // Create decryptor
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create MemoryStream to store the decrypted bytes
                using (MemoryStream msDecrypt = new MemoryStream())
                {
                    // Create CryptoStream and decrypt the data
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Write))
                    {
                        csDecrypt.Write(encryptedData, iv.Length, encryptedData.Length - iv.Length);
                        csDecrypt.FlushFinalBlock();
                    }

                    // Convert MemoryStream to string
                    return Encoding.UTF8.GetString(msDecrypt.ToArray());
                }
            }
        }
    }
}
