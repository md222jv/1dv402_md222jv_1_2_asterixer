using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S1.L02A
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 25; row++)
            {
                if (row % 2 != 0)
                {
                    Console.Write(" "); // test
                }

                for (int column = 0; column < 38; column++)
                {
                    switch (row % 3)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                    }
                    Console.Write("* ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}
