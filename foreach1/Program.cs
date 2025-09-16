using System;

class Program
{
    static void Main()
    {
        string[] words = { "Äpple", "Banan", "Päron", "Apelsin", "Kiwi" };

        int counter = 1; 
        int aCount = 0;  

        foreach (string word in words)
        {
            Console.WriteLine($"{counter}. {word}");
            counter++;

            if (word.ToLower().Contains('a'))
            {
                aCount++;
            }
        }

        Console.WriteLine($"Antal ord med 'a': {aCount}");
    }
}
