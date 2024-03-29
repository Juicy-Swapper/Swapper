﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JuicySwapper_OffsetFinder
{
    class LOGS
    {
        public static class Logs
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
    }
}
