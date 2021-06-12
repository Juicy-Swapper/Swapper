using JuicySwapper_Default.Properties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuicySwapper_Default.IO
{

    public class Researcher
    {
        public static byte[] ConvertHexStringToByteArray(string hexString)
        {
            if (hexString.Contains(" "))
            {
                hexString = hexString.Replace(" ", "");
            }
            if (hexString.Length % 2 != 0)
            {
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", hexString));
            }

            byte[] data = new byte[hexString.Length / 2];
            for (int index = 0; index < data.Length; index++)
            {
                string byteValue = hexString.Substring(index * 2, 2);
                data[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }

            return data;
        }
        
        public static bool Convert(long start, string file, string convert, string revert, long max = 0, long additional = 0, bool minus = false, bool messages = false)
        {
            byte[] a = ConvertHexStringToByteArray(convert);
            byte[] b = ConvertHexStringToByteArray(revert);
            if (File.Exists(file))
            {
                Stream s = File.Open(file, FileMode.Open, FileAccess.ReadWrite);

                long offset;

                var task = Task.Run(() => Find(s, start, a, max));
                if (task.Wait(TimeSpan.FromSeconds(10)))
                {
                    offset = task.Result;
                }
                else
                    offset = 0;

                s.Close();

                if (offset == 0)
                {
                    if (messages)
                        MessageBox.Show("Already converted, or string not found in pak!");

                    return false;
                }

                if (additional != 0 && minus)
                    offset -= additional;

                else if (additional != 0 && !minus)
                    offset += additional;

                BinaryWriter binaryWriter = new BinaryWriter(File.Open(file, FileMode.Open, FileAccess.ReadWrite));
                binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                binaryWriter.Write(b);
                binaryWriter.Close();

                if (messages)
                    MessageBox.Show("Successfully converted!");

                return true;
            }
            else
            {
                if (messages)
                    MessageBox.Show("The pak file specified doesn't exist");

                return false;
            }
        }

        public static bool Revert(long start, string file, string convert, string revert, long max = 0, long additional = 0, bool messages = true, bool v = false)
        {
            byte[] a = ConvertHexStringToByteArray(convert);
            byte[] b = ConvertHexStringToByteArray(revert);
            if (File.Exists(file))
            {
                Stream s = File.Open(file, FileMode.Open, FileAccess.ReadWrite);

                long offset;

                var task = Task.Run(() => Find(s, start, b, max));
                if (task.Wait(TimeSpan.FromSeconds(10)))
                {
                    offset = task.Result;
                }
                else
                    offset = 0;

                s.Close();

                if (offset == 0)
                {
                    if (messages)
                        MessageBox.Show("Already converted, or string not found in pak!");

                    return false;
                }

                if (additional != 0)
                    offset += additional;

                BinaryWriter binaryWriter = new BinaryWriter(File.Open(file, FileMode.Open, FileAccess.ReadWrite));
                binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                binaryWriter.Write(a);
                binaryWriter.Close();

                if (messages)
                    MessageBox.Show("Successfully reverted!");

                return true;
            }
            else
            {
                if (messages)
                    MessageBox.Show("The pak file specified doesn't exist");

                return false;
            }
        }

        private static long Find(Stream a, long b, byte[] c, long max)
        {
            int searchPosition = 0;
            long result = 0;
            a.Position = b;
            bool max1 = false;

            if (max == 0)
                max1 = false;

            else if (max > 1)
                max1 = true;

            while (true)
            {
                try
                {
                    if (max1)
                    {
                        if (a.Position == max)
                            return result;
                    }
                    else
                    {
                        if (a.Position == 5000000000)
                            return result;
                    }
                }
                catch
                {
                    MessageBox.Show("asdasd");
                }
                

                var latestbyte = a.ReadByte();
                if (latestbyte == -1)
                    break;

                if (latestbyte == c[searchPosition])
                {
                    searchPosition++;
                    if (searchPosition == c.Length)
                    {
                        result = a.Position - c.Length;
                        return result;
                    }
                }
                else
                    searchPosition = 0;
            }
            return result;
        }
    }

}

