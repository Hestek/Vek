using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double vek;
            double rok;
            double vypocet;

            Console.CursorVisible = false;
            Console.SetCursorPosition(10, 10);
            Console.WriteLine();
            Console.SetCursorPosition(10, 11);
            Console.WriteLine("Zadejte svůj rok narození");
            double.TryParse(Console.ReadLine(), out rok);
            Console.SetCursorPosition(10, 12);
            Console.WriteLine();
            Console.ReadLine();

            vypocet = ( - rok);
            if (vypocet > 100) 
            Console.WriteLine("Neplatny rok narození");
            if (vypocet < 100) 
            Console.WriteLine($"Je vam { vypocet } let");

        }
    }
}
