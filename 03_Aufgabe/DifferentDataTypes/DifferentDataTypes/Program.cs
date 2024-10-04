using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        bool hasPreviousOutput = false;
        while (input != "Beenden")
        {
            if (hasPreviousOutput)
            {
                Console.WriteLine();
            }
            else
            {
                hasPreviousOutput = true;
            }
            Console.WriteLine("Mögliche akzeptierte Werte zum Eingeben:");
            Console.WriteLine("- Eine natürliche Zahl");
            Console.WriteLine("- 'True' ");
            Console.WriteLine("- 'False' ");
            Console.WriteLine("- Kommazahl");
            Console.WriteLine("- Ein Datum [Tag, Monat, Jahr]");
            Console.WriteLine();
            input = Console.ReadLine();

            bool boolValue;
            if (bool.TryParse(input, out boolValue))
            {
                Console.WriteLine("Der Datentyp ist: Bool");
                Console.WriteLine($"Erkannte Variable: {boolValue}");
            }
            else if (int.TryParse(input, out int intValue))
            {
                Console.WriteLine("Der Datentyp ist: Integer");
                Console.WriteLine($"Erkannte Variable: {intValue}");
            }
            else if (double.TryParse(input, CultureInfo.InvariantCulture, out double doubleValue))
            {
                Console.WriteLine("Der Datentyp ist: Double");
                Console.WriteLine($"Erkannte Variable: {doubleValue}");
            }
            else if (DateTime.TryParse(input, out DateTime dateValue))
            {
                Console.WriteLine("Der Datentyp ist: Datum");
                Console.WriteLine($"Erkannte Variable: {dateValue.ToShortDateString()}");
            }
            else
            {
                if (input != "Beenden")
                {
                    Console.WriteLine("Der eingegebene Wert konnte keinem Datentyp zugeordnet werden.");
                }
            }
        }
    }
}