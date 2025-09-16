using System;

namespace HelloWorld
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Hej världen!");
            Console.WriteLine("Mitt namn är Nicolina");
            Console.WriteLine("Idag är det " + DateTime.Now.ToShortDateString());

            string favoritFärg = "Blå";
            Console.WriteLine("Min favoritfärg är " + favoritFärg);

            Console.WriteLine("Vad heter du?");
            string namn = Console.ReadLine();
            Console.WriteLine("Hej, " + namn + "!");
        }
    }
}