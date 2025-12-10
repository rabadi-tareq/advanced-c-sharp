using System.Diagnostics;
using AdvancedCSharp;

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
    ConsoleEx.StartWritingParagraph("Anonymous Objects are NOT equal by reference");

    var first = new { total = 100, count = 10 };
    var second = new { total = 100, count = 10 };

    Debug.Assert((first == second) == false);

    ConsoleEx.WriteCodeLine(" Debug.Assert((first == second) == false);");

    ConsoleEx.EndWritingParagraph();
}

void AnonymousObjectsAreEqualByValue()
{
    ConsoleEx.StartWritingParagraph("Anonymous Objects are equal by value");

    var first = new { total = 100, count = 10 };
    var second = new { total = 100, count = 10 };

    Debug.Assert(first.Equals(second) == true);

    ConsoleEx.WriteCodeLine(" Debug.Assert(first.Equals(second) == true);");

    ConsoleEx.EndWritingParagraph();
}


void DifferentWaysToInstantiateTuples()
{
    ConsoleEx.StartWritingParagraph("Different Ways to Instantiate Tuples");

    (int, string) first = (1, "Tareq Rabadi");
    ConsoleEx.WriteCodeLine(" (int, string) first = (1, \"Tareq Rabadi\");");


    var second = (name: "tareq", 1234, 23.9, CurrentDate: DateTime.Now);
    ConsoleEx.WriteCodeLine(" var second = (name: \"tareq\", 1234, 23.9, CurrentDate: DateTime.Now);");


    var (item1, item2, item3) = ("Tareq Rabadi", 123123, new List<string>());
    ConsoleEx.WriteCodeLine(" var (item1, item2, item3) = (\"Tareq Rabadi\", 123123, new List<string>());");

    var item01 = 1;
    var item02 = "Tareq Rabadi";

    var (_, listItem, _) = (item01, new List<string>(), item02);
    Console.WriteLine();
    ConsoleEx.WriteCodeLine(" var item01 = 1;");
    ConsoleEx.WriteCodeLine(" var item02 = \"Tareq Rabadi\";");
    ConsoleEx.WriteCodeLine(" var (_, listItem, _) = (item01, new List<string>(), item02);");
    Console.WriteLine();
    var patient = new Patient() { ID = 1, Name = "Tareq Rabadi", Address = "452 N Roosevelt" };

    (var id, var name, _) = patient;
    ConsoleEx.WriteCodeLine(" (var id, var name, _) = patient; // with a Deconstructor");

    ConsoleEx.EndWritingParagraph();
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