using ObjektorientierungBegining;
using ObjektorientierungBeginnig;
using System.Security.Cryptography.X509Certificates;

namespace TestTierheim
{
    public class TestTierheim
    {
        [SetUp]

        public void Setup()
        {
            Animal.AllAnimals.Clear();
        }

        [Test]
        public void AddAnimal_AddOneCatAndOneDog_ReturnsTwoAnimals()
        {
            var myTierheim = new Tierheim();

            Cat cat1 = new Cat("Kitty", new DateTime(2019, 5, 15), "schwarz");
            Dog dog1 = new Dog("Rex", new DateTime(2020, 3, 10), "braun");

            Assert.IsTrue(myTierheim.NumberOfAnimals == 2);
        }

        [Test]
        public void Age_SetBirthDate_ReturnsCorrectAge()
        {
            var cat = new Cat("Litty", new DateTime(2017, 5, 15), "blau");

            int expectedAge = DateTime.Now.Year - 2017;
            if (DateTime.Now < new DateTime(DateTime.Now.Year, 5, 15))
            {
                expectedAge--;
            }

            Assert.AreEqual(expectedAge, cat.Age());
        }

        [Test]
        public void CalculateAverageAge_EmptyTierheim_ReturnsZero()
        {
            var myTierheim = new Tierheim();

            double averageAge = myTierheim.CalculateAverageAge();

            Assert.AreEqual(0, averageAge);
        }

        [Test]
        public void CalculateAverageAge_MultipleAnimals_ReturnsCorrectAverage()
        {
            var myTierheim = new Tierheim();

            Cat cat1 = new Cat("Kitty", new DateTime(2019, 5, 15), "schwarz");
            Dog dog1 = new Dog("Rex", new DateTime(2020, 3, 10), "braun");
            Dog dog2 = new Dog("Bella", new DateTime(2021, 7, 5), "weiß");

            int ageCat1 = DateTime.Now.Year - 2019;
            int ageDog1 = DateTime.Now.Year - 2020;
            int ageDog2 = DateTime.Now.Year - 2021;

            if (DateTime.Now < new DateTime(DateTime.Now.Year, 5, 15)) ageCat1--;
            if (DateTime.Now < new DateTime(DateTime.Now.Year, 3, 10)) ageDog1--;
            if (DateTime.Now < new DateTime(DateTime.Now.Year, 7, 5)) ageDog2--;

            double expectedAverage = (ageCat1 + ageDog1 + ageDog2) / 3;

            double averageAge = myTierheim.CalculateAverageAge();

            Assert.AreEqual(expectedAverage, averageAge);
        }
    }
}