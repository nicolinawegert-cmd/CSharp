using System;

class Program
{
    static void Main()
    {
        Console.Write("Ange ett betyg (1-5): ");
        int grade;

        // Kontrollera att inmatningen är ett heltal
        if (int.TryParse(Console.ReadLine(), out grade))
        {
            switch (grade)
            {
                case 1:
                    Console.WriteLine("Underkänt");
                    break;
                case 2:
                    Console.WriteLine("Godkänt");
                    break;
                case 3:
                    Console.WriteLine("Bra");
                    break;
                case 4:
                    Console.WriteLine("Väl godkänt");
                    break;
                case 5:
                    Console.WriteLine("Utmärkt");
                    break;
                default:
                    Console.WriteLine("Ogiltigt betyg");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Du måste ange ett heltal!");
        }
    }
}
