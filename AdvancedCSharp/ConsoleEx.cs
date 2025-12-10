using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    public static class ConsoleEx
    {
        private static readonly ConsoleColor DefaultConsoleForegroundColor = ConsoleColor.Gray;
        public static void StartWritingParagraph(string title)
        {
            var width = (Console.WindowWidth - title.Length - 2) / 2;
            var tiles = string.Join("", Enumerable.Range(1, width).Select(i => "="));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{tiles} {title} {tiles}");

            //Console.WriteLine(title);
            Console.WriteLine(Environment.NewLine);

            Console.ResetColor();
        }

        public static void EndWritingParagraph()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(string.Join("", Enumerable.Range(1, Console.WindowWidth).Select(i => "=")));
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void WriteCodeLine(string codeLine)
        {
            Console.WriteLine(codeLine);

        }
    }
}
