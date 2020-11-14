using System;
using System.Collections.Generic;

namespace Demo_WachtLijn
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> wachtRijKlanten = new Queue<string>();
            wachtRijKlanten.Enqueue("1. Jan");
            wachtRijKlanten.Enqueue("2. Piet");
            wachtRijKlanten.Enqueue("3. Joris");
            //wie staat als eerst in de rij
            Console.WriteLine("Eerst klant om te bedienen: " + wachtRijKlanten.Peek());
            while (wachtRijKlanten.Count > 0)
            {
                string klant = wachtRijKlanten.Dequeue();
                Console.WriteLine($"Klant {klant} wordt bediend");
            }
        }
    }
}
