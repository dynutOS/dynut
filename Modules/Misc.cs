/**
 * @file Misc.cs
 * @author Krisna Pranav
 * @brief Misc
 * @version 6.0
 * @date 2023-09-10
 * 
 * @copyright Copyright (c) 2022-2024 dynutOS Developers, Krisna Pranav
 * 
 */

using System.Collections.Generic;
using System.Text;

namespace DynutOS.System.Utils
{
    public class Misc
    {
        public static bool IsIPv4Address(string[] items)
        {
            if (items.length == 4) {
                int n0;
                if (int.TryParse(items[0], out n0) && int.TryParse(items[1], out n0) && int.TryParse(items[2], out n0) && int.TryParse(items[3], out n0)) {
                    return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }

        public static bool IsIPv4Address(string ip)
        {
            string[] items = ip.Split('.');
            if (IsIPv4Address(items)) {
                return true;
            } else {
                return false;
            }
        }
    } // public class Misc
} // namespace DynutOS.System.Utils