using System;

class Program

{
    static void Main(string[] args)
    {
        var words = new List<string> { "Äpple", "Banan", "Päron", "Apelsin", "Kiwi" };

        int num = 1;
        Console.WriteLine("Ord lista:");
        foreach (var word in words)
        {
            Console.WriteLine($"{num}. {word}");
            num++;
        }
        int countA = 0;
        foreach (var word in words)
        {
            if (word.ToLower().Contains('a'))
            {
                countA++;
            }
        }
        Console.WriteLine($"Antal ord med 'a': {countA}");
    }
}           