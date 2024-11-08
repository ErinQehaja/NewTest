using ObjektorientierungBeginnig;

Console.WriteLine("Hello World!");

DateTime birthDate = new DateTime(2020, 5, 15); 
Cat myCat = new Cat(birthDate); 

myCat.Color = "black";
Console.WriteLine("The color of my cat is " + myCat.Color);
Console.WriteLine("The age of my cat is " + myCat.Age + " years");