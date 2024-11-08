/**
 * @file CustomConsole.cs
 * @author Krisna Pranav
 * @brief Custom Console
 * @version 6.0
 * @date 2023-09-10
 * 
 * @copyright Copyright (c) 2022-2024 dynutOS Developers, Krisna Pranav
 * 
 */

using System;

namespace DynutOS.System
{
    public class CustomConsole
    {
        public static void WriteLineInfo(string text)
        {
            if (BootConsole != null) {
                BootConsole.Foreground = ConsoleColor.Cyan;
                BootConsole.Write("Info: ");
                BootConsole.Foreground = ConsoleColor.White;
                BootConsole.Write(text + "\n");
                BootConsole.Draw();
                Kernel.Canvas.DrawImage(BootConsole.GetBuffer(), 0, 0);
                Kernel.Canvas.Display();
            } else {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Info: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(text + "\n");
            }

            Logs.DoOSLog("[Info] " + text);
        }

        public static void WriteLineWarning(string text)
        {
            if (BootConsole != null) {
                BootConsole.Foreground = ConsoleColor.Yellow;
                BootConsole.Write("Warning: ");
                BootConsole.Foreground = ConsoleColor.White;
                BootConsole.Write(text + "\n");
                BootConsole.Draw();
                Kernel.Canvas.DrawImage(BootConsole.GetBuffer(), 0, 0);
                Kernel.Canvas.Display();
            } else {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Warning: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(text + "\n");
            }
            Logs.DoOSLog("Warning: " + text);
        }

        public static void WriteLineWarning(string text)
        {
            if (BootConsole != null) {
                BootConsole.Foreground = ConsoleColor.Yellow;
                BootConsole.Write("Warning: ");
                BootConsole.Foreground = ConsoleColor.White;
                BootConsole.Write(text + "\n");
                BootConsole.Draw();
                Kernel.Canvas.DrawImage(BootConsole.GetBuffer(), 0, 0);
                Kernel.Canvas.Display();
            } else {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Warning: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(text + "\n");
            }
            Logs.DoOSLog("Warning: " + text);
        }

        public static void WriteLineOK(string text)
        {
            if (BootConsole != null) {
                BootConsole.Foreground = ConsoleColor.Green;
                BootConsole.Write("OK: ");
                BootConsole.Foreground = ConsoleColor.White;
                BootConsole.Write(text + "\n");
                BootConsole.Draw();
                Kernel.Canvas.DrawImage(BootConsole.GetBuffer(), 0, 0);
                Kernel.Canvas.Display();
            } else {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Ok: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(text + "\n");
            }
            Logs.DoOSLog("Ok: " + text);
        }

        public static void WriteLineWarning(string text)
        {
            if (BootConsole != null) {
                BootConsole.Foreground = ConsoleColor.DarkRed;
                BootConsole.Write("Error: ");
                BootConsole.Foreground = ConsoleColor.White;
                BootConsole.Write(text + "\n");
                BootConsole.Draw();
                Kernel.Canvas.DrawImage(BootConsole.GetBuffer(), 0, 0);
                Kernel.Canvas.Display();
            } else {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Error: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(text + "\n");
            }
            Logs.DoOSLog("Error: " + text);
        }

    } // public class CustomConsole
} // namespace DynutOS.System