using System;
using System.Collections.Generic;

namespace ObjektorientierungBeginnig
{
    class Tierheim
    {
        private List<Cat> _cats;

        public Tierheim()
        {
            _cats = new List<Cat>();
        }

        public void AddCat(Cat cat)
        {
            _cats.Add(cat);
            Console.WriteLine("Eine neue Katze wurde aufgenommen.");
        }

        public void DisplayAllCats()
        {
            if (_cats.Count == 0)
            {
                Console.WriteLine("Das Tierheim hat keine Katzen.");
            }
            else
            {
                Console.WriteLine("Im Tierheim befinden sich die folgenden Katzen:");
                foreach (var cat in _cats)
                {
                    Console.WriteLine(cat);
                    cat.gibTypischenLautVonDir();
                }
            }
        }

        public override string ToString()
        {
            if (_cats.Count == 0)
            {
                return "Das Tierheim hat keine Katzen.";
            }

            string result = "Im Tierheim befinden sich die folgenden Katzen:\n";
            foreach (var cat in _cats)
            {
                result += cat.ToString() + "\n";
            }
            return result;
        }
    }
}