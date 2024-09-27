using System;
class Program {
    static void Main()
    {
        int number;
        string input = "";

        while (input != "Beenden")
        {
            Console.Write("Geben Sie eine natürliche Zahl ein!");
            Console.WriteLine();
            input = Console.ReadLine();

            if (int.TryParse(input, out number) && number > 0) {
                Console.WriteLine("Sie haben die Zahl {0} eingegeben.", number);
            }

            else {
                if (input != "Beenden")
                {
                    Console.WriteLine("Das war keine natürliche Zahl!");
                }
            }
        }
    }
}