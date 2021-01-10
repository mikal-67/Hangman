using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangmansharp
{
    /*
     * Mikal
     * https://github.com/mikal-67
     */
    class MainClass
    {
        static void Main(string[] args)
        {
            //initialize variables
            int score = 0;
            int errlevel = 0;
            var r = new Random();
            List<string> guessedLetters = new List<string>();
            //get a random word from words2.txt
            string word = System.IO.File.ReadAllLines("words2.txt")[r.Next(System.IO.File.ReadAllLines("words2.txt").Length - 1)];

            Console.WriteLine("Hangman version 1.0.0");
            
            while(errlevel != 6)
            {
                //display the gallows
                Gallows g = new Gallows(errlevel);
                g.Display();
                //get letter
                Console.WriteLine("Guess a letter.");
                string letter = Console.ReadLine();
                //check letter
                while (letter.Length > 1 || letter.Length < 1)
                {
                    Console.WriteLine("Letter invalid.");
                    Console.WriteLine("Guess a letter.");
                    letter = Console.ReadLine();
                }
                //check if letter has been guessed
                while(guessedLetters.Contains(letter))
                {
                    Console.WriteLine("You already guessed that letter!");
                    letter = Console.ReadLine();
                    while (letter.Length > 1 || letter.Length < 1)
                    {
                        Console.WriteLine("Letter invalid.");
                        Console.WriteLine("Guess a letter.");
                        letter = Console.ReadLine();
                    }
                }
                //back up score
                int i = score;
                //check if letter is in word
                foreach (char c in word)
                {
                    if (c.ToString() == letter)
                    {
                        score++;
                    }
                }
                //if score hasn't changed, the letter must be incorrect
                if (i == score)
                {
                    errlevel++;
                    Console.WriteLine("That letter is incorrect.");
                }
                else
                {
                    Console.WriteLine("That letter is there!");
                }

                if(score == word.Length)
                {
                    Console.WriteLine("You won!");
                    Console.WriteLine($"The word was {word}.");
                    return;
                }
                guessedLetters.Add(letter);
            }
            //if the while loop exits, the player must have lost
            Console.WriteLine("You lost.");
        }
    }
}
