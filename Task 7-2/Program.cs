using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите координаты точки (x, y) через пробел");
            var input = Console.ReadLine();
            var k = input.IndexOf(" "); //индекс пробела в строке 
            var x = double.Parse(input.Substring(0, k)); var y = double.Parse(input.Substring(k + 1));
            if (IsPointInArea(x, y))
                Console.WriteLine($"Точка ({x}; {y}) лежит в указанной области");
            else
                Console.WriteLine($"Точка ({x}; {y}) не лежит в указанной области");
            Console.ReadKey();
        }
        static bool IsPointInArea(double x, double y)
        {
            return (x >= -1 && x <= 1,5 && y >= -0,5 && y <= 2);

        }
    }
}
