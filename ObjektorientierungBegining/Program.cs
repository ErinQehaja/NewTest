using ObjektorientierungBeginnig;

Console.WriteLine("Willkommen im Tierheim!");

Tierheim meinTierheim = new Tierheim();

Cat cat1 = new Cat(new DateTime(2020, 5, 15));
cat1.Color = "schwarz";
meinTierheim.AddCat(cat1);

Cat cat2 = new Cat(new DateTime(2022, 8, 1));
cat2.Color = "grau";
meinTierheim.AddCat(cat2);

meinTierheim.DisplayAllCats();


//using ObjektorientierungBeginnig;

//DateTime birthDate = new DateTime(2020, 5, 15); 
//Cat myCat = new Cat(birthDate); 

//myCat.Color = "black";
//Console.WriteLine("The color of my cat is " + myCat.Color);
//Console.WriteLine("The age of my cat is " + myCat.Age + " years");