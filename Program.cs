// See https://aka.ms/new-console-template for more information
// 

using System;

class ShortStringsArray
{
    static void Main(string[] args)
    {
        // Input array (can be modified to take input from the user)
        string[] originalArray = { "Russia", "Denmark", "Kazan" };

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

        // Print the new array of short strings
        Console.WriteLine("New array of short strings:");
        if (shortStringsIndex == 0)
        {
            Console.WriteLine("There are no strings with length less than or equal to 3.");
        }
        else
        {
            for (int i = 0; i < shortStringsIndex; i++)
            {
                Console.Write(shortStringsArray[i] + " ");
            }
        }
    }
}

