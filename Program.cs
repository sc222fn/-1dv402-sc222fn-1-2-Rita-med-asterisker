using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int kolumn;
            int rad;

            for (rad = 0; rad <= 24; rad++)
            {switch (rad % 3)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                    }
                for (kolumn = 1; kolumn <= 39; kolumn++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

                if (rad % 2 == 0)
                {
                    Console.Write(" ");
                }

                   
            }
        } 
    }
}