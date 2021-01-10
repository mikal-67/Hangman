using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangmansharp
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Gallows g = new Gallows(1);
            g.Display();
            var r = new Random();
            //get a random word from words.txt
            string word = System.IO.File.ReadAllLines("words.txt")[r.Next(System.IO.File.ReadAllLines("words.txt").Length - 1)];
            Console.WriteLine("Hangman version 1.0.0");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
