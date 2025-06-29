using System;
using System.Collections.Generic;
using System.IO;

namespace AT.Delegates_Eventos
{
    public static class LoggerHelper
    {
        public static List<string> LogMemory = new List<string>();

        public static void LogToConsole(string message)
        {
            Console.WriteLine($"[Console] {message}");
        }

        public static void LogToFile(string message)
        {
            string filePath = "log.txt";
            File.AppendAllText(filePath, $"[Arquivo] {message}{Environment.NewLine}");
        }

        public static void LogToMemory(string message)
        {
            LogMemory.Add($"[Memória] {message}");
        }
    }
}
