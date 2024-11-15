using ObjektorientierungBeginnig;

Console.WriteLine("Willkommen im Tierheim!");

Tierheim meinTierheim = new Tierheim();

Cat cat1 = new Cat(new DateTime(2020, 5, 15))
{
    Color = "schwarz"
};
meinTierheim.AddCat(cat1);

Cat cat2 = new Cat(new DateTime(2022, 8, 1))
{
    Color = "grau"
};
meinTierheim.AddCat(cat2);

meinTierheim.DisplayAllCats();
