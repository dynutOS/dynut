/**
 * @file Time.cs
 * @author Krisna Pranav
 * @brief Time
 * @version 6.0
 * @date 2023-09-10
 * 
 * @copyright Copyright (c) 2022-2024 dynutOS Developers, Krisna Pranav
 * 
 */

using Cosmos.HAL;

namespace DynutOS.System
{
    public static class Time
    {
        static int Hour() 
        {
            return RTC.Hour;
        }

        static int Minute() 
        {
            return RTC.Minute;
        }

        static int Second()
        {
            return RTC.Second;
        }

        static int Year() 
        {
            return RTC.Century;
        }

        static int Month()
        {
            return RTC.Month;
        }

        static int DayOfMonth() 
        {
            return RTC.DayOfTheMonth;
        }

        static string getTime24(bool hour, bool min, bool sec)
        {
            string timeStr = "";

            if(hour) {
                if (Hour().ToString().Length == 1) {
                    timeStr += "0" + Hour().ToString();
                } else {
                    timeStr += Hour().ToString();
                }
            }

            if (min) {
                if (Minute().ToString().Length == 1) {
                    timeStr += ":";
                    timeStr += "0" + Minute().ToString();
                } else {
                    timeStr += ":";
                    timeStr += Minute.ToString();
                }
            }

            if (sec) {
                if (Second().ToString().Length == 1) {
                    timeStr += ":";
                    timeStr += "0" + Second().ToString();
                } else {
                    timeStr += ":";
                    timeStr += Second.ToString();
                }
            }

            return timeStr;
        }

        static string getTime12(bool hour, bool min, bool sec)
        {
            string timeStr = "";

            if (hour) {
                if (Hour() > 12) {
                    timeStr += Hour() - 12;
                } else {
                    timeStr += Hour();
                }
            }

            if (min) {
                if (Minute().ToString().Length == 1) {
                    timeStr += ":";
                    timeStr += "0" + Minute.ToString();
                } else {
                    timeStr += ":";
                    timeStr += Minute().ToString()
                }
            }

            if (sec) {
                if (Second().ToString().Length == 1) {
                    timeStr += ":";
                    timeStr += "0" + Second().ToString();
                } else {
                    timeStr += ":";
                    timeStr += Second().ToString();
                }
            }

            if (hour) {
                if (Hour() > 12) {
                    timeStr += " PM";
                } else {
                    timeStr += " AM";
                }
            }

            return timeStr;
        }
    } // public static class Time
} // namespace DynutOS.System