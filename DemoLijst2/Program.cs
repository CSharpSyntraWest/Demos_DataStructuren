using System;
using System.Collections.Generic;

namespace DemoLijst2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> getallen = new List<int>();
            getallen.Add(10);
            getallen.Add(20);
            getallen.Add(50);
            getallen.Add(40);
            getallen.Add(30);
            PrintLijst(getallen);
            Console.WriteLine("Lijst na sortering");
            getallen.Sort();
            PrintLijst(getallen);
            Console.WriteLine("Positie van getal 10 is: " + getallen.IndexOf(10));
            getallen.Remove(30);//verwijder getal 30 uit de lijst
            Console.WriteLine("Het getal 60 komt voor in de lijst? " + getallen.Contains(60));
            getallen.Reverse();
            Console.WriteLine("Lijst na verwijdering 30 en in omgekeerde volgorde:");
            PrintLijst(getallen);
        }

        private static void PrintLijst(List<int> getallen)
        {
            foreach (int getal in getallen)
                Console.Write(getal + " ");
            Console.WriteLine();
        }
    }
}
