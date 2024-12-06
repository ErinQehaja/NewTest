using ObjektorientierungBegining;
using ObjektorientierungBeginnig;

namespace TestTierheim
{
    public class TestTierheim
    {
        [SetUp]

        public void Setup() { }

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
    }
}
