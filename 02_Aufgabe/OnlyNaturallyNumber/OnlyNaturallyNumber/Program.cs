using System;
class Program {
    static void Main()
    {
        int number;
        while (true)
        {
            Console.Write("Geben Sie eine natürliche Zahl ein!");
            Console.WriteLine();
            string input = Console.ReadLine();
            if(int.TryParse(input, out number) && number > 0) {
                Console.WriteLine("Sie haben die Zahl {0} eingegeben.", number);
            }
            else {
                Console.WriteLine("Das war keine natürliche Zahl!");
            }
        }
    }
}
