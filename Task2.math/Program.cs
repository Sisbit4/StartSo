using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Найти площадь и периметр теругольника

            Console.WriteLine("Введите сторону треугольника");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите первый угол при этой стороне");
            var angleA = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй угол при этой стороне");
            var angleB = double.Parse(Console.ReadLine());

            var angleC = 180 - (angleA + angleB);

            var radA = angleA * Math.PI / 180;
            var radB = angleB * Math.PI / 180;
            var radC = angleC * Math.PI / 180;

            var b = a * Math.Sin(radB) / Math.Sin(radA);
            var c = a * Math.Sin(radC) / Math.Sin(radA);

            var perimeter = a + b + c;

            var s = perimeter / 2;
            var area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine("Периметр треугольника: " + Math.Round(perimeter, 2));
            Console.WriteLine("Площадь треугольника: " + Math.Round(area, 2));

            Console.ReadKey();
        }
    }
}
