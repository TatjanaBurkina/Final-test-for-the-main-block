// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

class ShortStringsArray
{
    static void Main(string[] args)
    {
        // Input array (can be modified to take input from the user)
        string[] originalArray = { "1234", "1567", "-2", "computer science" };

        // Create a new array to store short strings
        string[] shortStringsArray = new string[originalArray.Length];

        // Counter to track the index in the new array
        int shortStringsIndex = 0;

        // Iterate through the original array
        foreach (string str in originalArray)
        {
            // Check if the string length is less than or equal to 3
            if (str.Length <= 3)
            {
                // Add the short string to the new array
                shortStringsArray[shortStringsIndex++] = str;
            }
        }

        // Resize the new array to the actual number of short strings (optional)
        Array.Resize(ref shortStringsArray, shortStringsIndex);

        // Print the new array of short strings
        Console.WriteLine("New array of short strings:");
        foreach (string str in shortStringsArray)
        {
            Console.Write(str + " ");
        }
    }
}
