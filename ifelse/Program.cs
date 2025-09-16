using System;

namespace AgeClasification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();

            Console.WriteLine("Ange din ålder:");
            int age;

            if (int.TryParse(Console.ReadLine(), out age))
            {
                if (age < 18)
                {
                    Console.WriteLine($"{name} Du är minderårig.");
                }
                else if (age >= 18 && age < 65)
                {
                    Console.WriteLine($"{name} Du är vuxen.");
                }
                else
                {
                    Console.WriteLine($"{name} Du är pensionär.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
                return;
            }

        }
    }
}
