using System;

class Program
{
    static long Fakultät(int n)
    {
        long ergebnis = 1;
        for (int i = 2; i <= n; i++)
        {
            ergebnis *= i;
        }
        return ergebnis;
    }

    static void Main()
    {
        int number;
        string input = "";

        while (true)
        {
            Console.WriteLine("Geben Sie eine natürliche Zahl ein (oder 'Beenden' zum Beenden):");
            input = Console.ReadLine();

            if (input == "Beenden")
            {
                break; 
            }

            if (int.TryParse(input, out number) && number > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Sie haben die Zahl {0} eingegeben.", number);

                Console.WriteLine("Wählen Sie zwischen einer dieser 3 Operatoren, indem sie eine Zahl zwischen 1-3 eingeben:");
                Console.WriteLine("1) Quadrat");
                Console.WriteLine("2) Wurzel");
                Console.WriteLine("3) Fakultät");

                string operatorInput = Console.ReadLine();

                if (operatorInput == "1")
                {
                    double quadratErgebnis = Math.Pow(number, 2);
                    Console.WriteLine();
                    Console.WriteLine($"{number} hoch 2 ist {quadratErgebnis}");
                }
                else if (operatorInput == "2")
                {
                    double wurzelErgebnis = Math.Sqrt(number);
                    Console.WriteLine();
                    Console.WriteLine($"Die Wurzel von {number} ist {wurzelErgebnis}");
                }
                else if (operatorInput == "3")
                {
                    long fakultätErgebnis = Fakultät(number);
                    Console.WriteLine();
                    Console.WriteLine($"{number}! ist {fakultätErgebnis}");
                }
                else
                {
                    Console.WriteLine("Ungültige Auswahl! Bitte wählen Sie 1, 2 oder 3.");
                }
            }
            else
            {
                Console.WriteLine("Das war keine natürliche Zahl!");
            }

            Console.WriteLine(); 
        }
    }
}