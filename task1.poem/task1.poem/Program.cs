using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.poem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Басё");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Аиста гнездо на ветру.");
            Console.WriteLine("А под ним – за пределами бури –");
            Console.WriteLine("Вишен спокойный цвет.");

            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
