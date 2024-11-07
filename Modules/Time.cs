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

        public static string TimeString(bool hour, bool min, bool sec) 
        {
            switch(Kernel.langSelected) 
            {
                case "fr_FR":
                    return getTime24(hour, min, sec);
                case "en_US":
                    return getTime12(hour, min, sec);
                case "n1_NL":
                    return getTime24(hour, min, sec);
                case "it_IT":
                    return getTime12(hour, min, sec);
                default:
                    return getTime12(hour, min, sec);
            }
        }

        public static string YearString()
        {
            int intyear = Year();
            string stringyear = intyear.ToString();

            if (stringyear.Length == 2) {
                stringyear = "20" + stringyear;
            }
            return stringyear;
        }

        public static string MonthString()
        {
            int intmonth = Month();
            string stringmonth = intmonth.ToString();

            if (stringmonth.Length == 1) {
                stringmonth = "0" + stringmonth;
            }
            
            return stringmonth;
        }

        public static string DayString() 
        {
            int intday = DayOfMonth();
            string stringday = intday.ToString();
            
            if (stringday.Length == 1) {
                stringday = "0" + stringday;
            }
            
            return stringday;
        }
    } // public static class Time
} // namespace DynutOS.System