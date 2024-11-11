using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение аргумента функции");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine($"f({x}) = {MyFunction(x)}");

            Console.ReadKey();  
        }
        static double MyFunction(double x)
        {
            if (Math.Sin(x) > 0)
                return Math.Cos(x);
            else if (Math.Sin(x) < 0)
                return -(Math.Cos(x));

            return (x / Math.PI);

        }

    }
}
