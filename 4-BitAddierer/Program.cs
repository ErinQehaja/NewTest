using System;

public class BitAdder
{
    public static (int sum, int carry) HalfAdder(int a, int b)
    {
        int sum = a ^ b;
        int carry = a & b;
        return (sum, carry);
    }

    public static (int sum, int carry) FullAdder(int a, int b, int carryIn)
    {
        var halfAdder1 = HalfAdder(a, b);
        var halfAdder2 = HalfAdder(halfAdder1.sum, carryIn);

        int sum = halfAdder2.sum;
        int carry = (halfAdder1.carry | halfAdder2.carry);

        return (sum, carry);
    }

    public static (int result, int carryOut) FourBitAdder(int a, int b)
    {
        int carryIn = 0;
        int result = 0;

        for (int i = 0; i < 4; i++)
        {
            int bitA = (a >> i) & 1;
            int bitB = (b >> i) & 1;

            var fullAdder = FullAdder(bitA, bitB, carryIn);
            result |= (fullAdder.sum << i);

            carryIn = fullAdder.carry;
        }

        return (result, carryIn);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Gib die erste 4-Bit Zahl ein (z.B. 1101):"); 
        string inputA = Console.ReadLine();
        int a = Convert.ToInt32(inputA, 2);

        Console.WriteLine("Gib die zweite 4-Bit Zahl ein (z.B. 1011):");
        string inputB = Console.ReadLine();
        int b = Convert.ToInt32(inputB, 2);

        var (result, carryOut) = FourBitAdder(a, b);

        Console.WriteLine($"Ergebnis: {Convert.ToString(result, 2).PadLeft(4, '0')} (binär), Übertrag: {carryOut}");
        Console.WriteLine($"Ergebnis in Dezimal: {result + (carryOut << 4)}");
    }
}