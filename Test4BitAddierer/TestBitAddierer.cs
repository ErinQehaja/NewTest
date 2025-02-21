using System;
using NUnit.Framework;

namespace TestBitAdder
{
    public class TestBitAdder
    {
        [Test]
        public void HalfAdder_ab_sumcarry()
        {
            Assert.AreEqual((0, 0), BitAdder.HalfAdder(0, 0));
            Assert.AreEqual((1, 0), BitAdder.HalfAdder(0, 1));
            Assert.AreEqual((1, 0), BitAdder.HalfAdder(1, 0));
            Assert.AreEqual((0, 1), BitAdder.HalfAdder(1, 1));
        }

        [Test]
        public void FullAdder_abcarryin_sumcarry()
        {
            Assert.AreEqual((0, 0), BitAdder.FullAdder(0, 0, 0));
            Assert.AreEqual((1, 0), BitAdder.FullAdder(0, 1, 0));
            Assert.AreEqual((1, 0), BitAdder.FullAdder(1, 0, 0));
            Assert.AreEqual((0, 1), BitAdder.FullAdder(1, 1, 0));
            Assert.AreEqual((1, 0), BitAdder.FullAdder(0, 0, 1));
            Assert.AreEqual((0, 1), BitAdder.FullAdder(0, 1, 1));
            Assert.AreEqual((0, 1), BitAdder.FullAdder(1, 0, 1));
            Assert.AreEqual((1, 1), BitAdder.FullAdder(1, 1, 1));
        }

        [Test]
        public void FourBitAdder_ab_resultcarry()
        {
            Assert.AreEqual((0b0000, 0), BitAdder.FourBitAdder(0b0000, 0b0000));
            Assert.AreEqual((0b0001, 0), BitAdder.FourBitAdder(0b0000, 0b0001));
            Assert.AreEqual((0b0010, 0), BitAdder.FourBitAdder(0b0001, 0b0001));
            Assert.AreEqual((0b1010, 1), BitAdder.FourBitAdder(0b1111, 0b1011));
        }
    }
}