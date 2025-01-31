using System;
using NUnit.Framework;

namespace TestBitAdder
{
    public class TestBitAdder
    {
        [Test]
        public void AddTwoBinaryNumbers_TestCase1()
        {
            int a = 0b1111; // 15
            int b = 0b0001; // 1
            int expectedResult = 0b00000; // 16
            int expectedCarryOut = 1; 

            var (result, carryOut) = BitAdder.FourBitAdder(a, b);

            Assert.AreEqual(expectedResult, result, "Das Ergebnis stimmt nicht überein.");
            Assert.AreEqual(expectedCarryOut, carryOut, "Der Übertrag stimmt nicht.");
        }

        [Test]
        public void AddTwoBinaryNumbers_TestCase2()
        {
            int a = 0b1010; // 10
            int b = 0b0101; // 5
            int expectedResult = 0b1111; // 15
            int expectedCarryOut = 0; 

            var (result, carryOut) = BitAdder.FourBitAdder(a, b);

            Assert.AreEqual(expectedResult, result, "Das Ergebnis stimmt nicht überein.");
            Assert.AreEqual(expectedCarryOut, carryOut, "Der Übertrag stimmt nicht.");
        }

        [Test]
        public void AddTwoBinaryNumbers_TestCase3()
        {
            int a = 0b0110; // 6
            int b = 0b0110; // 6
            int expectedResult = 0b1100; // 12
            int expectedCarryOut = 0; 

            var (result, carryOut) = BitAdder.FourBitAdder(a, b);

            Assert.AreEqual(expectedResult, result, "Das Ergebnis stimmt nicht überein.");
            Assert.AreEqual(expectedCarryOut, carryOut, "Der Übertrag stimmt nicht.");
        }
    }
}