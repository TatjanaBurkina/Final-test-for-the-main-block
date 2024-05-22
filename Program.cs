// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System;

class Program
{
    static void Main()
    {
        string[][] originalArray = new string[][]
        {
            new string[] { "Hello", "2", "world", ":-)" },
            // Другие массивы строк могут быть добавлены здесь
        };

        string[] newArray = GenerateNewArray(originalArray);

        Console.WriteLine("New Array:");
        foreach (string str in newArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] GenerateNewArray(string[][] originalArray)
    {
        int count = 0;
        foreach (string[] arr in originalArray)
        {
            foreach (string str in arr)
            {
                if (str.Length <= 3)
                {
                    count++;
                }
            }
        }

        string[] resultArray = new string[count];
        int index = 0;
        foreach (string[] arr in originalArray)
        {
            foreach (string str in arr)
            {
                if (str.Length <= 3)
                {
                    resultArray[index] = str;
                    index++;
                }
            }
        }

        return resultArray;
    }
}
