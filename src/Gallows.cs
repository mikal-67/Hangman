using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangmansharp
{
    /// <summary>
    /// A class representing the gallows.
    /// </summary>
    public class Gallows
    {
        int value = 0;
        public Gallows(int i)
        {
            value = i;
        }
        public void Display()
        {
            Console.Clear();
            if (value == 0)
            {
                Console.WriteLine(" ====================");
                Console.WriteLine(" |                  |");
                Console.WriteLine(" |                  |");
                Console.WriteLine(" |                  |");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
            }
            else if (value == 1)
            {
                Console.WriteLine(" ====================");
                Console.WriteLine(" |                  |");
                Console.WriteLine(" |                  |");
                Console.WriteLine(" |                  |");
                Console.WriteLine(" |                  O");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
            }
            else if (value == 2)
            {
                Console.WriteLine(" ====================");
                Console.WriteLine(" |                  |");
                Console.WriteLine(" |                  |");
                Console.WriteLine(" |                  |");
                Console.WriteLine(" |                  O");
                Console.WriteLine(" |                  |");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
            }
            else if (value == 3)
            {
                Console.WriteLine(" ====================");
                Console.WriteLine(" |                  |");
                Console.WriteLine(" |                  |");
                Console.WriteLine(" |                  |");
                Console.WriteLine(" |                  O");
                Console.WriteLine(" |                 /|");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
            }
            else if (value == 4)
            {
                Console.WriteLine(" ====================");
                Console.WriteLine(" |                  |");
                Console.WriteLine(" |                  |");
                Console.WriteLine(" |                  |");
                Console.WriteLine(" |                  O");
                Console.WriteLine(" |                 /|\\");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
            }
            else if (value == 5)
            {
                Console.WriteLine(" ====================");
                Console.WriteLine(" |                  |");
                Console.WriteLine(" |                  |");
                Console.WriteLine(" |                  |");
                Console.WriteLine(" |                  O");
                Console.WriteLine(" |                 /|\\");
                Console.WriteLine(" |                  /");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
            }
            else if(value == 6)
            {
                Console.WriteLine(" ====================");
                Console.WriteLine(" |                  |");
                Console.WriteLine(" |                  |");
                Console.WriteLine(" |                  |");
                Console.WriteLine(" |                  O");
                Console.WriteLine(" |                 /|\\");
                Console.WriteLine(" |                  /\\");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
                Console.WriteLine(" |                   ");
            }
        }
    }
}
