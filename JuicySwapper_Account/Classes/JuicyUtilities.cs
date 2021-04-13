using System;
using System.IO;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JuicySwapper_Account.Classes
{
    class JuicyUtilities
    {
        public static string GET_HARDWAREID => ReturnHardwareID().Result;
        private static async Task<string> ReturnHardwareID()
        {
            byte[] bytes;
            StringBuilder sb = new StringBuilder();

            Task task = Task.Run(() =>
            {
                ManagementObjectSearcher bios = new ManagementObjectSearcher("SELECT * FROM Win32_bios");
                ManagementObjectCollection bios_Collection = bios.Get();
                foreach (ManagementObject obj in bios_Collection)
                {
                    sb.Append(obj["Version"].ToString());
                    break;
                }

                ManagementObjectSearcher hdd = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
                ManagementObjectCollection hdd_Collection = hdd.Get();
                foreach (ManagementObject obj in hdd_Collection)
                {
                    sb.Append(obj["SerialNumber"].ToString());
                    break;
                }
            });
            Task.WaitAny(task);
            bytes = Encoding.UTF8.GetBytes(sb.ToString());
            return await Task.FromResult(Convert.ToBase64String(bytes).Substring(12));
        }

        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "abc123";
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
    }
}

