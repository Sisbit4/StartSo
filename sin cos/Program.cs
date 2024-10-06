using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sin_cos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double angleInDegrees = 15;
            double angleInRadians = angleInDegrees * Math.PI / 180;
            var sin = Math.Sin(angleInRadians);
            var cos = Math.Cos(angleInRadians);
            Console.WriteLine("sin(15\xB0) = " + Math.Round(sin, 3));
            Console.WriteLine("cos(15\xB0) = " + Math.Round(cos, 3));

            Console.WriteLine();
            Console.WriteLine("Введите число в градусах");
            double angleInDegrees = double.Parse(Console.ReadLine());
            double angleInRadians = angleInDegrees * Math.PI / 180;
            var sin = Math.Sin(angleInRadians);
            var cos = Math.Cos(angleInRadians);
            Console.WriteLine("sin("+ angleInDegrees +"\xB0) = " + Math.Round(sin, 3));
            Console.WriteLine("cos("+ angleInDegrees +"\xB0) = " + Math.Round(cos, 3));

            Console.ReadKey();
        }
    }
}
