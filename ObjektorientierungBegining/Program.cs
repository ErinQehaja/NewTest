using ObjektorientierungBeginnig;
using System;

Console.WriteLine("Willkommen im Tierheim!");

Tierheim meinTierheim = new Tierheim();

Cat cat1 = new Cat("Kitty", new DateTime(2019, 5, 15))
{
    Color = "schwarz"
};
meinTierheim.AddCat(cat1);

Cat cat2 = new Cat("Misty", new DateTime(2022, 8, 1))
{
    Color = "grau"
};
meinTierheim.AddCat(cat2);

meinTierheim.DisplayAllCats();