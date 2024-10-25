using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bitte geben Sie eine Eingabe ein:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            ProcessIntegerInput(number);
        }
        else
        {
            ProcessStringInput(input);
        }
    }

    static void ProcessIntegerInput(int number)
    {
        Console.WriteLine("Sie haben eine ganze Zahl eingegeben. Welche mathematische Operation möchten Sie darauf ausführen?");
        Console.WriteLine("1) Addition\n2) Multiplikation\n3) Division\n4) Fakultät\n5) Wurzelziehen");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Geben Sie eine zweite Zahl für die Addition ein: ");
                if (TryGetInt(out int addValue))
                    Console.WriteLine($"Ergebnis: {number} + {addValue} = {number + addValue}");
                break;

            case "2":
                Console.Write("Geben Sie eine zweite Zahl für die Multiplikation ein: ");
                if (TryGetInt(out int mulValue))
                    Console.WriteLine($"Ergebnis: {number} * {mulValue} = {number * mulValue}");
                break;

            case "3":
                Console.Write("Geben Sie eine zweite Zahl für die Division ein (nicht 0): ");
                if (TryGetInt(out int divValue) && divValue != 0)
                    Console.WriteLine($"Ergebnis: {number} / {divValue} = {(double)number / divValue}");
                else
                    Console.WriteLine("Ungültige Eingabe für die Division (Teilung durch 0 ist nicht erlaubt).");
                break;

            case "4":
                Console.WriteLine($"Ergebnis (Fakultät von {number}): {Factorial(number)}");
                break;

            case "5":
                if (number >= 0)
                    Console.WriteLine($"Ergebnis (Wurzel von {number}): {Math.Sqrt(number)}");
                else
                    Console.WriteLine("Wurzelziehen ist nur für nicht-negative Zahlen erlaubt.");
                break;

            default:
                Console.WriteLine("Ungültige Auswahl.");
                break;
        }
    }

    static void ProcessStringInput(string input)
    {
        Console.WriteLine("Sie haben eine Zeichenkette eingegeben. Was wollen Sie damit machen?");
        Console.WriteLine("1) Alle Selbstlaute (a, e, i, o, u) entfernen");
        Console.WriteLine("2) Die Zeichenkette umdrehen");
        Console.WriteLine("3) Die Anzahl der Zeichen ausgeben");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                string result = new string(input.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());
                Console.WriteLine($"Ergebnis ohne Selbstlaute: {result}");
                break;

            case "2":
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                Console.WriteLine($"Umgekehrte Zeichenkette: {new string(charArray)}");
                break;

            case "3":
                Console.WriteLine($"Anzahl der Zeichen: {input.Length}");
                break;

            default:
                Console.WriteLine("Ungültige Auswahl.");
                break;
        }
    }

    static bool TryGetInt(out int value)
    {
        string input = Console.ReadLine();
        if (int.TryParse(input, out value))
            return true;

        Console.WriteLine("Ungültige Zahl eingegeben.");
        return false;
    }

    static long Factorial(int n)
    {
        if (n < 0) return 0;
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}