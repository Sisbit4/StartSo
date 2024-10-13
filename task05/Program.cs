using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = F(3, 2) + F(5, 3) + F(7, 4);

            Console.WriteLine($"x = {x:F3}");
            Console.ReadKey();
        }

        static double F(double a, double b)
        {
            return (Math.Log(a + Math.Pow(b, a)))/ (Math.Log(b + Math.Pow(a, b)));
        }
    }
}
