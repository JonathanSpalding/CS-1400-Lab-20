// File Prologue
// Name: Jonathan Spalding
// CS 1400
// Project: Passing Parameters by value and by reference
// Date: 3/22/2016

using System;
using static System.Console;
class Program
{
    static void Main()
    {
        int number1 = 10;
        int number2 = 15;

        // call the Swap method and output the result
        Swap(ref number1, ref number2);
        WriteLine($"number1 = {number1:D}");
        WriteLine($"number2 = {number2:D}");

        ReadKey(true);
    }

    // The Swap method
    // Purpose: To interchange the value of two variables
    // Parameters: two integers
    // Returns: None
    // Pre-conditions: None
    // Post-conditions: None
    // Side Effect: the values of the 2 integers are swapped

    static void Swap(ref int n1, ref int n2)
    {
        int temp = n1;
        n1 = n2;
        n2 = temp;

    }
}
