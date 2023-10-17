using System;
using Tokenizer;


Tokenizer.Tokenizer tokenizer = new();

while (true)
{
    Console.WriteLine("-----Enter Calculation-----");
    string? input = Console.ReadLine();

    if (input == null || input == "")
    {
        continue;
    }

    tokenizer.Input = input;
    try
    {
        var output = tokenizer.Tokenize();

        Console.WriteLine($"Result: {output.Eval()}");
    }
    catch (InvalidDataException e)
    {
        Console.WriteLine($"Invalid input: {e.Message}");
    }
}
