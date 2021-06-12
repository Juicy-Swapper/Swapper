using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace JuicySwapper_Encryption.Auth
{
	public class DataBase
	{
		private static readonly Encoding encoding = Encoding.UTF8;

		public static string dbURL = "eyJpdiI6IlAzc0w0TlRHYUdUUVY4bDNER0dPSXc9PSIsInZhbHVlIjoiRDdVa3djVGYyUmlOZVJtNmFGbXJRaHJlcm8rVnl5L2FQNE1sbGw3eDV2WFZ5Q2RKdWpzUi9aNlZ4MXFWOHRVWlBJU0VHRFlKVDNGU0tmcUwzdHJhQktaeG9uellqVkFMNWxlakNBZy9jdC94TTErN0FiRUxxUmcxN3lIeklLY0JQZ2N6dXEvR0FyZDJLa0hhQSsya0h3PT0iLCJtYWMiOiJkODIxYzE3MjE1ZTlkYmU1NGQxYjliN2EzYTQ4NDc1NjUyNTAzYzk3ZmFkYzFlMjc3MjI0M2E5YzE4ZjVjMjQ4In0=";

		public static string Encrypt(string plainText, string key)
		{
			bool skid = Scan.Check(key);
			if (skid == true)
			{
				MessageBox.Show("Check = false", "Juicy Swapper - Encryption", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			try
			{
				var APIkey = new WebClient().DownloadString("https://0xkaede.xyz/Encryption/Key.Juicy");

				var realkey = APIkey;
				RijndaelManaged aes = new RijndaelManaged();
				aes.KeySize = 256;
				aes.BlockSize = 128;
				aes.Padding = PaddingMode.PKCS7;
				aes.Mode = CipherMode.CBC;

				aes.Key = encoding.GetBytes(realkey);
				aes.GenerateIV();

				ICryptoTransform AESEncrypt = aes.CreateEncryptor(aes.Key, aes.IV);
				byte[] buffer = encoding.GetBytes(plainText);

				string encryptedText = Convert.ToBase64String(AESEncrypt.TransformFinalBlock(buffer, 0, buffer.Length));

				String mac = "";

				mac = BitConverter.ToString(HmacSHA256(Convert.ToBase64String(aes.IV) + encryptedText, realkey)).Replace("-", "").ToLower();

				var keyValues = new Dictionary<string, object>
				{
					{ "iv", Convert.ToBase64String(aes.IV) },
					{ "value", encryptedText },
					{ "mac", mac },
				};

				JavaScriptSerializer serializer = new JavaScriptSerializer();

				return Convert.ToBase64String(encoding.GetBytes(serializer.Serialize(keyValues)));
			}
			catch (Exception e)
			{
				throw new Exception("Error encrypting: " + e.Message);
			}
		}

		public static string Decrypt(string plainText, string key)
		{
			bool skid = Scan.Check(key);
			if (skid == false)
			{
				MessageBox.Show("Check = false", "Juicy Swapper - Encryption", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			try
			{

				var APIkey = new WebClient().DownloadString("https://0xkaede.xyz/Encryption/Key.Juicy");

				var realkey = APIkey;
				RijndaelManaged aes = new RijndaelManaged();
				aes.KeySize = 256;
				aes.BlockSize = 128;
				aes.Padding = PaddingMode.PKCS7;
				aes.Mode = CipherMode.CBC;
				aes.Key = encoding.GetBytes(realkey);

				// Base 64 decode
				byte[] base64Decoded = Convert.FromBase64String(plainText);
				string base64DecodedStr = encoding.GetString(base64Decoded);

				// JSON Decode base64Str
				JavaScriptSerializer ser = new JavaScriptSerializer();
				var payload = ser.Deserialize<Dictionary<string, string>>(base64DecodedStr);

				aes.IV = Convert.FromBase64String(payload["iv"]);

				ICryptoTransform AESDecrypt = aes.CreateDecryptor(aes.Key, aes.IV);
				byte[] buffer = Convert.FromBase64String(payload["value"]);

				return encoding.GetString(AESDecrypt.TransformFinalBlock(buffer, 0, buffer.Length));
			}
			catch (Exception e)
			{
				throw new Exception("Error decrypting: " + e.Message);
			}
		}

		static byte[] HmacSHA256(String data, String key)
		{
			using (HMACSHA256 hmac = new HMACSHA256(encoding.GetBytes(key)))
			{
				return hmac.ComputeHash(encoding.GetBytes(data));
			}
		}
	}

}