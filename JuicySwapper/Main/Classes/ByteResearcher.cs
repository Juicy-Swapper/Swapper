using JuicySwapper.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuicySwapper.IO
{
    public class ByteResearcher
    {
        public static bool Convert(long Offset, string Pak, byte[] Convert, byte[] Revert, long max = 0, long additional = 0, bool minus = false, bool messages = false)
        {
            if (File.Exists(Pak))
            {
                Stream s = File.Open(Pak, FileMode.Open, FileAccess.ReadWrite);

                long offset;

                var task = Task.Run(() => Find(s, Offset, Convert, max));
                if (task.Wait(TimeSpan.FromSeconds(10)))
                {
                    offset = task.Result;
                    Settings.Default.current_offset = offset;
                    Settings.Default.Save();
                }
                else
                    offset = 0;

                s.Close();

                if (offset == 0)
                {
                    if (messages)
                        MessageBox.Show("Already converted, or byte not found in pak! (Ask for help on discord!)", "- kaede", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }

                if (additional != 0 && minus)
                    offset -= additional;

                else if (additional != 0 && !minus)
                    offset += additional;

                BinaryWriter binaryWriter = new BinaryWriter(File.Open(Pak, FileMode.Open, FileAccess.ReadWrite));
                binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                binaryWriter.Write(Revert);
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

        public static bool Revert(long Offset, string Pak, byte[] Convert, byte[] Revert, long max = 0, long additional = 0, bool minus = false, bool messages = false)
        {
            if (File.Exists(Pak))
            {
                Stream s = File.Open(Pak, FileMode.Open, FileAccess.ReadWrite);

                long offset;

                var task = Task.Run(() => Find(s, Offset, Revert, max));
                if (task.Wait(TimeSpan.FromSeconds(10)))
                {
                    offset = task.Result;
                    Settings.Default.current_offset = offset;
                    Settings.Default.Save();
                }
                else
                    offset = 0;

                s.Close();

                if (offset == 0)
                {
                    if (messages)
                        MessageBox.Show("Already reverted, or byte not found in pak! (Ask for help on discord!)", "- kaede", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }

                if (additional != 0)
                    offset += additional;

                BinaryWriter binaryWriter = new BinaryWriter(File.Open(Pak, FileMode.Open, FileAccess.ReadWrite));
                binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                binaryWriter.Write(Convert);
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

        public static long GetOffset(int Base, string Path, byte[] Search)
        {
            while (true)
            {
                if (FindPosition(Base, Path, Search))
                {
                    return Settings.Default.current_offset;
                }
                else
                    Base += Base / 2 / 2;
            }
        }

        public static bool FindPosition(long start, string file, byte[] convert, long max = 0)
        {
            if (File.Exists(file))
            {
                Stream s = File.Open(file, FileMode.Open, FileAccess.ReadWrite);

                long offset;

                var task = Task.Run(() => Find(s, start, convert, max));
                if (task.Wait(TimeSpan.FromSeconds(10)))
                {
                    offset = task.Result;
                    Settings.Default.current_offset = offset;
                    Settings.Default.Save();
                }
                else
                    offset = 0;

                s.Close();

                if (offset == 0)
                {
                    return false;
                }
                return true;
            }
            else
                return false;
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