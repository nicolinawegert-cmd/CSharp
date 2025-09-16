using System;

class Program
{
    static void Main(string[] args)
    { 
        Console.Write("Tal 1..10:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        
        Console.Write("Jämna 2..20:");
        for (int i = 2; i <= 20; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}