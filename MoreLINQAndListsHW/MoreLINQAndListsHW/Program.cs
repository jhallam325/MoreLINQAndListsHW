using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<char> letters = new List<char>();
        int numberOfCharacters = 30;

        for (int i = 0;  i < numberOfCharacters; i++)
        {
            letters.Add(RandomLetter());
        }

        Console.WriteLine("List of letters:");
        foreach (char letter in letters)
        {
            Console.Write($"{letter} ");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("List of ascending letters:");
        var ascendingLetters = 
            from letter in letters
            orderby letter
            select letter;

        foreach (char letter in ascendingLetters)
        {
            Console.Write($"{letter} ");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("List of descending letters:");
        
        var descendingLetters = 
            from letter in letters
            orderby letter descending
            select letter;

        foreach (char letter in descendingLetters)
        {
            Console.Write($"{letter} ");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("List of ascending characters with no duplicates:");  

        foreach(char letter in ascendingLetters.Distinct())
        {
            Console.Write($"{letter} ");
        }
        Console.WriteLine();
        Console.WriteLine(); 
        Console.WriteLine();
        Console.WriteLine();

    }

    public static char RandomLetter()
    {
        Random random = new Random();
        char letter = (char) random.Next(65,91);
        return letter;
    }
}