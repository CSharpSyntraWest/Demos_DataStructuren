using System;
using System.Collections.Generic;

namespace Demo_VindPriemGetallen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lijstPriemGetallen = new List<int>();
            for (int num = 2; num <= 100; num++)
            {
                //Zoek alle priemgetallen tussen 2 en 100 en zet ze in de lijstPriemGetallen
                bool isPriem = true;
                for (int div = 2; div <= num - 1; div++)
                {
                    if (num % div == 0)
                    {
                        isPriem = false;
                        break; //breek de lus af
                    }
                }
                if (isPriem)
                    lijstPriemGetallen.Add(num);
            }

            foreach (int priemGetal in lijstPriemGetallen)
            {
                Console.Write(priemGetal + " ");
            }
        }
    }
}
