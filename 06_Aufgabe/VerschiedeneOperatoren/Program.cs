using System;

class Program
{
    static long Fakultaet(int n)
    {
        if (n < 0) return 0;
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
    static void Main()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Wählen Sie eine mathematische Operation, indem Sie die entsprechende Nummer eingeben:");
            Console.WriteLine("1) Multiplizieren");
            Console.WriteLine("2) Dividieren");
            Console.WriteLine("3) Addieren");
            Console.WriteLine("4) Potenzieren");
            Console.WriteLine("5) Wurzelziehen");
            Console.WriteLine("6) Fakultät");
            Console.WriteLine("7) Invertieren");

            string operationInput = Console.ReadLine();
            if (operationInput == "Beenden")
            {
                break;
            }

            if (!int.TryParse(operationInput, out int operation) || operation < 1 || operation > 7)
            {
                Console.WriteLine("Bitte gib eine gültige Zahl zwischen 1-7 ein!");
                continue;
            }

            int zahl1, zahl2 = 0;
            if (operation != 5 && operation != 6 && operation != 7)
            {
                Console.WriteLine("Bitte gib die erste Zahl ein!");
                while (!int.TryParse(Console.ReadLine(), out zahl1))
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte eine Ganzzahl eingeben:");
                }

                Console.WriteLine("Bitte gib die zweite Zahl ein!");
                while (!int.TryParse(Console.ReadLine(), out zahl2))
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte eine Ganzzahl eingeben:");
                }
            }
            else
            {
                Console.WriteLine("Bitte gib eine Zahl ein");
                while (!int.TryParse(Console.ReadLine(), out zahl1))
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte eine Ganzzahl eingeben:");
                }
            }

            switch (operation)
            {
                case 1:
                    Console.WriteLine($"Das Ergebnis ist {zahl1 * zahl2}!");
                    break;
                case 2:
                    if (zahl2 != 0)
                    {
                        Console.WriteLine($"Das Ergebnis ist {zahl1 / zahl2}!");
                    }
                    else
                    {
                        Console.WriteLine("Division durch Null ist nicht erlaubt!");
                    }
                    break;
                case 3:
                    Console.WriteLine($"Das Ergebnis ist {zahl1 + zahl2}!");
                    break;
                case 4:
                    Console.WriteLine($"Das Ergebnis ist {Math.Pow(zahl1, zahl2)}!");
                    break;
                case 5:
                    if (zahl1 >= 0)
                    {
                        Console.WriteLine($"Das Ergebnis ist {Math.Sqrt(zahl1)}");
                    }
                    else
                    {
                        Console.WriteLine("Das Wurzelziehen von negativen Zahlen ist nicht möglich!");
                    }
                    break;
                case 6:
                    if (zahl1 >= 0)
                    {
                        Console.WriteLine($"Das Ergebnis ist {Fakultaet(zahl1)}");
                    }
                    else
                    {
                        Console.WriteLine("Die Fakultät von negativen Zahlen ist nicht möglich!");
                    }
                    break;
                case 7:
                    if (zahl1 != 0)
                    {
                        Console.WriteLine($"Die Kehrzahl der Nummer " + zahl1 + $" ist {1.0 / zahl1}!");
                    }
                    else
                    {
                        Console.WriteLine("Die Kehrzahl von 0 ist nicht definiert!");
                    }
                    break;
                default:
                    Console.WriteLine("Bitte gib eine Zahl zwischen 1-7 ein!");
                    break;
            }
        }
    }
}