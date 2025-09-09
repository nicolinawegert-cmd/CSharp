using System;

namespace CalculatorApp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till miniräknaren!");
            Console.WriteLine("välj en operation: +, -, *, /");
            string operation = Console.ReadLine();
            Console.WriteLine("Ange det första talet:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ange det andra talet;");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Fel: Division med noll är inte tillåten.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Fel: Ogiltig operation.");
                    return;
            }
            Console.WriteLine("Resultatet är: " + result);
        }
    }
}
