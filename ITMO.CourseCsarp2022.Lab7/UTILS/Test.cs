﻿using System;

public class Test
{
    static void Main()
    {
        string message;

        // Get an input string
        Console.WriteLine("Enter string to reverse:");
        message = Console.ReadLine();

        // Reverse the string
        Utils.Reverse(ref message);

        // Display the result
        Console.WriteLine(message);
    }
}