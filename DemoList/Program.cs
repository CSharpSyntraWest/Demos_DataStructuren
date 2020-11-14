using System;
using System.Collections.Generic;

namespace DemoList
{
    class Program
    {
        /*Oefening List<string>
         Maak een lege lijst van cursussen aan
         Voeg aan de lijst (steeds achteraan) "C#", "C++","Java","Ada"
         Sorteer de lijst en print deze af
         verwijder het element "Java"
         Zoek of "C++" in de lijst staat (Contains)
         Zoek de positie van "C#" in de lijst (IndexOf)
         Draai de volgorde om van de elementen (Reverse)
         Voeg op positie 2 "Javascript" toe
         print nogmaals de lijst af
         print het aantal elementen af 
         */
        static void Main(string[] args)
        {
            //List<string> cursussen = new List<string>(); //lege lijst declareren
            List<string> cursussen = new List<string>() { "C#","Java"}; //initialiseren met elementen
            cursussen.Add("Javascript");//Achteraan de lijst toevoegen
            cursussen.Insert(1, "C++");
            cursussen.RemoveAt(2); //Java verwijderen
            Console.WriteLine("Aantal elementen : "+ cursussen.Count);
            cursussen[0] = "Python"; //C# wordt vervangen door Python
            foreach (string cursus in cursussen)
            {
                Console.WriteLine(cursus);
            }
            //alles verwijderen uit lijst=
            cursussen.Clear();//lege lijst
            Console.WriteLine("Aantal elementen : " + cursussen.Count);
        }
    }
}
