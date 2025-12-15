// Copyright 2025 JamilWare Technologies LLC
// SPDX-License-Identifier: gpl-3.0

using System.Diagnostics;
using AdvancedCSharp;
using common;

AnonymousTypes();
Tuples();

void AnonymousTypes()
{
    AnonymousObjectsAreNotEqualByReference();
    AnonymousObjectsAreEqualByValue();
}

void Tuples()
{
    DifferentWaysToInstantiateTuples();
    ValueTuplesAreMutable();
    TuplesAreEqualByValueAndReference();
}


void AnonymousObjectsAreNotEqualByReference()
{
    ConsoleWrapper.StartWritingParagraph("Anonymous Objects are NOT equal by reference");

    var first = new { total = 100, count = 10 };
    var second = new { total = 100, count = 10 };

    Debug.Assert((first == second) == false);

    ConsoleWrapper.WriteCodeLine(" Debug.Assert((first == second) == false);");

    ConsoleWrapper.EndWritingParagraph();
}

void AnonymousObjectsAreEqualByValue()
{
    ConsoleWrapper.StartWritingParagraph("Anonymous Objects are equal by value");

    var first = new { total = 100, count = 10 };
    var second = new { total = 100, count = 10 };

    Debug.Assert(first.Equals(second) == true);

    ConsoleWrapper.WriteCodeLine(" Debug.Assert(first.Equals(second) == true);");

    ConsoleWrapper.EndWritingParagraph();
}


void DifferentWaysToInstantiateTuples()
{
    ConsoleWrapper.StartWritingParagraph("Different Ways to Instantiate Tuples");

    (int, string) first = (1, "Tareq Rabadi");
    ConsoleWrapper.WriteCodeLine(" (int, string) first = (1, \"Tareq Rabadi\");");


    var second = (name: "tareq", 1234, 23.9, CurrentDate: DateTime.Now);
    ConsoleWrapper.WriteCodeLine(" var second = (name: \"tareq\", 1234, 23.9, CurrentDate: DateTime.Now);");


    var (item1, item2, item3) = ("Tareq Rabadi", 123123, new List<string>());
    ConsoleWrapper.WriteCodeLine(" var (item1, item2, item3) = (\"Tareq Rabadi\", 123123, new List<string>());");

    var item01 = 1;
    var item02 = "Tareq Rabadi";

    var (_, listItem, _) = (item01, new List<string>(), item02);
    Console.WriteLine();
    ConsoleWrapper.WriteCodeLine(" var item01 = 1;");
    ConsoleWrapper.WriteCodeLine(" var item02 = \"Tareq Rabadi\";");
    ConsoleWrapper.WriteCodeLine(" var (_, listItem, _) = (item01, new List<string>(), item02);");
    Console.WriteLine();
    var patient = new Patient() { ID = 1, Name = "Tareq Rabadi", Address = "452 N Roosevelt" };

    (var id, var name, _) = patient;
    ConsoleWrapper.WriteCodeLine(" (var id, var name, _) = patient; // with a Deconstructor");

    ConsoleWrapper.EndWritingParagraph();
}

void ValueTuplesAreMutable()
{
    Console.Write("Value Tuples are mutable");
    Console.WriteLine(Environment.NewLine);

    var tuple = (name: "tareq", 1234, 23.9, CurrentDate: DateTime.Now);

    Console.WriteLine($"Before changing current date, the tuple current date is {tuple.CurrentDate}");

    tuple.CurrentDate = new DateTime(1984, 11, 24);

    Console.WriteLine($"After changing current date, the tuple current date is {tuple.CurrentDate}");
}

void TuplesAreEqualByValueAndReference()
{
    Console.WriteLine($"is {(1, "Tareq").Equals((1, "Tareq"))}");
    Console.WriteLine($"is {(1, "Tareq") == (1, "Tareq")}");
}