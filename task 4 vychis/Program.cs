using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4_vychis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите действительное число х");
            var x = double.Parse(Console.ReadLine());

            var y = MyFunction(x);
            Console.WriteLine($"f(x) = {y}");

            Console.ReadKey();
        }

        static double MyFunction(double x)
        {
            //throw new NotImplementedException();

            return Math.Abs((1 + Math.Sqrt(x + 1)) / (1 - Math.Sqrt(x - 1)));
        }
    }
}
