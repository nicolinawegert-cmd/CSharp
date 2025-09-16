using System;

class Program
{

    static void Main(string[] args)
    {
        int sum = 0;
        int input;

        Console.WriteLine("Ange heltal ett i taget (avsulta med 0):");

        while (true)
        {
            string line = Console.ReadLine();

            if (int.TryParse(line, out input))
            {
                if (input == 0)
                {
                    break;
                }

                sum += input;
            }

            else
            {
                Console.WriteLine("Ogiltig inmatning. Försök igen.");
            }
        }
        Console.WriteLine("Summa: " + sum);

    }
}