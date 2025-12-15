// Copyright 2025 JamilWare Technologies LLC
// SPDX-License-Identifier: gpl-3.0

using static System.Console;

﻿namespace common
{
    public static class ConsoleWrapper
    {
        private static readonly ConsoleColor DefaultConsoleForegroundColor = ConsoleColor.Gray;
        public static void StartWritingParagraph(string title)
        {
            var width = (WindowWidth - title.Length - 2) / 2;
            var tiles = string.Join("", Enumerable.Range(1, width).Select(i => "="));
            ForegroundColor = ConsoleColor.Green;
            WriteLine($"{tiles} {title} {tiles}");

            //WriteLine(title);
            WriteLine(Environment.NewLine);

            ResetColor();
        }

        public static void EndWritingParagraph()
        {
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine(string.Join("", Enumerable.Range(1, WindowWidth).Select(i => "=")));
            WriteLine();
            ResetColor();
        }

        public static void WriteCodeLine(string codeLine)
        {
            WriteLine(codeLine);

        }
    }
}
