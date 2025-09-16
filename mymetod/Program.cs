using System;

class Program  
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv in ditt namn: ");
        string name = Console.ReadLine();
        SayHello(name);
        SayGoodbye(name);
    
    }
    static void SayHello(string name)
        {
            Console.WriteLine($"Hej {name}, välkommen till programmet!");
        }
    static void SayGoodbye(string name)
        {
            Console.WriteLine($"Hejdå {name}, hoppas vi ses igen!");
        }
}