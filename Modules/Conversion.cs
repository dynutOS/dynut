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
    } // public static class Conversion
} // namespace DynutOS.Modules