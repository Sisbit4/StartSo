using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину прямоугольника (m) в см: ");
            var m = int.Parse(Console.ReadLine());

            Console.Write("Введите ширину прямоугольника (n) в см: ");
            var n = int.Parse(Console.ReadLine());

            Console.Write("Введите сторону квадрата (k) в см: ");
            var k = int.Parse(Console.ReadLine());

            if (k <= 0 || m <= 0 || n <= 0)
            {
                Console.WriteLine("Все размеры должны быть натуральными числами больше нуля.");
                return;
            }

            int squaresInLength = m / k;
            int squaresInWidth = n / k;

            int totalSquares = squaresInLength * squaresInWidth;

            Console.WriteLine($"Количество квадратов со стороной {k} см, которые можно вырезать: {totalSquares}");

            Console.ReadKey();
        }
    }
}
