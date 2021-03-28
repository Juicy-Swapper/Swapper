using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JuicySwapper_Account.Classes
{
    class JuicyUtilities
    {
        public static class ColorConsole
        {
            public static void WriteLine(string text, ConsoleColor? color = null)
            {
                if (color.HasValue)
                {
                    var oldColor = System.Console.ForegroundColor;
                    if (color == oldColor)
                        Console.WriteLine(text);
                    else
                    {
                        Console.ForegroundColor = color.Value;
                        Console.WriteLine(text);
                        Console.ForegroundColor = oldColor;
                    }
                }
                else
                    Console.WriteLine(text);
            }

            public static void WriteLine(string text, string color)
            {
                if (string.IsNullOrEmpty(color))
                {
                    WriteLine(text);
                    return;
                }

                if (!Enum.TryParse(color, true, out ConsoleColor col))
                    WriteLine(text);
                else
                    WriteLine(text, col);
            }
            public static void Write(string text, ConsoleColor? color = null)
            {
                if (color.HasValue)
                {
                    var oldColor = System.Console.ForegroundColor;
                    if (color == oldColor)
                        Console.Write(text);
                    else
                    {
                        Console.ForegroundColor = color.Value;
                        Console.Write(text);
                        Console.ForegroundColor = oldColor;
                    }
                }
                else
                    Console.Write(text);
            }

            public static void Write(string text, string color)
            {
                if (string.IsNullOrEmpty(color))
                {
                    Write(text);
                    return;
                }

                if (!ConsoleColor.TryParse(color, true, out ConsoleColor col))
                    Write(text);
                else
                    Write(text, col);
            }


            private static Lazy<Regex> colorBlockRegEx = new Lazy<Regex>(
                () => new Regex("\\[(?<color>.*?)\\](?<text>[^[]*)\\[/\\k<color>\\]", RegexOptions.IgnoreCase),
                isThreadSafe: true);

            public static void WriteEmbeddedColorLine(string text, ConsoleColor? baseTextColor = null)
            {
                if (baseTextColor == null)
                    baseTextColor = Console.ForegroundColor;

                if (string.IsNullOrEmpty(text))
                {
                    WriteLine(string.Empty);
                    return;
                }

                int at = text.IndexOf("[");
                int at2 = text.IndexOf("]");
                if (at == -1 || at2 <= at)
                {
                    WriteLine(text, baseTextColor);
                    return;
                }

                while (true)
                {
                    var match = colorBlockRegEx.Value.Match(text);
                    if (match.Length < 1)
                    {
                        Write(text, baseTextColor);
                        break;
                    }

                    Write(text.Substring(0, match.Index), baseTextColor);

                    string highlightText = match.Groups["text"].Value;
                    string colorVal = match.Groups["color"].Value;

                    Write(highlightText, colorVal);
                    text = text.Substring(match.Index + match.Value.Length);
                }

                Console.WriteLine();
            }
        }

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
