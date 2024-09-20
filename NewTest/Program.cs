// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";

        while (true)
        {
            ConsoleKeyInfo keyInfo;
            input = "";

            Console.WriteLine("Geben Sie Text ein und drücken Sie <Enter>. Schreiben Sie 'Beenden' zum Beenden:");

            do
            {
                keyInfo = Console.ReadKey(true); 
                if (keyInfo.Key != ConsoleKey.Enter) 
                {
                    input += keyInfo.KeyChar; 
                    Console.Write(keyInfo.KeyChar); 
                }
            } while (keyInfo.Key != ConsoleKey.Enter);

            Console.WriteLine(); 

            if (input == "Beenden")
            {
                break;
            }

            Console.WriteLine("Eingegebener Text: " + input);
        }

        Console.WriteLine("Programm beendet.");
    }
}