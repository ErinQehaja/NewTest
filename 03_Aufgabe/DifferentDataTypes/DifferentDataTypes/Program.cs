using System;

class Program
{
    static void Main(string[] args)
    {
        int number;
        bool result;
        double kommaZahl;
        DateTime datum = new DateTime(2024, 9, 27);

        string input = "";

        while (true)
        {
            Console.WriteLine("Mögliche akzeptierte Werte zum Eingeben:");
            Console.WriteLine("- Eine natürliche Zahl");
            Console.WriteLine("- 'Wahr' ");
            Console.WriteLine("- 'Falsch' ");
            Console.WriteLine("- Kommazahl");
            Console.WriteLine("- Ein Datum");

            input = Console.ReadLine();

            if (int.TryParse(input, out number) && number > 0)
            {
                Console.WriteLine("Sie haben die Zahl {0} eingeben.", number);
            }
            if (input.Equals("Wahr", StringComparison.OrdinalIgnoreCase))
            {
                result = true;
                Console.WriteLine("Sie haben eingegeben: (bool: {1})", result);
            }
            else if (input.Equals("Falsch", StringComparison.OrdinalIgnoreCase))
            {
                result = false;
                Console.WriteLine("Sie haben eingegeben: (bool: {1})", result);
            }
        }
    }
}