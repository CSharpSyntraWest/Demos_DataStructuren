using System;
using System.Collections.Generic;

namespace Demo_Stapel
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> boekenStapel = new Stack<string>();//lege stapel
            boekenStapel.Push("1. De steen der wijzen");
            boekenStapel.Push("2. Pro C# 8");
            boekenStapel.Push("3. WPF programming");
            Console.WriteLine("Top = {0}", boekenStapel.Peek());//kijken wat er bovenaan ligt
            while (boekenStapel.Count > 0)
            {
                string boek = boekenStapel.Pop();
                Console.WriteLine(boek); //First IN LAst out
            }
        }
    }
}
