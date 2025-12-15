// Copyright 2025 JamilWare Technologies
// SPDX-License-Identifier: gpl-3.0

﻿using common;
using static System.Console;

namespace version_6
{
    internal static class Features
    {
        internal static class NullConditionalOperator
        {

            internal static void Run()
            {
                ConsoleWrapper.StartWritingParagraph("Null Conditional Operator (Elvis)");

                

                WriteLine(@"The null-conditional operator applies to objects, 
it could be an array or an item in an array, 
it also can be chained");

                

                var cities = new[] {"Canton", null, "Ann Arbor", "Oak Park"};


                
                


                int? length = cities?[1]?.Length ?? 0;
                WriteLine("The statement - > int? length = cities?[1]?.Length ?? 0;  checks for the array being null or one of its items");
                WriteLine($"List of cities are {string.Join(',', cities)}");
                WriteLine($"Length of the second city, which is null, is {length} characters");
            }
        }

        internal static class StringInterpolation
        {
            internal static void Run()
            {
                WriteLine("================================ String Interpolation ===========================================");

                var today = DateTime.Now;
                var price = 20.95m;
                var largeNumber = 1234567;

                WriteLine($"Displaying Today in the format of day name, month name, day and year is {today:dddd, MMMM dd, yyyy}"); 

                WriteLine($"The price is {price:C3}"); 

                WriteLine($"Number with commas and two decimal digits: {largeNumber:N2}");  

                WriteLine($"Display Pi in fixed point format of two decimals: {Math.PI:F2}");

                var item = "Laptop";
                var cost = 999.99m;

                WriteLine($"|{"Item",-15}|{"Cost",10}|"); // Left-align Item, Right-align Cost
                WriteLine($"|{item,-15}|{cost,10:C2}|");  // Left-align value, Right-align formatted currency


                int age = 3;
                string noun = $"year{(age == 1 ? "" : "s")}"; // Ternary operator for singular/plural

                WriteLine($"Horace is {age} {noun} old.");
                // Output: Horace is 1 year old.

                

                double temperature = 22.5;

                // Output varies based on the computer's locale (e.g., 22,5 in some regions)
                Console.WriteLine($"Current temperature: {temperature}");

                // Forces formatting using the invariant culture (always 22.5 with a period)
                string invariantTemp = FormattableString.Invariant($"Current temperature: {temperature}");
                WriteLine(invariantTemp);

                var path = @"C:\Users\Admin";
                var message = $@"
Hello user,
The current path is: {path}
The file will be saved to this location.
";

                WriteLine(message);



            }
        }

        private static void NewLine()
        {
            WriteLine(Environment.NewLine);
        }
    }
}
