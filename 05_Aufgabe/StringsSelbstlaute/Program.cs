using System;

class Program
{
    static void Main()
    {
        while (true) 
        {
            Console.WriteLine("Gib einen Text ein (oder 'Beenden' zum Beenden):");
            string input = Console.ReadLine().ToLower(); 

            if (input == "beenden") 
            {
                break; 
            }

            int counter = 0; 
            char[] buchstaben = input.ToCharArray();

            for (int i = 0; i < buchstaben.Length; i++)
            {
                if (buchstaben[i] == 'a')
                {
                    counter++;
                }
                if (buchstaben[i] == 'e')
                {
                    counter++;
                }
                if (buchstaben[i] == 'i')
                {
                    counter++;
                }
                if (buchstaben[i] == 'o')
                {
                    counter++;
                }
                if (buchstaben[i] == 'u')
                {
                    counter++;
                }
            }

            Console.WriteLine($"Es waren {counter} Selbstlaute in dem Text, den du eingegeben hast!");
            Console.WriteLine();
        }
    }
}