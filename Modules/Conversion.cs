/**
 * @file Conversion.cs
 * @author Krisna Pranav
 * @brief Conversion
 * @version 6.0
 * @date 2023-09-10
 * 
 * @copyright Copyright (c) 2022-2024 dynutOS Developers, Krisna Pranav
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynutOS.Modules 
{
    public static class Conversion
    {
        public static string D2(uint number) 
        {
            if (number < 10) {
                return "0" + number;
            } else {
                return number.ToString();
            }
            
        }

        public static string D4(string text)
        {
            if (text.Length < 4) {
                switch(text.Length)
                {
                    case 3:
                        return "0" + text;
                    case 2:
                        return "00" + text;
                    case 1:
                        return "000" + text;
                    default:
                        return text;
                }
            } else {
                return text;
            }
        }

        public static string Hex(this byte[] value)
        {
            int offset = 0;
            int length = -1;

            if (length < 0) {
                length = value.Length - offset;
            }

            var builder = new StringBuilder(length * 2);
            int b;

            for(int i = offset; i < length + offset; i++) {
                b = value[i] >> 4;
                builder.Append((char)(55 + b + (((b - 10) >> 31) & -7)));
                b = value[i] & 0xF;
                builder.Append((char)(55 + b + (((b - 10) >> 31) & -7)));

            }
            return builder.ToString();
        }

        public static string DecToHex(int x)
        {
            string result = "";

            while (x != 0) {
                if ((x % 16) < 10) {
                    result = x % 16 + result;
                } else {
                    string temp = "";

                    switch (x % 16) 
                    {
                        case 10:
                            temp = "A"; 
                            break;
                        case 11:
                            temp = "B"; 
                            break;
                        case 12:
                            temp = "C"; 
                            break;
                        case 13:
                            temp = "D"; 
                            break;
                        case 14:
                            temp = "E"; 
                            break;
                        case 15:
                            temp = "F"; 
                            break;
                    }
                    result = temp + result;
                }
                x /= 16;
            }
            
            return result;
        }

        public static string HexDump(byte[] bytes, int bytesPerLine = 16)
        {
            if (bytes == null) {
                return "<null>";
            }

            int bytesLength = bytes.Length;

            char[] HexChars = "0123456789ABCDEF".ToCharArray();

            int firstHexColumn = 8 + 3;
            int firstCharColumn = firstHexColumn + bytesPerLine * 3 + (bytesPerLine - 1) / 8 + 2;
            int lineLength = firstCharColumn + bytesPerLine + Environment.NewLine.Length;

            char[] line = (new String(' ', lineLength - Environment.NewLine.Length) + Environment.NewLine).ToCharArray();
            int expectedLines = (bytesLength + bytesPerLine - 1) / bytesPerLine;
            StringBuilder result = new StringBuilder(expectedLines * lineLength);

            for (int i = 0; i < bytesLength; i += bytesPerLine) {
                
            }
        }

    } // public static class Conversion
} // namespace DynutOS.Modules