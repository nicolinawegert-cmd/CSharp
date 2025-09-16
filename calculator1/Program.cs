using System;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Välj en operation:");
      Console.WriteLine("1. Addition");
      Console.WriteLine("2. Subtraktion");
      Console.WriteLine("3. Multiplikation");
      Console.WriteLine("4. Division");

      int choice;
      if (!int.TryParse(Console.ReadLine(), out choice))
      {
          Console.WriteLine("Du måste skriva ett heltal mellan 1 och 4.");
          return;
      }
        Console.WriteLine("Ange det första talet:");
        int x;
        while (!int.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Ogiltig inmatning. Vänligen ange ett heltal:");
        }
        Console.WriteLine("Ange det andra talet:");
        int y;
        while (!int.TryParse(Console.ReadLine(), out y))
        {
            Console.WriteLine("Ogiltig inmatning. Vänligen ange ett heltal:");
        }

        switch (choice)
        {
            case 1: Console.WriteLine($"Resultat: {Add(x, y)}"); break;
            case 2: Console.WriteLine($"Resultat: {Subtract(x, y)}"); break;
            case 3: Console.WriteLine($"Resultat: {Multiply(x, y)}"); break;
            case 4: Console.WriteLine($"Resultat: {Divide(x, y)}"); break;
            default: Console.WriteLine("Ogiltigt val. Vänligen välj ett nummer mellan 1 och 4."); break;    
        }
    
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static double Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Fel: Division med noll är inte tillåten.");
                return double.NaN;
            }
            return (double)a / b;
        }
    }  
}   